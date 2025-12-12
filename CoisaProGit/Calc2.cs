using System;
using System.Collections.Generic;
using System.Text;
using CoisaProGit;
using Gg;

namespace CoisaProGit2
{
    internal class Calc2
    {
        public static void Mm()
        {
            while (true)
            {
                var calc1 = Calc.Fzer();
                if (calc1 == null)
                {
                    Console.WriteLine("Erro ao iniciar a calculadora");
                }

                else if (calc1 == "+")
                {
                    while (true)
                    {
                        try
                        {
                            calc1 = "somar";
                            Console.WriteLine($"Escolha um número para {calc1}");
                            double num = double.Parse(Console.ReadLine()!);
                            Console.WriteLine("Escolha outro número");
                            double num2 = double.Parse(Console.ReadLine()!);

                            var calc = Calc.Soma(num, num2);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Isso é oq não pode");
                        }
                    }
                    break;
                }
                //---------------------------------------

                else if (calc1 == "-")
                {
                    while (true)
                    {
                        try
                        {
                            calc1 = "subtrair";
                            Console.WriteLine($"Escolha um número para {calc1}");
                            double num = double.Parse(Console.ReadLine()!);
                            Console.WriteLine("Escolha outro número");
                            double num2 = double.Parse(Console.ReadLine()!);

                            var calc = Calc.Subtrai(num, num2);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Isso é oq não pode");

                        }
                    }

                    break;
                }
                //---------------------------------------
                else if (calc1 == "*")
                {
                    while (true)
                    {
                        try
                        {
                            calc1 = "multiplicar";
                            Console.WriteLine($"Escolha um número para {calc1}");
                            double num = double.Parse(Console.ReadLine()!);
                            Console.WriteLine("Escolha outro número");
                            double num2 = double.Parse(Console.ReadLine()!);

                            var calc = Calc.Multiplica(num, num2);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Isso é oq não pode");

                        }
                    }
                    break;
                }
                //---------------------------------------
                else if (calc1 == "/")
                {
                    while (true)
                    {
                        try
                        {
                            calc1 = "dividir";
                            Console.WriteLine($"Escolha um número para {calc1}");
                            double num = double.Parse(Console.ReadLine()!);
                            Console.WriteLine("Escolha outro número");
                            double num2 = double.Parse(Console.ReadLine()!);

                            var calc = Calc.Divide(num, num2);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Isso é oq não pode");

                        }
                    }

                    break;
                }
                //---------------------------------------
                else
                {
                    Console.WriteLine("Dnv");
                    continue;
                }
                
            }
        }
    }
}