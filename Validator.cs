﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Validator
    {
        private readonly long snils;
        public long Snils { get { return snils; } }

        public Validator(long snils)
        {
            this.snils = snils;
        }
        public bool ValidateChecksum()
        {
            if (snils > 00100199800)
            {
                return true;
            }                
            else
            {
                return false;
            }
        }
    }
}
