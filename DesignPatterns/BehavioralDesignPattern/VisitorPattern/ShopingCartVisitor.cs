using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern.VisitorPattern
{
    public interface ShopingCartVisitor
    {
        int Visit(Book book);
        int Visit(Fruit fruit);
    }
}
