﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCodeWithoutGenericClass
{
    internal class Logger
    {
        public void Log<T>(T message) 
        { 
            Console.WriteLine(message);
        }
    }
}