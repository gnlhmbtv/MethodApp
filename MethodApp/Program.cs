using System;

namespace MethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.  Bir int parametr qəbul edən və o ədədə
            //qədər bütün cüt ədədlərin cəmini ekrana yazdıran, həm return type-ı olan bir method həm də void bir method yazırsız


            evenNum(7, 0);

            Console.WriteLine(sumOfEven(7,0));

        }

        public static void evenNum(int num,int sum)
        {
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    
       public static int sumOfEven(int num,int sum)
        {
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
