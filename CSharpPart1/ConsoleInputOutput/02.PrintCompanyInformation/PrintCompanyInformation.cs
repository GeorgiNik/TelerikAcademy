using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Company name:");
        string cName = Console.ReadLine();
        
        Console.WriteLine("Company address:");
        string cAddress = Console.ReadLine();
        
        Console.WriteLine("Phone number:");
        string cPhone = Console.ReadLine();
        
        Console.WriteLine("Fax number:");
        string cFax = Console.ReadLine();
       
        Console.WriteLine("Web site:");
        string cWebSite = Console.ReadLine();
        
        Console.WriteLine("Manager first name:");
        string mFName = Console.ReadLine();
        
        
        Console.WriteLine("Manager last name:");
        string mLName = Console.ReadLine();
        
        Console.WriteLine("Manager age:");
        string mAge = (Console.ReadLine());
        
        Console.WriteLine("Manager phone:");
        string mPhone = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("{0}\nAddress: {1}\nTel.: {2}\nFax: {3}\nWeb site: {4}",cName, cAddress, cPhone, cFax, cWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",mFName, mLName, mAge, mPhone);
    }
}