using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Solution.Visitors;

namespace Task5.Solution
{
    public static class DocumentExtension
    {
        public static string ToHtml(this Document document)
        {
            var visitor = new ToHtmlVisitor();

            foreach (DocumentPart item in document.Parts)
            {
                visitor.DynamicVisit(item);
            }

            return visitor.Result;
        }

        public static string ToLaTeX(this Document document)
        {
            var visitor = new ToPlainTextVisitor();

            foreach (DocumentPart item in document.Parts)
            {
                visitor.DynamicVisit(item);
            }

            return visitor.Result;
        }

        public static string ToPlainText(this Document document)
        {
            var visitor = new ToPlainTextVisitor();

            foreach (DocumentPart item in document.Parts)
            {
                visitor.DynamicVisit(item);
            }

            return visitor.Result;
        }
    }
}
