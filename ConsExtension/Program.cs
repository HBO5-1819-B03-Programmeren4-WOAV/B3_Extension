﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "extension.method@visualstudio.net";
            Console.WriteLine($"{email} is emailadres: {email.IsValidEmailAddress()}");
            Console.ReadKey();
        }
    }
}
