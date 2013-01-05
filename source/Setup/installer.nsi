;NSIS Modern User Interface
;Basic Example Script
;Written by Joost Verburg

;--------------------------------
;Include Modern UI

  !include "MUI2.nsh"

;--------------------------------
;General

  ;Name and file
  Name "Blade"
  OutFile "..\..\release\latest\Setup.exe"

  ;Default installation folder
  InstallDir "$PROGRAMFILES\Blade"
  
  ;Get installation folder from registry if available
  InstallDirRegKey HKLM "Software\Vannatech\Blade" "InstallDir"

  ;Request application privileges for Windows Vista
  RequestExecutionLevel admin

;--------------------------------
;Interface Settings

  !define MUI_ABORTWARNING

;--------------------------------
;Pages

  !insertmacro MUI_PAGE_LICENSE "License.txt"
  !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_INSTFILES
  
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES
  
;--------------------------------
;Languages
 
  !insertmacro MUI_LANGUAGE "English"

  !define VS2010_SECTIONAME "Visual Studio 2010"
  !define VS2012_SECTIONAME "Visual Studio 2012"
  !define SD_SECTIONAME "SharpDevelop"
      
  !define VS_EXT_PATH "Extensions\Blade\1.0"
  
  Var VS2010Path
  Var VS2012Path
  Var SDPath  
  
;--------------------------------
;Installer Sections

Section "Core components" SecCore
  SectionIn RO
  SetOutPath "$PROGRAMFILES\MSBuild\Blade"  
  File "..\bin\build\*.*"
  File "..\core\resources\Blade.CSharp.targets"
  File "..\Tools\Quality\Resources\Blade.CSharp.Test.targets"

  SetOutPath "$PROGRAMFILES\Reference Assemblies\Microsoft\Framework\Blade\v4.0"
  File "..\bin\runtime\*.dll"
  File "..\bin\runtime\*.xml"

  SetOutPath "$PROGRAMFILES\Reference Assemblies\Microsoft\Framework\Blade\v4.0\RedistList"
  File "..\core\resources\FrameworkList.xml"
  
  SetOutPath "$INSTDIR"
  File "license.txt"
  
  ;Store installation folder
  WriteRegStr HKLM "Software\Vannatech\Blade" "InstallDir" $INSTDIR
  
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\BladeCompiler" "DisplayName" "Blade Compiler"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\BladeCompiler" "UninstallString" "$\"$INSTDIR\uninstall.exe$\""

  ;Create uninstaller
  WriteUninstaller "$INSTDIR\Uninstall.exe"
SectionEnd

Section /o "" SEC_VS2010
  SetOutPath $VS2010Path${VS_EXT_PATH}
  File /r "VSIXOutput\*"
  WriteRegStr HKLM "Software\Vannatech\Blade\VS2010" "ExtInstallDir" $VS2010Path${VS_EXT_PATH}
SectionEnd

Section /o "" SEC_VS2012
  SetOutPath $VS2012Path${VS_EXT_PATH}
  File /r "VSIXOutput\*"
  WriteRegStr HKLM "Software\Vannatech\Blade\VS2012" "ExtInstallDir" $VS2012Path${VS_EXT_PATH}
  ExecWait '"$VS2012Path\devenv.exe" /setup'
SectionEnd

Section "" SEC_SD
SectionEnd

;--------------------------------
;Descriptions

  ;Language strings
  LangString DESC_SecCore ${LANG_ENGLISH} "Blade core components."

  ;Assign language strings to sections
  !insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
  !insertmacro MUI_DESCRIPTION_TEXT ${SecCore} $(DESC_SecCore)
  !insertmacro MUI_FUNCTION_DESCRIPTION_END

;--------------------------------
;Uninstaller Section

Section "Uninstall"

  ;ADD YOUR OWN FILES HERE...

  Delete "$INSTDIR\Uninstall.exe"
  Delete "$INSTDIR\license.txt"

  RMDir "$INSTDIR"
  RMDir /r "$PROGRAMFILES\MSBuild\Blade"
  RMDir /r "$PROGRAMFILES\Reference Assemblies\Microsoft\Framework\Blade\v4.0"
  RMDir "$PROGRAMFILES\Reference Assemblies\Microsoft\Framework\Blade"
  
  ReadRegStr $0 HKLM "Software\Vannatech\Blade\VS2010" "ExtInstallDir"
  ${If} $0 != ""
    RMDir /r $0
  ${EndIf}
  
  ReadRegStr $0 HKLM "Software\Vannatech\Blade\VS2012" "ExtInstallDir"
  ${If} $0 != ""
    RMDir /r $0
  ${EndIf}

  DeleteRegKey /ifempty HKLM "Software\Vannatech\Blade"
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\BladeCompiler"
  
SectionEnd

Function .onInit
  ReadRegStr $VS2010Path HKLM SOFTWARE\Microsoft\VisualStudio\10.0 "InstallDir"
  ${If} $VS2010Path != ""
    SectionSetText ${SEC_VS2010} "${VS2010_SECTIONAME}"
    SectionSetFlags ${SEC_VS2010} ${SF_SELECTED}
  ${EndIf}

  ReadRegStr $VS2012Path HKLM SOFTWARE\Microsoft\VisualStudio\11.0 "InstallDir"
  ${If} $VS2012Path != ""
    SectionSetText ${SEC_VS2012} "${VS2012_SECTIONAME}"
    SectionSetFlags ${SEC_VS2012} ${SF_SELECTED}
  ${EndIf}
FunctionEnd