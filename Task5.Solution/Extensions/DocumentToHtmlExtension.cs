using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Solution.Visitors;

namespace Task5.Solution.Extensions
{
    public static class DocumentToHtmlExtension
    {
        public static string ToHtml(this Document document)
        {
            var visitor = new ToHtmlVisitor();

            visitor.DynamicVisit(document.parts);

            return visitor.Result;
        }
    }
}
