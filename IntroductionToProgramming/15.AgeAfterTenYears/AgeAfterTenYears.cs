//  Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;
using System.Globalization;
using System.Threading;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Type your birthday in format (dd.MM.yyyy): ");
        string userInput = Console.ReadLine(),
               format = "dd.MM.yyyy";
        DateTime userBday = default(DateTime);

        if (DateTime.TryParseExact(userInput, format, null, DateTimeStyles.None, out userBday))
        {
            DateTime crntDT = DateTime.Now;
            int age = crntDT.Year - userBday.Year;

            Console.WriteLine("Your age: {0}", crntDT.Month >= userBday.Month && crntDT.Day >= userBday.Day ? age : age -= 1);
            Console.WriteLine("Your age in 10 years: {0}", age + 10);
        }
        else
        {
            Console.WriteLine("Error: {0} is not valid DateTime format!", userInput);
        }   
    }
}
