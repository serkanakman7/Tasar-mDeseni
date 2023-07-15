using ChainOfResponsibility.Concrete;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Verpersident verpersident = new Verpersident();
            Persident persident = new Persident();

            manager.SetSuccessor(verpersident);
            verpersident.SetSuccessor(persident);

            Expense expense = new Expense { Detail = "Training", Amount = 10100 };
            manager.HandlerExpense(expense);

            Console.ReadLine();
        }
    }
}
