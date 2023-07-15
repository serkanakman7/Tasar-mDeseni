using ChainOfResponsibility.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Abstract
{
    public abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase Successor;

        public abstract void HandlerExpense(Expense expense); //Kötü görüntü
        public ExpenseHandlerBase SetSuccessor(ExpenseHandlerBase successor)
        {
            Successor = successor;
            return Successor;
        }
    }
}
