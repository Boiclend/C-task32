using System;

class Strings
{
    private int amount;
    private int y;
    private int Number;
    private int Concat;

    private string str1;
    private string str2;
    private string str3;
    private string strSearch;
    private string strConcat;

    public Strings()
    {
        amount = 3;
    }

    private int searchStr()
    {
        if (strSearch == str1) return 1;
        else if (strSearch == str2) return 2;
        else if (strSearch == str3) return 3;
        else return -1;
    }

    public void setString()
    {
        str1 = "";
        str2 = "";
        str3 = "";
        strSearch = "";
        strConcat = "";

        Console.WriteLine("Введите три строки (латиницей).");
        for (int i = 0; i < amount; i++)
        {
            Console.Write($"Введите строку №{i + 1} (не более 30-ти символов): ");
            if (i == 0) 
            {
                str1 = Console.ReadLine();
                if(str1.Length > 30)
                {
                    Console.WriteLine("Длина больше 30!!!");
                    Environment.Exit(0);
                }
            } 
            if (i == 1) 
            {
                str2 = Console.ReadLine();
                if(str2.Length > 30)
                {
                    Console.WriteLine("Длина больше 30!!!");
                    Environment.Exit(0);
                }
            }
            if (i == 2) 
            {
                str3 = Console.ReadLine();
                if(str3.Length > 30)
                {
                    Console.WriteLine("Длина больше 30!!!");
                    Environment.Exit(0);
                }
            }
        }

        Console.Write("Введите строку, номер которой хотите найти (не более 30-ти символов): ");
        strSearch = Console.ReadLine();
        y = searchStr();
        if (y == 1) Console.WriteLine("\nНомер введенной Вами строки в наборе строк = 1");
        else if (y == 2) Console.WriteLine("\nНомер введенной Вами строки в наборе строк = 2");
        else if (y == 3) Console.WriteLine("\nНомер введенной Вами строки в наборе строк = 3");
        else Console.WriteLine("\nСтрока не найдена!!!\n\n");
    }

    public void getString()
    {
        Console.WriteLine("\n\n");
        Console.WriteLine("Если вы хотите отобразить все строки - введите 0.");
        Console.Write("Если вы хотите вывести на экран конкретную строку, введите ее номер (1, 2 или 3): ");
        Number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n\n");
        if (Number == 1) Console.WriteLine($"Строка 1:   {str1}\n\n");
        else if (Number == 2) Console.WriteLine($"Строка 2:   {str2}\n\n");
        else if (Number == 3) Console.WriteLine($"Строка 3:   {str3}\n\n");
        else
        {
            Console.WriteLine($"Строка 1:   {str1}\n\n");
            Console.WriteLine($"Строка 2:   {str2}\n\n");
            Console.WriteLine($"Строка 3:   {str3}\n\n");
        }
    }

    public void concat()
    {
        Console.Write("\nЕсли Вы хотите объединить все строки, нажмите - 1. Если нет, нажмите - 0: ");
        Concat = Convert.ToInt32(Console.ReadLine());
        if (Concat == 0) Console.WriteLine("Строки не будут объединены!");
        else
        {
            strConcat = str1 + str2 + str3;
            Console.WriteLine($"Объединенные строки:   {strConcat}\n\n");
        }
    }

    public void del()
    {
        strConcat = null;
        strSearch = null;
        str3 = null;
        str2 = null;
        str1 = null;
    }
}

class Program
{
    static void Main()
    {
        Strings strings = new Strings();
        strings.setString();
        strings.getString();
        strings.concat();
        strings.del();
    }
}
