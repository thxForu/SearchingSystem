using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchingSystem
{
    public class SearchingSystem
    {
        public static SearchingSystem instance;

        private Dictionary<string,int> _requestDictionary = new Dictionary<string,int>();
        private Dictionary<string,DateTime> _dateTimesDictionary = new Dictionary<string, DateTime>();
        
        private string[] listSite = new[] {"google.com", "weather.com"};
        public static SearchingSystem GetInstance()
        {
            return instance ??= new SearchingSystem();
        }
        public void GetSite(string site)
        {
            if (_requestDictionary.ContainsKey(site))
            {
                _requestDictionary[site] += 1;
            }
            else
            {
                _requestDictionary.Add(site, 1);
            }

            if (_dateTimesDictionary.ContainsKey(site))
            {
                return;
            }
            else
            {
                _dateTimesDictionary.Add(site, DateTime.Now);
            }
            Console.WriteLine("Your search: ");
            foreach (var sites in listSite)
            {
                Console.WriteLine(sites);
            }
        }

        public void PrintAllRequest()
        {
            var sortedRequest = from s in _requestDictionary orderby s.Value ascending select s;
            foreach (var request in sortedRequest.Reverse())
            {
                Console.WriteLine("Site: {0}, Count: {1}",request.Key,request.Value);
            }

            foreach (var request in _dateTimesDictionary)
            {
                Console.WriteLine("Site: {0}, Time: {1}",request.Key,request.Value);

            }
        }
    }
}