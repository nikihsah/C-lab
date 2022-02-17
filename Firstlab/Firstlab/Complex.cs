﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Firstlab
{

    class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        public void Add(Complex x)
        {
            Real += x.Real;
            Imag += x.Imag;
        }

        public void Substract(Complex x)
        {
            Real -= x.Real;
            Imag -= x.Imag;
        }

        public string Divide(Complex x)
        {
            return
                $"{(Real * x.Real + Imag * x.Imag) / (Math.Pow(x.Imag, 2) + Math.Pow(x.Real, 2))} + {(x.Real * Imag - Real * x.Imag) / (Math.Pow(x.Imag, 2) + Math.Pow(x.Real, 2))}i";
        }

        public string Multiply(Complex x)
        {
            return $"{Real * x.Real - Imag * x.Imag} + ({Real * x.Imag + Imag * x.Real})i";
        }
    }
}
