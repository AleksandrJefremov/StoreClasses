using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string GetItemId()
        {
            return itemId;
        }

        private void SetItemId(string value)
        {
            itemId = value;
        }

        // Getter and setter methods for Name
        public string GetName()
        {
            return name;
        }

        private void SetName(string value)
        {
            name = value;
        }

        // Getter and setter methods for Price
        public double GetPrice()
        {
            return price;
        }

        private void SetPrice(double value)
        {
            price = value;
        }


        // Method to display item details
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
}
