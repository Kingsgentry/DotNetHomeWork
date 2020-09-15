using System;

namespace ArrayCaculate
{
    class ProgromEntry
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 3, 12, 3123, 4 };
            ArrayCaculate arrayCaculator = new ArrayCaculate(nums);
            Console.WriteLine("Max: " + arrayCaculator.GetMax());
            Console.WriteLine("Min: " + arrayCaculator.GetMin());
            Console.WriteLine("Ave: " + arrayCaculator.GetAverage());
            Console.WriteLine("Sum: " + arrayCaculator.GetSum());
        }
    }

    class ArrayCaculate
    {
        private int[] nums;
        public ArrayCaculate(int[] arrayLength)
        {
            nums = arrayLength;
        }

        public int GetMax()
        {
            int max = Int32.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }

            return max;
        }

        public int GetMin()
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                    min = nums[i];
            }

            return min;
        }

        public int GetSum()
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
                result += nums[i];
            return result;
        }

        public float GetAverage()
        {
            return (float)GetSum() / (float)nums.Length;
        }
    }
}
