
// NOTE:
// items defined in this file are not intended for use 
// they are here to support the C# dynamic type feature
// each of the defined classes and members are required by the compiler.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

#pragma warning disable 1591 // disable comment warnings

namespace Microsoft.CSharp.RuntimeBinder
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class Binder
    {
        public static CallSiteBinder InvokeMember(CSharpBinderFlags flags, string name, IEnumerable<Type> typeArguments, Type context, IEnumerable<CSharpArgumentInfo> argumentInfo) { return null; }
        public static CallSiteBinder InvokeConstructor(CSharpBinderFlags flags, Type context, IEnumerable<CSharpArgumentInfo> argumentInfo) { return null; }
        public static CallSiteBinder Invoke(CSharpBinderFlags flags, Type context, IEnumerable<CSharpArgumentInfo> argumentInfo) { return null; }
        public static CallSiteBinder Convert(CSharpBinderFlags flags, Type type, Type context) { return null; }
        public static CallSiteBinder GetMember(CSharpBinderFlags flags, string name, Type context, IEnumerable<CSharpArgumentInfo> argumentInfo) { return null; }
        public static CallSiteBinder SetMember(CSharpBinderFlags flags, string name, Type context, IEnumerable<CSharpArgumentInfo> argumentInfo) { return null; }
        public static CallSiteBinder BinaryOperation(CSharpBinderFlags flags, ExpressionType operation, Type context, IEnumerable<CSharpArgumentInfo> argumentInfo) { return null; }
        public static CallSiteBinder UnaryOperation(CSharpBinderFlags flags, ExpressionType operation, Type context, IEnumerable<CSharpArgumentInfo> argumentInfo) { return null; }
        public static CallSiteBinder GetIndex(CSharpBinderFlags flags, Type context, IEnumerable<CSharpArgumentInfo> argumentInfo) { return null; }
        public static CallSiteBinder SetIndex(CSharpBinderFlags flags, Type context, IEnumerable<CSharpArgumentInfo> argumentInfo) { return null; }
        public static CallSiteBinder IsEvent(CSharpBinderFlags flags, string name, Type context) { return null; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public enum CSharpBinderFlags
    {
        None = 0,
        CheckedContext = 1,
        InvokeSimpleName = 2,
        InvokeSpecialName = 4,
        BinaryOperationLogical = 8,
        ConvertExplicit = 16,
        ConvertArrayIndex = 32,
        ResultIndexed = 64,
        ValueFromCompoundAssignment = 128,
        ResultDiscarded = 256
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class CSharpArgumentInfo
    {
        public static CSharpArgumentInfo Create(CSharpArgumentInfoFlags flags, string name) { return null; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public enum CSharpArgumentInfoFlags
    {
        None = 0,
        UseCompileTimeType = 1,
        Constant = 2,
        NamedArgument = 4,
        IsRef = 8,
        IsOut = 16,
        IsStaticType = 32
    }
}

namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class CallSite
    {
        public static CallSite Create(Type delegateType, CallSiteBinder binder) { return null; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class CallSite<T> : CallSite where T : class
    {
        public T Target;
        public static CallSite<T> Create(CallSiteBinder binder) { return null; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class CallSiteBinder { }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class DynamicAttribute : Attribute
    {
        public IEnumerable<bool> TransformFlags { get { return null; } }

        public DynamicAttribute() { }
        public DynamicAttribute(bool[] transformFlags) { }
    }
}

namespace System.Linq.Expressions
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public enum ExpressionType
    {
                Add,
                AddChecked,
                And,
                AndAlso,
                ArrayLength,
                ArrayIndex,
                Call,
                Coalesce,
                Conditional,
                Constant,
                Convert,
                ConvertChecked,
                Divide,
                Equal,
                ExclusiveOr,
                GreaterThan,
                GreaterThanOrEqual,
                Invoke,
                Lambda,
                LeftShift,
                LessThan,
                LessThanOrEqual,
                ListInit,
                MemberAccess,
                MemberInit,
                Modulo,
                Multiply,
                MultiplyChecked,
                Negate,
                UnaryPlus,
                NegateChecked,
                New,
                NewArrayInit,
                NewArrayBounds,
                Not,
                NotEqual,
                Or,
                OrElse,
                Parameter,
                Power,
                Quote,
                RightShift,
                Subtract,
                SubtractChecked,
                TypeAs,
                TypeIs,
                Assign,
                Block,
                DebugInfo,
                Decrement,
                Dynamic,
                Default,
                Extension,
                Goto,
                Increment,
                Index,
                Label,
                RuntimeVariables,
                Loop,
                Switch,
                Throw,
                Try,
                Unbox,
                AddAssign,
                AndAssign,
                DivideAssign,
                ExclusiveOrAssign,
                LeftShiftAssign,
                ModuloAssign,
                MultiplyAssign,
                OrAssign,
                PowerAssign,
                RightShiftAssign,
                SubtractAssign,
                AddAssignChecked,
                MultiplyAssignChecked,
                SubtractAssignChecked,
                PreIncrementAssign,
                PreDecrementAssign,
                PostIncrementAssign,
                PostDecrementAssign,
                TypeEqual,
                OnesComplement,
                IsTrue,
                IsFalse
    }
}

#pragma warning restore 1591 // restore comment warnings