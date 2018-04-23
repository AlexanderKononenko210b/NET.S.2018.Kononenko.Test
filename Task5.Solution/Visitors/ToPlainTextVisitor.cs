using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution.Visitors
{
    public class ToPlainTextVisitor : DocumentVisitor
    {
        public string Result { get; private set; } = String.Empty;

        protected override string Visit(PlainText part)
        {
            Result += part.Text;

            return Result;
        }

        protected override string Visit(Hyperlink part)
        {
            Result += part.Text + " [" + part.Url + "]";

            return Result;
        }

        protected override string Visit(BoldText part)
        {
            Result += "**" + part.Text + "**";
            
            return Result;
        }
    }
}
