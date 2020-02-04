using System;

namespace SubnetCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            GetEachOctan();


        }


        static void GetEachOctan()
        {
            Console.Write("Enter your IP address: ");
            string getIP = Console.ReadLine();

            string[] IpWithoutDots = getIP.Split(".");

            Console.WriteLine(IpWithoutDots[0]+" "+IpWithoutDots[1]+" "+IpWithoutDots[2]+" "+IpWithoutDots[3]);


            int n, i;
            int[] a = new int[10];

            Console.Write("Enter the number to convert: ");
            n = int.Parse(IpWithoutDots[0]);
            for(i=0;n>0;i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number is = ");
            for(i=i-1;i>=0;i--)
            {
                Console.Write(a[i]);
            }

            Console.ReadKey();
  
        }

        static void GetBinary()
        {

        }
    }
}
