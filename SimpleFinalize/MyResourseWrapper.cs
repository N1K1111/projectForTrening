﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFinalize
{
    internal class MyResourseWrapper
    {
        ~MyResourseWrapper() => Console.Beep();
    }
}
