using System;

namespace HelloWorldLibrary
{
    public class HelloWorldConsole : IHelloWorldAPI
    {
        public string Message;

        public HelloWorldConsole()
        {
        }

        public HelloWorldConsole(string message)
        {
            Message = message;
        }

        public void SetMessage(string message)
        {
            Message = message;
        }

        public void WriteMessage()
        {
            Console.WriteLine(Message);
        }

        public string GetMessage()
        {
            return Message;
        }
    }

    public class HelloWorldDatabase : IHelloWorldAPI
    {
        public string Message;
        public string ConnectionString;

        public HelloWorldDatabase()
        {
        }

        public HelloWorldDatabase(string message, string connString)
        {
            Message = message;
            ConnectionString = connString;
        }

        public void SetMessage(string message)
        {
            Message = message;
        }

        public void SetConnection(string connection)
        {
            ConnectionString = connection;
        }

        public void WriteMessage()
        {
            throw new NotImplementedException();
        }

        public string GetMessage()
        {
            return Message;
        }
    }
}

