using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public abstract class DocumentPartVisitor
    {
        public void DynamicVisit(DocumentPart parts) => Visit((dynamic)parts);

        protected abstract string Visit(PlainText part);

        protected abstract string Visit(Hyperlink part);

        protected abstract string Visit(BoldText part);
    }
}
