using System;
using System.Collections.Generic;

namespace Eratosthenes
{
    class ProgramEntry
    {
        static void Main(string[] args)
        {
            Eratosthenes eratosthenes = new Eratosthenes();
            eratosthenes.Sieve(2, 100);
        }
    }

    class Eratosthenes
    {
        public void Sieve(int min, int max)
        {
            List<int> nums = new List<int>();

            for (int i = min; i <= max; i++)
                nums.Add(i);

            
            for (int i = min; i < max; i++)
            {
                if (isPrime(i))
                {
                    for (int j = 0; j < nums.Count; j++)
                    {
                        if (nums[j] > i && nums[j] % i == 0)
                            nums[j] = 0;
                    }
                }
            }
            
            foreach (int temp in nums)
            {
                if (temp != 0)
                    Console.Write(temp + " ");
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
