using System;

namespace Ex_Variables_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex variables NET
            // Fase 1
            // Nombre y fecha
            string nom = "Francisco", cognom1 = "Gil", cognom2 = "Mayo";  
            int dia = 19, mes = 6, any = 2020;
            Console.WriteLine(cognom1 + " " + cognom2 + ", " + nom + ".");
            Console.WriteLine(dia + "/" + mes + "/" + any + ".");

            Console.WriteLine();

            // Fase 2
            // Cuantos años bisiestos hay entre 1948 y 1974
            const int ANNO = 1948;
            int periodo = 4;
            int cantBisiesto = (1974 - ANNO) / periodo;
            Console.WriteLine("Entre " + ANNO + " y 1974 hay " + cantBisiesto + " años bisiestos.");

            Console.WriteLine();

            // Fase 3
            // Indicar si un año es bisiesto o no entre 1948 y 1974
            bool biAnno = false;
            string fraseBisiesto = "", fraseNoBisiesto = "";
            for (int i = (ANNO + 1); i <= 1974; i++)
            {
                int resto = (i - ANNO) % periodo;
                biAnno = resto == 0;
                if (biAnno)
                {
                    fraseBisiesto = "El año " + i + " es bisiesto.";
                    Console.WriteLine(fraseBisiesto);
                }
                else
                {
                    fraseNoBisiesto = "El año " + i + " no es bisiesto.";
                    Console.WriteLine(fraseNoBisiesto);
                }
            }

            string nomTotal = nom + " " + cognom1 + " " + cognom2;
            string dataTotal = "22/09/1974";
            Console.WriteLine();
            Console.WriteLine("Mi nombre es {0}.", nomTotal);
            Console.WriteLine("Nací el día {0}.", dataTotal);
            if (biAnno)
                Console.WriteLine(fraseBisiesto);
            else
                Console.WriteLine(fraseNoBisiesto);

        }
    }
}
