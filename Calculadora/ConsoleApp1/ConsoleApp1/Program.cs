using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora");
            Console.Write("Favor digitar o primeiro numero:");
            String num1 = Console.ReadLine();
            int usanum1 = int.Parse(num1);

            Console.Write("Favor digitar numero 2: ");
            String num2 = Console.ReadLine();
            int usanum2 = int.Parse(num2);

            int Somar(int numero1, int numero2)
            {
                return numero1 + numero2;
            }

            int Subtracao(int numero1, int numero2)
            {
                return numero1 - numero2;
            }

            int Multiplicacao(int numero1, int numero2)
            {
                return numero1 * numero2;
            }

            int Divisao(int numero1, int numero2)
            {
                return numero1 / numero2;
            }

            int Porcentagem(int numero1, int numero2)
            {
                return (numero1 * numero2)/ 100;
            }

            double Potencia(int numero1, int numero2)
            {
                return Math.Pow(numero1, numero2);
            }


            Console.WriteLine("Favor escolher a operação: \n" +
                              "Letra A: Somar\n" +
                              "Letra B: Subtração\n" +
                              "Letra C: Multiplicação\n" +
                              "Letra D: Divisão\n " +
                              "Letra E: Porcentagem\n " +
                              "Letra F: Potência\n ");

            int resultado = 0;

            switch (Console.ReadLine())
            {
                case "A":
                    resultado = Somar(usanum1, usanum2);
                    break;
                case "B":
                    resultado = Subtracao(usanum1, usanum2);
                    break;
                case "C":
                    resultado = Multiplicacao(usanum1, usanum2);
                    break;
                case "D":
                    resultado = Divisao(usanum1, usanum2);
                    break;
                case "E":
                    resultado = Porcentagem(usanum1, usanum2);
                    break;
                case "F":
                    resultado = Convert.ToInt32(Potencia(usanum1, usanum2));
                    break;
            }

            Console.WriteLine($"O Resultado da operação é:{resultado}");
        }
    }
}