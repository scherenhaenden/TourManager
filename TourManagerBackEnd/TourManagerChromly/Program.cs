using System;
using Chromely.Core;

namespace TourManagerChromly
{
    class Program
    {
        static void Main(string[] args)
        {
            AppBuilder
                .Create()
                .UseApp<DemoChromelyApp>()
                .Build()
                .Run(args);
        }
    }
}