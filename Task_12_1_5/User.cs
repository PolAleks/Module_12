﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_1_5
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public void Greetings()
        {
            Console.WriteLine($"Добро пожаловать, {Name}");
        }
    }
}
