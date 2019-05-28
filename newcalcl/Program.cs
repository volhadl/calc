using System;

namespace newcalcl
{
    class activities
    {
        static void MathOp(int x, int y, Operation op)
        {
            int result = 0;

            switch (op)
            {
                case Operation.Unknown:
                    Console.WriteLine("операция неопределена");
                    break;
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }

            Console.WriteLine("Результат операции равен {0}", result);
        }

    }
    class Program
    {

        enum Operation
        {
            Unknown,
            Add,
            Subtract,
            Multiply,
            Divide
        }

        static bool ValidateInputForInt(string input)   //проверка на то что к нам приходит int
        {
            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine("Input must be a whole num");
                return false; //т.к мы использовали bool мы должны указать true / false
            }
            else if (result < 0)
            {
                Console.WriteLine("Input must be a positive or 0");
                return false;
            }

            else return true;
        }

        static void MathOp(int x, int y, Operation op)
        {
            int result = 0;

            switch (op)
            {
                case Operation.Unknown:
                    Console.WriteLine("операция неопределена");
                    break;
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }

            Console.WriteLine("Результат операции равен {0}", result);
        }


        static void Main(string[] args)
        {
            int x;
            int y;


            bool toContinue = true;
            while (toContinue)
            {
                Console.WriteLine("Input 1th num: ");
                var input = Console.ReadLine();
                if (ValidateInputForInt(input))
                {
                    x = int.Parse(input);
                }
                else continue;
                Console.WriteLine($"1th num = {x}");

            link1:
                Console.WriteLine("Input 2nd num: ");
                input = Console.ReadLine();
                if (ValidateInputForInt(input))
                {
                    y = int.Parse(input);
                }
                else continue;
                Console.WriteLine($"2nd num = {y}");

                Console.WriteLine("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение 4.Деление");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        MathOp(x, y, Operation.Add);
                        break;
                    case "2":
                        MathOp(x, y, Operation.Subtract);
                        break;
                    case "3":
                        MathOp(x, y, Operation.Multiply);
                        break;
                    case "4":

                        if (y == 0)
                        {
                            Console.WriteLine("2nd value can't be null");
                            goto link1;
                        }

                        else
                        {
                            MathOp(x, y, Operation.Divide);
                            break;
                        }
                        
                    default:
                        MathOp(x, y, Operation.Unknown);
                        break;
                        
                }
                Console.WriteLine("want to continue? press 'y'");
                if (Console.ReadLine() != "y")
                {
                    toContinue = false;
                };


            }
        }
    }
}

