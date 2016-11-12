namespace DesignPatterns.DecoratorExample
{
    public class CapitalizedDocument : DocumentDecorator
    {
        public CapitalizedDocument(IDocument document) : base(document)
        {
        }

        public override string GetBody()
        {
            return base.GetBody().ToUpper();
        }
    }
}
