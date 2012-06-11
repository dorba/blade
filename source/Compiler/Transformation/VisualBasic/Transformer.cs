using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.VisualBasic;

namespace Blade.Compiler.Transformation.VisualBasic
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        // TODO: when/if this is implemented, research to see how 
        // we could share processes between common syntax node types.
        // For example, an Argument syntax could likely be parsed
        // using the same method for both C# and VB.
    }
}
