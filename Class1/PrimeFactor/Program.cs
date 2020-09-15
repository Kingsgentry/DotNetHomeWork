using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace dotNet课堂练习1
{
    class ProgramEntry
    {
        public static void Main(string[] args)
        {

            ConsoleCaculator consoleCaculator = new ConsoleCaculator();
            //consoleCaculator.Begin();
            PrimeFactor primeFactor = new PrimeFactor();
            primeFactor.GetPrimeFactor();

        }
    }

    class ConsoleCaculator
    {

        private int Caculate(int number1, int number2, char operatorChar)
        {
            switch (operatorChar)
            {
                case '+':
                        return number1 + number2;
                case '-':
                        return number1 + number2;
                case '*':
                        return number1 + number2;
                case '/':
                        return number1 + number2;
                case '%':
                        return number1 + number2;
                default:
                    {
                        Console.WriteLine("输入操作符错误");
                        return 0;
                    }
            }
        }
        public void Begin()
        {

                int number1 = Console.Read() - 48;
                Char operatorChar = Convert.ToChar(Console.Read());
                int number2 = Console.Read() - 48;

                Console.WriteLine("输出结果为" + Caculate(number1, number2, operatorChar));
               
            
        }


    }

    class PrimeFactor
    {
        private int number;

        public void GetPrimeFactor()
        {
            number = Int32.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0 && isPrime(i))
                {
                    number /= i;
                    Console.Write(i + " ");
                }
                    
            }
        }

        private bool isPrime(int num)
        {
           // Console.WriteLine("Check " + num + " is Prime");
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            //Console.WriteLine(num + "is Prime");
            return true;
        }
    }
}
