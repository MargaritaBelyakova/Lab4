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
        public static string Validate()
        {
            return "СНИЛС прошел проверку";
        }

        public static bool ValidateNumbersCount(string snils)
        {
            int count = 0;
            for (int i = 0; i < snils.Length; i++)
                count++;
            if (count == 11)
                return true;
            else
                return false;
        }

        public static bool ValidateDigits(string snils)
        {
            for (int i = 0; i < snils.Length; i++)
                if (!char.IsDigit(snils[i]))
                    return false;
            return true;
        }

        public bool NumbersInRow(string snils)
        {
            for (int i = 0; i < snils.Length - 2; i++)
                if (snils[i] == snils[i + 1] && snils[i] == snils[i + 2])
                    return false;
            return true;
        }

        public bool ValidateChecksum()
        {            
            if (ConvertSnils() > 00100199800)
            {
                long checksum = ConvertSnils()%100;
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
                if ((calculatedChecksum == 100 || calculatedChecksum == 101) && checksum == 0)
                {
                    return true;
                }
                if (calculatedChecksum > 101 && calculatedChecksum%101 == checksum)
                {
                    return true;
                }
                return false;
            }                
            else
            {
                return true;
            }
        }
    }
}
