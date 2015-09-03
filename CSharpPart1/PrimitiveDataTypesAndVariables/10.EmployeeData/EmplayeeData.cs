using System;

class EmplayeeData
{
    static void Main()
    {
        
        string firstName = "Georgi";
        string lastName = "Nikolov";
        int age = 20;
        string gender ="male";
        long personalIDnumber = 12368767841;
        long uniqueEmployeeNumber = 27569999;

        Console.WriteLine("Employee's Data:\n");
        Console.WriteLine("First name is: {0}", firstName);
        Console.WriteLine("Last name is: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID number: {0}", personalIDnumber);
        Console.WriteLine("Unique employee number: {0}", uniqueEmployeeNumber);
    }
}

