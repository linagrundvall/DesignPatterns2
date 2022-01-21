﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    interface IMachineState
    {
        public void PowerSwitch();
        public void Print(string stuff);
    }
}
