using System;

using R5T.T0131;


namespace R5T.F0095
{
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
        public string WinFormsResxTemplate => FilesDirectoryOperator.Instance.GetFilesDirectoryFilePath(
            FileNames.Instance.WinFormsResxTemplate);
    }
}
