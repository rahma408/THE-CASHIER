using System;
using System.Collections.Generic;
using System.Text;

namespace THE_CASHIER
{
    class calculator
    {
        private List<Item> listitem;
        private double total = 0;

        public calculator()
        {
            this.listitem = new List<Item>();
        }

        public void additem(Item item)
        {
            this.listitem.Add(item);
            this.total += item.getsubtotal();
        }

        public double gettotal()
        {
            return total;
        }

        public List<Item> getlisitem()
        {
            return listitem;
        }
    }
}
