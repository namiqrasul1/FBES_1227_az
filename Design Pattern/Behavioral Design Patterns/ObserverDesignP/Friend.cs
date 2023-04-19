using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignP
{
    internal class Friend : IObserver
    {
        private string _name;
        public Friend(string name)
        {
            _name = name;
        }

        public void Deconstruct(out string name, out int a)
        {
            name = _name;
            a = 1;
        }

        public void Update(User user)
        {
            foreach (var observer in user.Observers)
            {
                if (observer is Friend f && f._name == _name)
                {
                    Console.WriteLine($"Dear {_name}, your friend {user.Name} just posted a new update: {user.Posts.Last()}");
                }
            }
        }
    }
}
