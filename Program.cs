using System.Runtime.ExceptionServices;

namespace array_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int switcheroo = 0;
            int n4=0;
            int s = 0;
            Console.WriteLine("Enter lenght of first array ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n1];
            Console.WriteLine("Enter lenght of second array ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int[] numbers2 = new int[n2];
            if (n1 > n2)
            {
                n2 = switcheroo;
                n2= n1;
                n1 = switcheroo;
            }
            Console.WriteLine("insert the digits of the first array");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("insert the digits of the second array");

            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = Convert.ToInt32(Console.ReadLine());

            }
            //first exercise
            int t = 0;
            int n3 = numbers.Length + numbers2.Length;
            int[] union = new int[n3];
            for (int i = 0; i < numbers.Length; i++)
            {
                union[i] = numbers[i];
            }
            for (int i = n1; i < union.Length; i++)
            {

                union[i] = numbers2[t];
                t++;
            }
            for (int i = 0; i < union.Length; i++)
            {
                Console.WriteLine($"[ {union[i]} ]");
            }
            //second exercise
            for (int i = 0; i < numbers2.Length; i++)
            {
                if (s == n1)
                {
                    s = 0;
                }
                if (numbers[s] == numbers2[i])
                {
                    n4++;

                }
                s++;
            }

        }
    }
}
