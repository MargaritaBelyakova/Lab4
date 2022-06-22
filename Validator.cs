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
                int checksum = (int)ConvertSnils()%100;
                if (checksum < 0)
                    checksum = 0;
                int calculatedChecksum = 0;
                int numbers = snils.Length - 2;
                for (int i = 0; i < numbers; i++)
                {
                    calculatedChecksum += snils[i] * (numbers - i);
                }
                if (calculatedChecksum < 100 && calculatedChecksum == checksum)
                {
                    return true;
                }
                if (calculatedChecksum == 100 && checksum == 0)
                {
                    return true;
                }
                return false;
            }                
            else
            {
                return false;
            }
        }
    }
}
