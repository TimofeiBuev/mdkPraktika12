namespace mdkPraktika12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выбирете функцию");
                Console.WriteLine("- ввести А \n- ввести В \n- выполнить операцию “+” \n- выполнить операцию “-” \n- выполнить операцию “*” \n- выполнить операцию “/” ");

                int chose = Convert.ToInt32(Console.ReadLine());

                double a = 0;
                double b = 0;

                switch (chose)
                {
                    case 6:
                        Console.WriteLine(a / b);
                        break;
                    default:
                        Console.WriteLine("Введены неверные данные");
                        break;
                }
            }
        }
    }
}
