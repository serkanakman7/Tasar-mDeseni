using System;
using System.Collections.Generic;
using System.Text;
using VisitorDesignPattern.Concrete;

namespace VisitorDesignPattern.Abstract
{
    public interface IVisitor
    {
        void Visit(HpPrinter hpPrinter);
        void Visit(LexmarkPrinter lexmarkPrinter);
    }
}
