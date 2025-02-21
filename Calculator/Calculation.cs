﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        private int a;
        private int b;

        public Calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Execute(String calSymbol)
        {
            int result = 0;

            switch (calSymbol)
            {
                case "+":
                    result = this.a + this.b;
                    break;
                case "-":
                    result = this.a - this.b;
                    break;
                case "*":
                    result = this.a * this.b;
                    break;
                case "/":
                    result = this.a / this.b;
                    break;
            }

            return result;
        }
    }
}
