namespace HelloWorldLibrary
{
    public class AppInstance
    {
        IHelloWorldAPI apiType;

        public void SetApiType(IHelloWorldAPI type)
        {
            apiType = type;
        }

        public IHelloWorldAPI GetApiType()
        {
            return apiType;
        }

        public void SetMessage(string message)
        {
            apiType.SetMessage(message);
        }

        public void WriteMessage()
        {
            apiType.WriteMessage();
        }

        public string GetMessage()
        {
            return apiType.GetMessage();
        }
    }
}
