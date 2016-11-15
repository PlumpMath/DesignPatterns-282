namespace DesignPatterns.BuilderExample
{
    public class RequestBuildDirector
    {
        public Request Construct(string url, string username, string password, string body)
        {
            var builder = new RequestBuilder();

            builder.SetUrl(url);
            builder.AddHeader("username", username);
            builder.AddHeader("password", password);
            builder.SetBody(body);

            return builder.Build();
        }
    }
}
