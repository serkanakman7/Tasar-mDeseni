using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Concrete
{
    public class Verpersident : ExpenseHandlerBase
    {
        public override void HandlerExpense(Expense expense)
        {
            if(expense.Amount>100 && expense.Amount <= 1000)
            {
                Console.WriteLine("Verpersident handled the expense");
            }else if (Successor != null)
            {
                Successor.HandlerExpense(expense);
            }
        }
    }
}
