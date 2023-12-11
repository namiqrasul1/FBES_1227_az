using ChainOfResponsibility.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models.Deriveds
{
    public class UsernameChecker : BaseChecker
    {
        public override bool Check(object request)
        {
            if(request is Human human) 
                if(!string.IsNullOrWhiteSpace(human.Username))
                    return Next!.Check(request);
            return false;
        }
    }
}
