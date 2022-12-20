using System;

using R5T.T0132;


namespace R5T.F0095
{
    [FunctionalityMarker]
    public partial interface IFilesDirectoryOperator : IFunctionalityMarker,
        F0091.IFilesDirectoryOperator
    {
        public string GetFilesDirectoryFilePath(string fileName)
        {
            var filePath = this.GetFilesDirectoryFilePath_UsingProjectNameDirectory(
                DirectoryNames.Instance.ProjectNameDirectory,
                fileName);

            return filePath;
        }
    }
}
