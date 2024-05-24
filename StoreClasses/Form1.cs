using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreClasses
{
    public partial class Form1 : Form
    {

        private List<Item> items = new List<Item>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void btnCreateItem1_Click(object sender, EventArgs e)
        {
            Item item = new Item("12345", "Laptop", 999.99);

            txtItemId.Text = item.GetItemId();
            txtName.Text = item.GetName();
            txtPrice.Text = item.GetPrice().ToString("C");

            items.Add(item);
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            // Clear the ListBox
            listBox.Items.Clear();

            // Add each item to the ListBox
            foreach (Item item in items)
            {
                listBox.Items.Add(item);
            }
        }


    }
}
