using System;


namespace R5T.F0095
{
    public class CodeFileGenerationOperations : ICodeFileGenerationOperations
    {
        #region Infrastructure

        public static ICodeFileGenerationOperations Instance { get; } = new CodeFileGenerationOperations();


        private CodeFileGenerationOperations()
        {
        }

        #endregion
    }
}
