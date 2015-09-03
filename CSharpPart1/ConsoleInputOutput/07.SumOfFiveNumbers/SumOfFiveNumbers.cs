using System;

class SumOfFiveNumbers
{
    static void Main(string[] args)
    {
        double[] numbers = new double[5];
        double sum = 0;
        Console.WriteLine("Enter 5 numbers to Sum:");
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());//vavejdam chislo v masiva 
            sum += numbers[i];//dobavqm chisloto kam sumata
        }
        Console.WriteLine("Sum of the numbers is :{0}",sum);
        
    }
}
