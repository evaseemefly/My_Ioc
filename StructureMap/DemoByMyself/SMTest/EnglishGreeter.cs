﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTest
{
    public class EnglishGreeter : IGreeter
    {
        public string GetGreeting()
        {
            return "hello";
        }
    }
}
