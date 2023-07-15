using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern.Abstract
{
    public interface IPrint
    {
        void Print();
        void Accept(IVisitor visitor);
    }
}
