using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Solution.Visitors;

namespace Task5.Solution.Extensions
{
    public static class DocumentToLaTeXExtansion
    {
        public static string ToLaTeX(this Document document)
        {
            var visitor = new ToPlainTextVisitor();

            visitor.DynamicVisit(document.parts);

            return visitor.Result;
        }
    }
}
