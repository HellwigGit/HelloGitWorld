﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGitWorld
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CalculateAgeFromName(string name)
        {
            return name.Length;
        }
    }
}
