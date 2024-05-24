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

                bool perished;

                if (selectedItem is PerishableItem)
                {
                    if (bool.TryParse(txtBoxPerished.Text, out perished) && txtBoxPerished.Text != "")
                    {
                        PerishableItem perishableItem = (PerishableItem)selectedItem;
                        perishableItem.SetPerish(perished);
                    }

                    else
                    {
                        MessageBox.Show("Ivalid Bool", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


            }
            else
            {
                MessageBox.Show("Please select an item to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateListBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // if item selected
            if (listBox.SelectedIndex != -1)
            {
                //get item
                Item selectedItem = (Item)listBox.SelectedItem;

                // remove from list
                items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UpdateListBox();
        }

        private void btnperish_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                // Get the selected item
                Item selectedItem = (Item)listBox.SelectedItem;

                // Check if the selected item is a perishable item
                if (selectedItem is PerishableItem)
                {
                    PerishableItem perishableItem = (PerishableItem)selectedItem;
                    perishableItem.SetPerish(true);
                    UpdateListBox();
                }
                else
                {
                    MessageBox.Show("Selected item is not perishable.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to perish.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerishableItem perishableItem = new PerishableItem("54321", "Milk", 2.99, false);
            items.Add(perishableItem);
            UpdateListBox();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                // Get the selected item
                Item selectedItem = (Item)listBox.SelectedItem;

                // Update the textboxes with the details of the selected item
                txtItemId.Text = selectedItem.GetItemId();
                txtName.Text = selectedItem.GetName();
                txtPrice.Text = selectedItem.GetPrice().ToString("C");

                // Check if the selected item is a perishable item
                if (selectedItem is PerishableItem perishableItem)
                {
                    txtBoxPerished.Text = perishableItem.GetPerished().ToString();
                }
                else
                {
                    // Clear the perished textbox if the selected item is not perishable
                    txtBoxPerished.Clear();
                }
            }
            else
            {
                // Clear all textboxes if no item is selected
                txtItemId.Clear();
                txtName.Clear();
                txtPrice.Clear();
                txtBoxPerished.Clear();
            }
        }
    }
}
