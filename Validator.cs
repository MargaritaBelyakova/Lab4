using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Validator
    {
        private readonly int[] snils = new int[11];
        public int[] Snils { get { return snils; } }

        public Validator(string snils)
        {
            this.snils = snils.Select(x => x - '0').ToArray();
            
        }
        public long ConvertSnils()
        {
            long result = 0;
            for (int i = 0; i < snils.Length; i++)
            {
                result *= 10;
                result += snils[i];
            }
            return result;
        }

        public bool ValidateChecksum()
        {            
            if (ConvertSnils() > 00100199800)
            {
                int checksum = 0;
                for (int i = snils.Length; i > snils.Length-2; i--)
                {
                    checksum *= i * 10;
                    checksum += snils[i];
                }
                int calculatedChecksum = 0;
                return true;
            }                
            else
            {
                return false;
            }
        }
    }
}
