namespace DesignPatterns.BuilderExample
{
    public interface IRequestBuilder
    {
        IRequestBuilder SetUrl(string url);

        IRequestBuilder AddHeader(string key, string value);

        IRequestBuilder SetBody(string body);

        Request Build();
    }
}