using System;

namespace IdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime aniversario = new DateTime(2005, 03, 28);
            DateTime anv = new DateTime(2023, 03, 28);

            string datalonga= aniversario.ToLongDateString();
            string datalonga2= anv.ToLongDateString();

            Console.WriteLine($"Eu nasci em: {datalonga}");
            Console.WriteLine($"Farei 18 anos em: {datalonga2}");
        }
    }
}
