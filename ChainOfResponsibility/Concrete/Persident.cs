using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Concrete
{
    public class Persident : ExpenseHandlerBase
    {
        public override void HandlerExpense(Expense expense)
        {
            if (expense.Amount > 1000)
            {
                Console.WriteLine("Persident handler the expense");
            }
        }
    }
}
