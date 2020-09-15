using System;
using System.Collections.Generic;
using System.Text;

namespace calc.Models
{
    public class Add
    {
        public double numberOne { get; set; }
        public double numberTwo { get; set; }


        public double AddNumbers()
        {
            return (numberOne + numberTwo);
        }


    }
}
