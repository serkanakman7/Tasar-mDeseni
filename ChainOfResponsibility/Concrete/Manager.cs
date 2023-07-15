using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Concrete
{
    public class Manager : ExpenseHandlerBase
    {
        public override void HandlerExpense(Expense expense)
        {
            if(expense.Amount <= 100)
            {
                Console.WriteLine("Manager Handled the expense");
            }else if (Successor != null)
            {
                Successor.HandlerExpense(expense);
            }
        }
    }
}
