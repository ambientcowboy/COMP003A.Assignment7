namespace COMP003A.Assignment7;
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
       List<double> expenses = new List<double>();
       Console.WriteLine("Daily Expense Tracker");
       Console.WriteLine();
       for (int i = 0; i < 5; i++)
       {
           Console.WriteLine("Enter expense " + (i +1) + ": ");
           try
           {
               string expenseInput = Console.ReadLine();
               double expenseValue = Convert.ToDouble(expenseInput);
               expenses.Add(expenseValue);
           }
           catch (FormatException)
           {
               Console.WriteLine("Invalid Input 0.00 was stored");
               expenses.Add(0);
           }
       }
    }
}