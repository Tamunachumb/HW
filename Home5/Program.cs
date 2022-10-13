using System;

namespace Home5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
           
            Console.WriteLine("Your number is");
            var z = Convert.ToDecimal(Console.ReadLine());
            var output = (z % 5) > 0 ? "False" : "True";
            Console.WriteLine(output);


            //ex2
            //0-ze gayofa mirchevnia leqciaze vqnat, ragac chamexlarta me dzaan
            Console.WriteLine("number 1 is");
            var a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("number 2 is");
            var b = Convert.ToDecimal(Console.ReadLine());
            var out1 = a + b;
            var out2 = a > b ? a - b : b - a;
            var out3 = a * b;

            var out4 = a > b ? a / b : b / a;
            Console.WriteLine(a + " + "+ b + " = " + out1);
            Console.WriteLine(a + " - " + b + " = " + out2);
            Console.WriteLine(a + " * " + b + " = " + out3);
            Console.WriteLine(a + " / " + b + " = " + out4);

            //ex3
            Console.WriteLine("x=");
            var x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("y=");
            var y = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("x=" + y);
            Console.WriteLine("y=" + x);

            //ex4

            Console.WriteLine("Your other number is");
            var i = Convert.ToDecimal(Console.ReadLine());
            for (int j = 0; j < 10; j++)
            Console.WriteLine ((i*j));


            //ex5

            Console.WriteLine("Your last number is");
            var k = Convert.ToDecimal(Console.ReadLine());
            for (int p = 1; p < k; p++)
                if ((p % 2) == 0)
                    Console.WriteLine((p * p));

































        }
    }
}
