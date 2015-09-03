using System;

class SumOfNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number count:");
        int number = int.Parse(Console.ReadLine());
        double[] numbers = new double[number];
        double sum = 0;
        Console.WriteLine("Enter the numbers to Sum:");
        for (int i = 0; i < number; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());//vavejdam chislo v masiva 
            sum += numbers[i];//dobavqm chisloto kam sumata
        }
        Console.WriteLine("Sum of the numbers is :{0}", sum);
    }
}
