using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern.VisitorPattern
{
    internal interface ItemElement
    {
        int Accept(ShopingCartVisitor visitor);
    }
}
