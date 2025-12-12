using System;
using System.Collections.Generic;
using System.Text;

namespace CoisaProGit
{
    internal class Calc
    {
            public static double Soma(double n1, double n2) 
            {
            double n3 = n1 + n2;
            Console.WriteLine($"{n1} + {n2} = {n3}");
            return n1 + n2;
            
            } //soma

            public static double Subtrai(double n1, double n2)
            {

                double n3 = n1 - n2;
                Console.WriteLine($"{n1} - {n2} = {n3}");
            return n1-n2;
        } //subtrai
        public static double Multiplica(double n1, double n2)
            {
                double n3 = n1 * n2;
                Console.WriteLine($"{n1} * {n2} = {n3}");
            return n1* n2;
        } //multiplica

        public static double Divide(double n1, double n2)
            {
                double n3 = n1 / n2;
                Console.WriteLine($"{n1} / {n2} = {n3}");
            return n1/n2;
        } //divide

        public static string Fzer()
        {
            Console.WriteLine("Que cálculo você deseja fazer? (+, -, *, /)");
            string ss = Console.ReadLine()!;
            return ss;
        }

    }
    }

