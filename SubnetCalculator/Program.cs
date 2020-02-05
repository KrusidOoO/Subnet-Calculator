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

            n = int.Parse(IpWithoutDots[0]);
            for(i=0;n>0;i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.WriteLine("Binary of the given number is = ");
            for(i=i-1;i>=0;i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
            int b, c;
            int[] d = new int[10];

            b = int.Parse(IpWithoutDots[1]);
            for (c = 0; b > 0; c++)
            {
                d[c] = b % 2;
                b = b / 2;
            }
            Console.WriteLine("Binary of the given number is = ");
            for (c = c - 1; c >= 0; c--)
            {
                Console.Write(d[c]);
            }
            Console.WriteLine();
            int e, f;
            int[] g = new int[10];

            e = int.Parse(IpWithoutDots[2]);
            for (f = 0; e > 0; f++)
            {
                g[f] = e % 2;
                e = e / 2;
            }
            Console.WriteLine("Binary of the given number is = ");
            for (f = f - 1; f >= 0; f--)
            {
                Console.Write(g[f]);
            }
            Console.WriteLine();
            int h, j;
            int[] k = new int[10];

            h = int.Parse(IpWithoutDots[3]);
            for (j = 0; h > 0; j++)
            {
                k[j] = h % 2;
                h = h / 2;
            }
            Console.WriteLine("Binary of the given number is = ");
            for (j = j - 1; j >= 0; j--)
            {
                Console.Write(k[j]);
            }
            Console.WriteLine();

            Console.ReadKey();
  
        }

        static void GetBinary()
        {

        }
    }
}
