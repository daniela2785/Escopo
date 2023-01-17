using System;

namespace Escopo {
    class Program
    {
        //declarando variavel no escopo global para que ela possa ser utilizada em qualquer função
        static string meuNomeCompleto = "Daniela Marques";

       //primeira função
       static void Main(string[] args)
        {
            //string meuNome = "Daniela";
            Console.WriteLine(meuNomeCompleto);
            Console.ReadLine();
        }

        //segunda função
         static void nome()
        {
            Console.WriteLine(meuNomeCompleto);
            Console.ReadLine();
        }
    }
}