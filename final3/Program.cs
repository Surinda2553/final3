using System;

namespace final3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] data = { 2, 4, 4, 4, 5, 5, 7, 9 };
            PrintOutput(data);
        }

        static void PrintOutput(double[] score)
        {
            Console.WriteLine("________________________________________");
            Console.WriteLine("| Max number \t\t:{0} \t|", FindMax(score));
            Console.WriteLine("| Min number \t\t:{0} \t|", FindMin(score));
            double avg = ComputeAVG(score);

            Console.WriteLine("| Avearge    \t\t:{0:f2} \t|", avg);

            Console.WriteLine("________________________________________");

        }

        static double FindMax(double[] numArr)
        {
            double max = numArr[0];
            foreach (double num in numArr)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        static double FindMin(double[] numArr)
        {
            double min = numArr[0];
            foreach (double num in numArr)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        static double ComputeAVG(double[] numArr)
        {
            double sum = 0, avg;
            int len = numArr.Length;
            foreach (double num in numArr)
            {
                sum += num;
            }
            avg = sum / len;
            return avg;
        }
    }
}
