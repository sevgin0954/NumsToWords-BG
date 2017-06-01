using System;
class NumToWordsBG
{
    static string[] unitsAndTensBG = { "едно", "две", "три", "четири", "пет", "шест", "седем", "осем", "девет",
        "десет", "единадесет","дванадесет", "тринадесет", "четиринадесет", "петнадесет", "шестнадесет",
        "седемнадесет", "осемнадесет","деветнадесет", "двадесет" };
    static string[] hundredsBG = { "сто", "двеста", "триста", "четиристотин", "петстотин", "шестстотин", "седемстотин",
            "осемстотин", "деветстотин" };
    static void Main()
    {
        while (true)
        {
            Console.Write("Въведи число (0 - 100):");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(NumToWords(n));
        }
    }
    static string NumToWords(int n)
    {
        if (n == 0)
        {
            return "нула";
        }
        if (n <= 20)
        {
            return unitsAndTensBG[n - 1];
        }
        if (n < 100)
        {
            int ones = n / 10;
            int tens = n % 10;
            string word = unitsAndTensBG[ones - 1] + "десет ";
            if (n % 10 > 0)
            {
                word += "и " + unitsAndTensBG[tens - 1];
            }
            return word;
        }
        if (n < 1000)
        {
            string word = hundredsBG[n / 100 - 1];
            if (n % 100 > 0)
            {
                string tensAndOnes = NumToWords(n % 100);
                if (n % 100 < 10 || n % 10 == 0)
                {
                    word += " и ";
                }
                else
                {
                    word += " ";
                }
                word += tensAndOnes;
            }
            return word;
        }
        return "to big or to small number (0 - 999)";
    }
}