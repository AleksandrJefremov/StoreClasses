using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreClasses
{
    internal class Item
    {
        // Properties
        private string itemId;
        private string name;
        private double price;

        // Constructor
        public Item(string ItemId, string Name, double Price)
        {
            itemId = ItemId;
            name = Name;
            price = Price;
        }

        // get set
        public string GetItemId() => itemId;
        public void SetItemId(string value) => itemId = value;
        public string GetName() => name;
        public void SetName(string value) => name = value;

        public double GetPrice() => price;
        public void SetPrice(double value) => price = value;

        // debug
        public void DisplayInfo()
        {
            System.Diagnostics.Debug.WriteLine($"Item ID: {itemId}");
            System.Diagnostics.Debug.WriteLine($"Name: {name}");
            System.Diagnostics.Debug.WriteLine($"Price: {price:C}");
        }

        public override string ToString()
        {
            return $"{name} ({itemId}) - {price:C}";
        }
    }

    internal class PerishableItem : Item
    {
        // properties
        public bool perished; 

        // constructor
        public PerishableItem(string itemId, string name, double price, bool perished)
            : base(itemId, name, price)
        {
            perished = perished;
        }

        public bool GetPerished() => perished;
        public void SetPerish(bool bad)
        {
            perished = bad;

            if (perished)
            {
                SetPrice(0);
            }
        }
    }
    internal class FreshProduce : PerishableItem
    {
        // Properties
        private string farm;

        // Constructor
        public FreshProduce(string itemId, string name, double price, bool perished, string origin)
            : base(itemId, name, price, perished)
        {
            farm = origin;
        }

        // get set
        public string GetFarm() => farm;
        public void SetFarm(string value) => farm = value;
    }
}
