﻿using System;
namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Thaísa";
            // não pode fazer isto -- nome = 123;
            Console.WriteLine(nome);

            //int idade; 
            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine("O total é " + (a + b));

        }
    }
}
