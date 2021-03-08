using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao
{
    class Program
    {
        static void Main(string[] args)
        { 

            string nome = "Izabela";


            Console.WriteLine("EX1 - Nome:" + nome);

            int a = 2;
            int b = 3;
            int c = a + b;

            Console.WriteLine("EX2 - Soma de A + B:" + c);
            Console.WriteLine("EX3 - Soma de A + B:" +a +b);
            Console.WriteLine("EX4 - Soma de A + B:" + (a + b));

            string texto = "EX5 O meu nome é: " + nome + "\nEu tenho " + c + "livros";
            Console.WriteLine(texto);

            bool isValid = true;
            bool isNotvalid = false;

            Console.WriteLine("EX6 isValid:" + isValid + "isNotValid:" + isNotvalid);

            char letra = nome[3];
            Console.WriteLine("EX7 - Nome[3]" + letra);


            //Console.WriteLine("HelloWorld!");

            //Comentário uma linha 

            /*
             * Comentário Bloco
             * 
             */

            Console.ReadKey();
        }
    }
}
