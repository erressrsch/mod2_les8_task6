using System;
class Program
{
    static void Main()
    {
        int harmonicLength = 20;
        double sum = 0;

        for (int i = 1; i <= harmonicLength; i++)
        {
            sum += 1.0 / i;

        }
        Console.WriteLine(sum);


    }
}
