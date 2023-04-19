using proxybrowser.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxybrowser.Concretes
{
    public class ProxyBrowser : IBrowser
    {
        private Browser? browser;

        public List<string> requests;

        public ProxyBrowser()
        {
            requests =new List<string>();
        }
        public bool CheckTheRequest(string request)
        {
            if (requests.Contains(request))
            {
                return true;
            }
            requests.Add(request);
            return false;

        }
        public void GetRequest(string request)
        {
            if (CheckTheRequest(request))
            {
                Console.WriteLine($"Cache:{request}");
            }
            else
            {
                browser=new Browser();
                browser.GetRequest(request);
            }

        }
    }
}
