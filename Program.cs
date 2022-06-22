using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Напишите номер СНИЛС");
                var snils = Console.ReadLine();
                Console.WriteLine(Validator.Validate(snils));
            }

        }
    }
}
