using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern.VisitorPattern
{
    interface ItemElement
    {
        public int Accept(ShopingCartVisitor visitor);
    }
}
