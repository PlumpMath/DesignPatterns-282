namespace DesignPatterns.DecoratorExample
{
    public class Letter : IDocument
    {
        string _body;

        public Letter(string body)
        {
            _body = body;
        }

        public string GetBody()
        {
            return _body;
        }
    }
}
