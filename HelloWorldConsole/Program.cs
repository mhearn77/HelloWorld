using HelloWorldLibrary;
using System.Configuration;

namespace HelloWorldConsoleExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            string writeType =  ConfigurationManager.AppSettings["OutputLocation"].ToString();

            AppInstance app = new AppInstance();

            switch (writeType)
            {
                case "Console":
                    app.SetApiType(new HelloWorldConsole("Hello World"));
                    app.WriteMessage();
                    break;
                case "Database":
                    app.SetApiType(new HelloWorldDatabase("Hello World", "Some connection string..."));
                    app.WriteMessage();
                    break;
                default:
                    app.SetApiType(new HelloWorldConsole("Hello World"));
                    app.WriteMessage();
                    break;
            }
        }
    }
}
