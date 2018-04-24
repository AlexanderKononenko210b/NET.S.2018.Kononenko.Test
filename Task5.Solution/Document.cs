using System;
using System.Collections.Generic;

namespace Task5.Solution
{
    public class Document
    {
        private List<DocumentPart> parts;

        public IEnumerable<DocumentPart> Parts
        {
            get
            {
                foreach (DocumentPart item in parts)
                {
                    yield return item;
                }
            }
        }

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }

            this.parts = new List<DocumentPart>(parts);
        }
    }
}
