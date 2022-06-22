using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    static public class Validator
    {        
        public static long ConvertSnils(string snils)
        {
            int[] _snils = snils.Select(x => x - '0').ToArray();
            long result = 0;
            for (int i = 0; i < _snils.Length; i++)
            {
                result *= 10;
                result += _snils[i];
            }
            return result;
        }
        public static string Validate(string snils)
        {
            if (!ValidateNumbersCount(snils))
                return "Количество символов не соответсвует";
            if (!ValidateDigits(snils))
                return "СНИЛС может содердать только цифры";
            if (!NumbersInRow(snils))
                return "В СНИЛСЕ не может содержаться цифра три раза подряд";
            if (!ValidateChecksum(snils))
                return "Контрольная сумма не прошла проверку";
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

        public static bool NumbersInRow(string snils)
        {
            for (int i = 0; i < snils.Length - 2; i++)
                if (snils[i] == snils[i + 1] && snils[i] == snils[i + 2])
                    return false;
            return true;
        }

        public static bool ValidateChecksum(string snils)
        {            
            if (ConvertSnils(snils) > 00100199800)
            {
                long checksum = ConvertSnils(snils)%100;
                if (checksum < 0)
                    checksum = 0;
                int calculatedChecksum = 0;
                int numbers = snils.Length - 2;
                for (int i = 0; i < numbers; i++)
                {
                    calculatedChecksum += Convert.ToInt32(snils[i] - '0') * (numbers - i);
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
