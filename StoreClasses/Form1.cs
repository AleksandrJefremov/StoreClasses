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


// create demo item
        private void btnCreateItem1_Click(object sender, EventArgs e)
        {
            Item item = new Item("12345", "Laptop", 9990.99);

            txtItemId.Text = item.GetItemId();
            txtName.Text = item.GetName();
            txtPrice.Text = item.GetPrice().ToString("C");

            items.Add(item);
            UpdateListBox();
        }

        //update listbox (self explanatory imo?!)
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


        //update update selected item
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
                        // and fresh produce
                        if (selectedItem is FreshProduce freshProduce)
                        {
                            freshProduce.SetFarm(txtFreshProduce.Text);
                        }
                        else
                        {
                            // clear
                            txtFreshProduce.Clear();
                        }
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


        //delete selected item
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


        //make perishable items/fresh produce perish = loose value
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

        // create demo perishable item
        private void button1_Click(object sender, EventArgs e)
        {
            PerishableItem perishableItem = new PerishableItem("54321", "Milk", 29.99, false);
            items.Add(perishableItem);
            UpdateListBox();
        }


        //if listbox selected item changes

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                // get selected item
                Item selectedItem = (Item)listBox.SelectedItem;

                // update textboxes
                txtItemId.Text = selectedItem.GetItemId();
                txtName.Text = selectedItem.GetName();
                txtPrice.Text = selectedItem.GetPrice().ToString("C");

                // if perishable item
                if (selectedItem is PerishableItem perishableItem)
                {
                    txtBoxPerished.Text = perishableItem.GetPerished().ToString();
                    // and fresh produce
                    if (selectedItem is FreshProduce freshProduce)
                    {
                        txtFreshProduce.Text = freshProduce.GetFarm();
                    }
                    else
                    {
                        // clear
                        txtFreshProduce.Clear();
                    }
                }
                else
                {

                    txtBoxPerished.Clear();
                }
            }
            else
            {
                // if no item selected
                txtItemId.Clear();
                txtName.Clear();
                txtPrice.Clear();
                txtBoxPerished.Clear();
                txtFreshProduce.Clear();
            }
        }


        // create farm produce
        private void btnCreateFresh_Click(object sender, EventArgs e)
        {

            // Create a new fresh produce item
            FreshProduce freshProduceItem = new FreshProduce("67890", "Apple", 1.99, false, "Farmor Agnetas");
            items.Add(freshProduceItem);
            UpdateListBox();
        }


        //if i delete this i get error
        private void label1_Click(object sender, EventArgs e)
        {

        }


        //if i delete this i get error
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
