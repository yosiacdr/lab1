using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        // 1 завдання
             class Program
        {
            delegate double average(double x, double y, double z);
            static void Main(string[] args)
            {
                Console.WriteLine("Enter your values");
                average operation = delegate (double x, double y, double z)
                {

                    return (x + y + z) / 3;
                };


                double res = operation(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine(res);
                Console.ReadKey();


            }

        }
        // 2 завдання
        class Program

        {
            delegate double sum(double x, double y);
            delegate double sub(double x, double y);
            delegate double mul(double x, double y);
            delegate double div(double x, double y);
            static void Main(string[] args)
            {
                double x1, y1;
                char oper;
            Start:
                sum sum = (x, y) => x + y;
                sum sub = (x, y) => x - y;
                sum mul = (x, y) => x * y;
                sum div = (x, y) => x / y;
                Console.WriteLine("Enter first value");
                while (!double.TryParse(Console.ReadLine(), out x1))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число ")
                        ;
                    goto Start;
                }
                Console.Clear();
                Console.WriteLine("Enter second value");
                while (!double.TryParse(Console.ReadLine(), out y1))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число ")
                        ;
                    goto Start;
                }
                Console.Clear();
                Console.WriteLine("Enter the sign for the solution ");
            Start2:
                Console.WriteLine("+ for the amount");
                Console.WriteLine("- for the difference");
                Console.WriteLine("* for multiplication");
                Console.WriteLine("/ for division");
                oper = Convert.ToChar(Console.ReadLine());
                if (oper == '+')
                {
                    Console.Clear();
                    Console.WriteLine(sum(x1, y1));
                }
                else if (oper == '-')
                {
                    Console.Clear();
                    Console.WriteLine(sub(x1, y1));
                }
                else if (oper == '*')
                {
                    Console.Clear();
                    Console.WriteLine(mul(x1, y1));
                }
                else if (oper == '/' && x1 != 0)
                {

                    Console.Clear();
                    Console.WriteLine(div(x1, y1));


                }
                else if (oper == '/' && x1 == 0)
                {

                    Console.Clear();
                    Console.WriteLine("Enter the corect value");


                }

                Console.WriteLine("Would you like to solve another example");
                Console.WriteLine("Press Y for continiue");
                string res = Console.ReadLine();
                switch (res)
                {
                    case "Y":
                        goto Start;
                    case "y":
                        goto Start;
                    default:
                        break;
                }

            }
        }
    }
    }
}
