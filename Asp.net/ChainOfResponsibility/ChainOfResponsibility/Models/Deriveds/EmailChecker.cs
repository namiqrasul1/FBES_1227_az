﻿using ChainOfResponsibility.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models.Deriveds
{
    public class EmailChecker : BaseChecker
    {
        public override bool Check(object request)
        {
            if (request is Human human)
                return !string.IsNullOrWhiteSpace(human.Email) && human.Email.Contains('@');
            return false;
        }
    }
}
