namespace CSharpStaticAnalyzer.Core.DiagnosticHandlers.SA
{
    public class SA1628DocumentationTextMustBeginWithACapitalLetter : DiagnoticHandler
    {
        public override Serverity Serverity
        {
            get
            {
                return Serverity.None;
            }
        }
    }
}