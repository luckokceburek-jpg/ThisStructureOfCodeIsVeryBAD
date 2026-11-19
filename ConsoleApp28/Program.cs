namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Calculator calc = new Calculator();
            Console.WriteLine("Do yo wish to log in file(1) or in console(2) - ");
            Logger logs = new Logger();
            int temp = int.Parse(Console.ReadLine());
            bool FileLogong = temp == 1 ? true : false;
            while (check)
            {
                Console.WriteLine("Enter a(1), Enter b(2), Addition(3), Subtraction(4), Multiply(5), Division(6), Percentege(7), Degree(8), End(9): ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        calc.SetA();
                        logs.LogA((calc.a).ToString());
                        break;
                    case 2:
                        calc.SetB();
                        logs.LogB((calc.b).ToString());
                        break;
                    case 3:
                        Console.WriteLine(calc.Addition());
                        logs.LogRes(calc.Addition() + " in operation of addition");
                        break;
                    case 4:
                        Console.WriteLine(calc.Subtraction());
                        logs.LogRes(calc.Subtraction() + " in operation of subtraction");
                        break;
                    case 5:
                        Console.WriteLine(calc.Multiply());
                        logs.LogRes(calc.Multiply() + " in operation of multiply");
                        break;
                    case 6:
                        Console.WriteLine(calc.Division());
                        logs.LogRes(calc.Division() + " in operation of division");
                        break;
                    case 7:
                        Console.WriteLine(calc.Percentege());
                        logs.LogRes(calc.Percentege() + " in operation of percentege");
                        break;
                    case 8:
                        Console.WriteLine(calc.Degree());
                        logs.LogRes(calc.Degree() + " in operation of Degree");
                        break;
                    case 9:
                        if (FileLogong)
                        {
                            logs.FileWrite();
                        }
                        else logs.ConWrite();
                        check = false;
                        break;
                }
            }
        }
    }
}
