using System.Collections.Generic;

namespace DesignPatterns.BuilderExample
{
    public class RequestBuilder : IRequestBuilder
    {
        Request _request;

        public RequestBuilder()
        {
            _request = new Request();
        }

        public IRequestBuilder AddHeader(string key, string value)
        {
            if (_request.Headers == null)
                _request.Headers = new Dictionary<string, string>();

            _request.Headers.Add(key, value);
            return this;
        }

        public IRequestBuilder SetBody(string body)
        {
            _request.Body = body;
            return this;
        }

        public IRequestBuilder SetUrl(string url)
        {
            _request.Url = url;
            return this;
        }

        public Request Build()
        {
            return _request;
        }
    }
}
