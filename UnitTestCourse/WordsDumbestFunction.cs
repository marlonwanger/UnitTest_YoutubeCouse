﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCourse
{
    public class WordsDumbestFunction
    {
        public string ReturnsPikachuIfZero(int num)
        {
            if(num == 0)
            {
                return "PIKACHU!";
            }
            else
            {
                return "Squirtle";
            }
        }
    }
}
