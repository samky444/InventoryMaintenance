using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{     // Samuel and Fatima - Create and Use a Class - Extra 12-1 - 05/28/2022
        // Create a class named InvItem
    public class InvItem
    {
        private int itemNo;
        private string description;
        private decimal price;
        public InvItem()
        {
        }
        // Constructor that initializes the object

        public InvItem(int itemNo, string description, decimal price)
        {
            this.itemNo = itemNo;
            this.description = description;
            this.price = price;
        }       
                // properties
        public int ItemNo
        {
            get
            {
                return itemNo;
            }
            set
            {
                itemNo = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public decimal Price  // property
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }           // method of the class

        internal void Add(InvItem invItem)
        {
            throw new NotImplementedException();
        }

        public string GetDisplayText()
        {
            return itemNo + "    " + description + " (" + price.ToString("c") + ")";
        }

        internal void Remove(InvItem invItem)
        {
            throw new NotImplementedException();
        }
    }
}
