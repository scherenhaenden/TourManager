using Chromely.Core;

namespace ChromelyCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic example of the application builder
            AppBuilder
            .Create()
            .UseApp<MyChromelyApp>()
            .Build()
            .Run(args);
        }
    }
}
