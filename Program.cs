using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment-1");
            Console.ReadLine();

            Console.WriteLine("Question 1 Solution");
            A1Q1 a1Q1 = new A1Q1();
            a1Q1.ArraySum();
            Console.ReadLine();

            Console.WriteLine("Question 2 Solution");
            A1Q2 a1Q2 = new A1Q2();
            a1Q2.Average();
            Console.ReadLine();

            Console.WriteLine("Question 3 Solution");
            A1Q3 a1Q3 = new A1Q3();
            a1Q3.FindGreater();
            Console.ReadLine();

            Console.WriteLine("Question 4 Solution");
            A1Q4 a1Q4 = new A1Q4();
            a1Q4.Count();
            Console.ReadLine();

            Console.WriteLine("Question 5 Solution");
            A1Q5 a1Q5 = new A1Q5();
            a1Q5.ReverseArray();
            Console.ReadLine();
        }
    }

    class A1Q1
    {
        public void ArraySum()
        {
            int[] transactions = { 200, -150, 340, 500, -100 };
            int sum = 0;
            for (int i = 0; i < transactions.Length; i++)
            {
                sum += transactions[i];
            }
            Console.WriteLine($"Sum of all nimbers {sum}");
        }
    }


    class A1Q2
    {
        public void Average()
        {
            float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float sum = 0.0f;

            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            float average = sum / scores.Length;
            Console.WriteLine($"Average score is {average}");
        }
    }


    class A1Q3
    {
        public void FindGreater()
        {
            int[] Array = { 1500, 2300, 999, 3200, 1750 };
            int max = Array[0];

            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i] > max)
                {
                    max = Array[i];
                }
            }
            Console.WriteLine($"Max Element {max}");
        }
    }
    class A1Q4
    {
        public void Count()
        {
            int[] participantCodes = { 102, 215, 324, 453, 536 };
            int male = 0;
            int female = 0;

            foreach (int i in participantCodes)
            {
                if (i % 2 == 0)
                {
                    male++;
                }
                else
                {
                    female++;
                }
            }
            Console.WriteLine($"Number of male {male}");
            Console.WriteLine($"Number of female {female}");
        }
    }
    class A1Q5
    {
        public void ReverseArray()
        {
            int[] searchHistory = { 101, 202, 303, 404, 505 };
            Array.Reverse(searchHistory);

            Console.WriteLine("Reverse History");

            foreach (int item in searchHistory)
            {
                Console.Write($" {item}");
            }
        }
    }
    class A1Q6
    {
        int[] measurements = { 2, 4, 6, 8 };
        int factor = 3;
    }
}