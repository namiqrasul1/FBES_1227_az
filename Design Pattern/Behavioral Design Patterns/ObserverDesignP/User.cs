using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignP
{
    internal class User : ISubject
    {
        public string? Name { get; set; }

        public List<Friend> Friends { get; set; } = new();
        public List<string> Posts { get; set; } = new();
        public List<IObserver> Observers { get; set; } = new();

        public void Attach(IObserver observer)
        {
            Console.WriteLine($"User{Name}:Attached an observer.");
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Observers.Remove(observer);
            Console.WriteLine($"User{Name}:Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine($"User{Name}:Notifying observers..");
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }
        public void AddPost(string post)
        {
            Posts.Add(post);
            Console.WriteLine($"User{Name}:Added new post - {post}.");
            Notify();
        }
    }
}
