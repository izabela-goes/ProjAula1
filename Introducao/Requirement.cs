using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao
{
    class Requirement
    {
        static void Main (string[] args)
        {
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade!");
                Console.WriteLine("A idade digitada é: " + idade);
            }
                
            else
                Console.WriteLine("Menor de idade!");

            switch (idade)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            Console.ReadKey();

        }
    }
}
