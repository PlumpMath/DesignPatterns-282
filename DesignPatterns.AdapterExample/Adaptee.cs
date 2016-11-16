namespace DesignPatterns.AdapterExample
{
    class Adaptee
    {
        public OldResponse MakeRequest()
        {
            return new OldResponse()
            {
                ErrorMessage = "Critical error!",
                ErrorNumber = 100
            };
        }
    }
}
