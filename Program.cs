using System;

namespace SearchingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchingSystem system = SearchingSystem.GetInstance();

            system.GetSite("google.com");
            system.GetSite("unity.com");
            system.GetSite("google.com");
            system.GetSite("youtube.com");
            system.GetSite("uzhnu.edu.ua");
            system.PrintAllRequest();
        }
    }
}