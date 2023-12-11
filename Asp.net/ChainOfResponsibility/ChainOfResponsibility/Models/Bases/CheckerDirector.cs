using ChainOfResponsibility.Models.Deriveds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models.Bases
{
    public class CheckerDirector
    {
        public bool MakeHumanChecker(Human human)
        {
            UsernameChecker usernameChecker = new();
            PasswordChecker passwordChecker = new();
            EmailChecker emailChecker = new();
            usernameChecker.Next = passwordChecker;
            passwordChecker.Next = emailChecker;

            return usernameChecker.Check(human);
        }
    }
}
