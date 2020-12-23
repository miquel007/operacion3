using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escrive un numero");
            string Ntrap = Console.ReadLine();
            int num1 = Convert.ToInt32(Ntrap);

            Console.WriteLine("Escrive un numero");
            string Ntrap2 = Console.ReadLine();
            int num2 = Convert.ToInt32(Ntrap2);

            Console.WriteLine("Escrive un numero no entero");
            string Mtrap = Console.ReadLine();
            double num3 = Convert.ToDouble(Mtrap);

            Console.WriteLine("Escrive un numero no entero");
            string Mtrap2 = Console.ReadLine();
            double num4 = Convert.ToDouble(Mtrap2);

            double op1 = num1 + num2;
            double op2 = num1 - num2;
            double op3 = num1 * num2;
            double op4 = num1 / num2;
            double op5 = num1 % num2;
            
            double op6 = num3 + num4;
            double op7 = num3 - num4;
            double op8 = num3 * num4;
            double op9 = num3 / num4;
            double op10 = num3 % num4;

            double op11 = num1 + num3;
            double op12 = num2 / num4;
            double op13 = num2 % num4;

            
            double op15 = num1 + num2 + num3 + num4;
            double op16 = num1 * num2 * num3 * num4;

            double op17 = num1 * 2;
            double op18 = num2 * 2;
            double op19 = num3 * 2;
            double op20 = num4 * 2;

            Console.WriteLine("Variable X= " + num1);
            Console.WriteLine("Variable Y= " + num2);
            Console.WriteLine("Variable N = " + num3);
            Console.WriteLine("Variable M = " + num3);

            Console.WriteLine("{0} + {1} = {2} ", num1, num2, op1);
            Console.WriteLine("{0} - {1} = {2} ", num1, num2, op2);
            Console.WriteLine("{0} * {1} = {2} ", num1, num2, op3);
            Console.WriteLine("{0} / {1} = {2} ", num1, num2, op4);
            Console.WriteLine("{0} % {1} = {2} ", num1, num2, op5);


            Console.WriteLine("{0} + {1} = {2} ", num3, num4, op6);
            Console.WriteLine("{0} - {1} = {2} ", num3, num4, op7);
            Console.WriteLine("{0} * {1} = {2} ", num3, num4, op8);
            Console.WriteLine("{0} / {1} = {2} ", num3, num4, op9);
            Console.WriteLine("{0} % {1} = {2} ", num3, num4, op10);

            Console.WriteLine("{0} + {1} = {2} ", num1, num3, op11);
            Console.WriteLine("{0} / {1} = {2} ", num2, num3, op12);
            Console.WriteLine("{0} % {1} = {2} ", num2, num3, op13);

            Console.WriteLine("El doble de {0} = {1} / El doble de {2} = {3} / El doble de {4} = {5}/ El doble de {6} = {7} ", num1, op17, num2, op18, num3, op19, num4, op20);
            Console.WriteLine("{0} + {1} + {2} + {3} = {4} ", num1,num2,num3, num4, op15);
            Console.WriteLine("{0} * {1} * {2} * {3} = {4} ", num1, num2, num3, num4, op16);

        }
    }
}
