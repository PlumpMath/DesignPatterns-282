namespace DesignPatterns.DecoratorExample
{
    public class DoubleSpacedDocument : DocumentDecorator
    {
        public DoubleSpacedDocument(IDocument document) : base(document)
        {
        }

        public override string GetBody()
        {
            return base.GetBody().Replace(" ", "  ");
        }
    }
}
