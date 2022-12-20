using System;

using R5T.T0132;


namespace R5T.F0095
{
    [FunctionalityMarker]
    public partial interface ICodeFileGenerationOperations : IFunctionalityMarker
    {
        public void CreateWinFormsResxTemplate(
            string resxFilePath)
        {
            var templateFilePath = FilePaths.Instance.WinFormsResxTemplate;

            F0000.FileSystemOperator.Instance.CopyFile(
                templateFilePath,
                resxFilePath);
        }
    }
}
