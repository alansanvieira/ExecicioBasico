using System;
using System.Globalization;


// EXERCICIO SPLIT

namespace ExercicioBasico
{
    class ExercicioBasico
    {

        static void Main(string[] args)
        {

            string? frase = Console.ReadLine();
            string? x = Console.ReadLine();
            string? y = Console.ReadLine();


            string[] cores = Console.ReadLine().Split(' ');
            string a = cores[0];
            string b = cores[1];
            string c = cores[2];



            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);


        }
    }
}





