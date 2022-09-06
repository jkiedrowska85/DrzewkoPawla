// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] agrges)
    {
        Console.WriteLine("Jak masz na imię?");
        string name = Console.ReadLine();
        Console.WriteLine("Wybierz znak: !@#$%^&*)");
        char e = Convert.ToChar(Console.ReadLine());

        if (e == '!' || e == '@' || e == '#' || e == '$' || e == '%' || e == '^' || e == '&' || e == '*' || e == ')')
        {
            Console.WriteLine("Teraz podaj podstawę trójkąta (liczba całkowita, nieparzysta):");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p % 2 != 0)
            {
                string str = "";

                for (int i = 0; i <= p; i++)
                {
                    for (int j = 1; j <= p - i; j++)
                    {
                        str += " ";
                    }
                    for (int k = 0; k < 2 * i - 1; k++)
                    {
                        str += e;
                    }
                    str += "\n";
                    Console.WriteLine(name + " - oto Twoje drzewko");
                    Console.WriteLine(str);
                }
            }

            else
            {
                Console.WriteLine(name + " oszukujesz, zamykam się i nie gadam z Tobą!");
            }
        }
        else
        {
            Console.WriteLine(name + " oszukujesz, zamykam się i nie gadam z Tobą!");
        }
    }
}
