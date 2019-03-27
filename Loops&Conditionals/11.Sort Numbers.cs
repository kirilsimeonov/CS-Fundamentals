using System;

namespace Tech_Module_1_More_Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            double max = double.MinValue;
            double min = double.MaxValue;
            double mid = 0;

            if (n1 > max) { max = n1; };
            if (n2>max)
            {
                max = n2;
            }
            if (n3>max)
            {
                max = n3;
            }

            if (n1<min)
            {
                min = n1;
            }
            if (n2<min)
            {
                min = n2;
            }
            if (n3 < min)
            {
                min = n3;
            }
            if (n1>min && n1<max)
            {
                mid = n1;
            }
            if (n2 > min && n2 < max)
            {
                mid = n2;
            }
            if (n3 > min && n3 < max)
            {
                mid = n3;
            }
            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);
        }
    }
}
