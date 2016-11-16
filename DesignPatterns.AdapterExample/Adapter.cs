namespace DesignPatterns.AdapterExample
{
    class Adapter : ITarget
    {
        Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }

        public NewResponse MakeRequest()
        {
            var oldResponse = _adaptee.MakeRequest();

            return new NewResponse()
            {
                ErrorMessage = oldResponse.ErrorMessage,
                Success = oldResponse.ErrorNumber == 0
            };
        }
    }
}
