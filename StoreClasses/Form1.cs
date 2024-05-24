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
            // clear
            listBox.Items.Clear();

            // re add all items
            foreach (Item item in items)
            {
                listBox.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check if item selected
            if (listBox.SelectedIndex != -1)
            {
                // get selected item
                Item selectedItem = (Item)listBox.SelectedItem;

                // display details in txt boxes
                txtItemId.Text = selectedItem.GetItemId();
                txtName.Text = selectedItem.GetName();
                txtPrice.Text = selectedItem.GetPrice().ToString("C");
            }
        }


       

        private void btnUpdateItem_Click_1(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listBox.SelectedIndex != -1)
            {
                // get item
                Item selectedItem = (Item)listBox.SelectedItem;

                // update properties of selected item
                selectedItem.SetItemId(txtItemId.Text);
                selectedItem.SetName(txtName.Text);

              
                double price;
                if (double.TryParse(txtPrice.Text, out price))
                {
                    selectedItem.SetPrice(price);
                }
                else
                {
                    MessageBox.Show("Invalid price format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please select an item to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateListBox();
        }
    }
}
