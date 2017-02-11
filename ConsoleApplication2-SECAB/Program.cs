using System;


namespace ConsoleApplication2_SECAB
{
    class Program
    {
        static void Main(string[] args)
        {
            //A1
            Console.WriteLine("Sweetian");
            Console.WriteLine("e0167326@u.nus.edu");

            //A2
            string input = Console.ReadLine();
            Console.WriteLine("Good Morning " + input);

            //A3
            string input2 = Console.ReadLine();

            //A4
            int num1 = Convert.ToInt32(input2);
            Console.WriteLine(num1 * num1);
            Console.WriteLine(Math.Pow(num1,2));

            //A5
            double num2 = Convert.ToInt32(input2);
            Console.WriteLine(Math.Pow(num2, 2));
            Console.WriteLine("{0:0.00}", num2);

            //B1
            Console.WriteLine(Math.Sqrt(num2));

            //B2
            double num3 = Math.Sqrt(num2);
            Console.WriteLine("{0:0.000}", Math.Round(num3,3));

            //B3
            double salary = num2;
            double house = num2 * 0.1;
            double trans = num2 * 0.03;
            double total = salary + house + trans;
            Console.WriteLine("Total : ${0:0.00}", total);

            //B4
            double fahrenheit = 1.8 * num2 + 32;
            Console.WriteLine("Fahrenheit: {0}", fahrenheit);

            //B5
            double y = 5 * Math.Pow(num2, 2) - 4 * num2 + 3;
            Console.WriteLine(y);

            //B6
            Console.Write("x1, x2, y1, y2: ");
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();
            string input5 = Console.ReadLine();
            string input6 = Console.ReadLine();
            double x1 = Convert.ToDouble(input3);
            double x2 = Convert.ToDouble(input4);
            double  y1 = Convert.ToDouble(input5);
            double y2 = Convert.ToDouble(input6);
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) - Math.Pow((y2 - y1),2));
            Console.WriteLine(distance);
            
            //B7
            double taxifare = 2.40 + 0.4 * y2;
            Console.WriteLine(taxifare);

            //B8
            Console.WriteLine("{0:0.00}", Math.Round(taxifare, 1));//3.70

            //B9
            Console.WriteLine(Math.Ceiling(taxifare * 10) / 10);//3.8

            //B10
            Console.Write("A : ");
            string input7 = Console.ReadLine();
            Console.Write("B : ");
            string input8 = Console.ReadLine();
            Console.Write("C : ");
            string input9 = Console.ReadLine();
            double A = Convert.ToDouble(input7);
            double B = Convert.ToDouble(input8);
            double C = Convert.ToDouble(input9);
            double s = (A + B + C) / 2;
            double area = Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            Console.WriteLine(area);

        }
    }
}
