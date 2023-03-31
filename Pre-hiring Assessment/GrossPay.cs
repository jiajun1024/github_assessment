using System;

class GrossPay
{
    static void Main(string[] args)
    {
        double grossPay, basicPay, overtimeHours, overtimeRate;
        overtimeRate = 1.5;

        Console.WriteLine("What is your basic pay: RM ");
        basicPay = Convert.ToDouble(ReadLine());
        Console.WriteLine("Total overtime hours in this month: ");
        overtimeHours = Convert.ToDouble(ReadLine());

        if(overtimeHours < 50)
        {
            grossPay = basicPay + (overtimeHours * overtimeRate);
        }
        else
        {
            grossPay = basicPay + (50 * overtimeRate);
        }

        WriteLine("Your Gross Pay is RM " + grossPay.ToString());
        Read();
    }
}