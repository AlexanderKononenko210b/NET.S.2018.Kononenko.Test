using System;
using System.IO;

namespace Task2.Solution
{
    public class RandomBytesFileGenerator : FileGenerator
    {
        #region Properties

        public override string WorkingDirectory => "Files with random bytes";

        public override string FileExtension => ".bytes";

        #endregion Properties

        #region Private members

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }

        #endregion
    }
}