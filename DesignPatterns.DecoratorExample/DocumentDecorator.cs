namespace DesignPatterns.DecoratorExample
{
    public abstract class DocumentDecorator : IDocument
    {
        IDocument _document;

        public DocumentDecorator(IDocument document)
        {
            _document = document;
        }

        public virtual string GetBody()
        {
            return _document.GetBody();
        }
    }
}
