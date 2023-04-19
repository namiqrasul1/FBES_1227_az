using proxybrowser.Abstracts;
using proxybrowser.Concretes;

IBrowser browser = new ProxyBrowser();
while (true)
{
    Console.WriteLine("Enter the request:");
    string request=Console.ReadLine();
    browser.GetRequest(request);
}
