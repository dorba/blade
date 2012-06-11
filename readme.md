## What is Blade? ##

Blade is a set of tools that convert C# to JavaScript.

#### Cool! How does it work? ####

Blade exists as an add-on for Visual Studio 2010. You start by creating a Blade Class Library project, which is very similar to a standard C# Class Library. However, in addition to building an assembly, a Blade project also translates your C# to JavaScript. Next simply take the generated script and link into your HTML (ASPX, or whatever else you may be using) page. Don't forget, you can also reference your output assembly in other Blade projects as well. Now, go start building a well-structured core JavaScript framework for your application!

#### Wait... why would I want to do that? ####

You mean, why would you want to have support for features like application wide refactoring, Intellisense, and build-time error feedback? Or were you asking why you'd want to be able to leverage class-based object oriented design patterns, with inheritance, interfaces, and generics?

#### Hey! Why you hatin' on JavaScript!? ####

You got us all wrong! Seriously, we like JavaScript. It's a wonderfully flexible language with all sorts of potential. And we certainly won't claim that Blade should replace all of your JS files. Blade proves to be most useful is larger applications that have a relatively complex client side architecture. In these situations JavaScript's dynamic nature can easily begin to work against you. Simply put, Visual Studio and C# can help you better manage these types of projects.

#### So you implemented the .NET Framework, on the client? ####

Nope. Like we said, we like JavaScript! The Blade runtime libraries are accurate representations of the DOM, HTML, CSS, and ECMAScript specifications. This is worth repeating - Blade does not abstract the browser APIs. Understanding that you're coding for a different environment is key. Embrace this concept and use it to your advantage!

#### What's the fastest way to give it a try? ####

Look in the root bin directory, and grab the latest prebuilt installer binary. While that's running, navigate over to the docs directory and take a look at the user guide. You can also clone and build the full Blade source code to achieve a similar result without executing the installer. If you prefer that route, refer to the user guide for more detailed instructions.

#### And remember... ####

Blade is quite young at this point. We've worked hard to put together a fairly large internal test suite to try and ensure all the scenarios your try will work properly. But don't be surprised if you run into some issues. The good news is, if you submit a bug report we'll try hard to fix it. And of course, you're also welcome and encouraged to fork the project and make improvements yourself too!