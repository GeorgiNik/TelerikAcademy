using System;
class BankAccData
{
    static void Main()
    {
        string firstName = "Trendafil";
        string middleName = "Arsov";
        string lastName = "Petrov";
        decimal balance = 1313.89M;
        string bankName = "Digital Money Bank";
        string iban = "BGU31432FJDA234234";
        string bic = "uNICREDIT";
        ulong creditCard1 = 4885514993898;
        ulong creditCard2 = 4539282220808;
        ulong creditCard3 = 4485502136624;

        Console.WriteLine("{0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Total ammount of:\n{0} leva in {1}", balance, bankName);
        Console.WriteLine("Personal Account Information\nIBAN:{0}\nBIC:{1}", iban, bic);
        Console.WriteLine("Credit Card(s) Number:\n 1- {0}\n 2- {1}\n 3- {2}", creditCard1, creditCard2, creditCard3);
    }
}

