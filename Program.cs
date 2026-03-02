namespace COMP003A.Assignment7;
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        /*The program is meant to store up to 5 daily expenses for user to 
        display in list format, and to calculate total and average.*/
       List<double> expenses = new List<double>();
       Console.WriteLine("Daily Expense Tracker");
       Console.WriteLine();
       for (int i = 0; i < 5; i++)
       {
           Console.WriteLine("Enter expense " + (i +1) + ": ");
           /*This try-catch prevents program from crashing if user enter
            invalid entry (non-numeric)*/
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
       /*Debug note: int was first used for expense values, which did not print cents.
        the list and calculations were changed to doubles allowing values to contain decimals*/
       bool isRunning = true;
       //Menu loop ensures program stays running until user enters exit value
       while (isRunning)
       {
           Console.WriteLine();
           Console.WriteLine("1. Display All Values");
           Console.WriteLine("2. Show Total");
           Console.WriteLine("3. Show Average");
           Console.WriteLine("4. Exit");
           Console.WriteLine("Enter Choice: ");
           string menuInput = Console.ReadLine();
           int menuChoice = 0;
           if (int.TryParse(menuInput, out menuChoice))
           {
               if (menuChoice == 1)
               {
                   Console.WriteLine();
                   Console.WriteLine("Enter Values: ");

                   for (int i = 0; i < expenses.Count; i++)
                   {
                       Console.WriteLine((i + 1) + ". $" + expenses[i].ToString("F2"));
                   }
               }
               else if (menuChoice == 2)
               {
                   double total = 0;
                   for (int i = 0; i < expenses.Count; i++)
                   {
                       total += expenses[i];
                   }
                   Console.WriteLine();
                   Console.WriteLine("Total: $" + total.ToString("F2"));
               }
               else if (menuChoice == 3)
               {
                   double total = 0;
                   for (int i = 0; i < expenses.Count; i++)
                   {
                       total += expenses[i];
                   }
                   double average = total / expenses.Count;
                   Console.WriteLine();
                   Console.WriteLine("Average: $" + average.ToString("F2"));
               }
               else if (menuChoice == 4)
               {
                   Console.WriteLine();
                   Console.WriteLine("Program Ended");
                   isRunning = false;
               }
               else
               {
                   Console.WriteLine();
                   Console.WriteLine("Invalid Input");
               }
           }
           else
           {
               {
                   Console.WriteLine();
                   Console.WriteLine("Invalid Input. Please input a valid number from 1 to 4.");
               }
           }
       }
    }
}