using InventorySystem_EmilyCarter.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_EmilyCarter
{
    public partial class ModifyProduct : Form
    {

        //Product product = new Product();
        private BindingList<Part> partsAssociated = new BindingList<Part>();
        private int modifyProductID;

        public ModifyProduct(Product product)
        {
         
            InitializeComponent();

            modifyProductID = product.ProductID;
            textID.Text = product.ProductID.ToString();
            textName.Text = product.Name;
            textInventory.Text = product.InStock.ToString();
            textPrice.Text = product.Price.ToString();
            textMax.Text = product.Max.ToString();
            textMin.Text = product.Min.ToString();

            partsAssociated = product.AssociatedParts;
            partsAssociatedProductView.DataSource = partsAssociated;


            allPartsModify.DataSource = Inventory.AllParts;
            allPartsModify.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            allPartsModify.ReadOnly = true;
            allPartsModify.MultiSelect = false;
            allPartsModify.AllowUserToAddRows = false;

           
          
            partsAssociatedProductView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            partsAssociatedProductView.ReadOnly = true;
            partsAssociatedProductView.MultiSelect = false;
            partsAssociatedProductView.AllowUserToAddRows = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textValue = modifySearchBox.Text.ToUpper();
            bool flag = false;

            allPartsModify.ClearSelection();

            if (String.IsNullOrWhiteSpace(textValue))
            {
                MessageBox.Show("Part not found");

            }
            else
            {
                foreach (DataGridViewRow row in allPartsModify.Rows)

                {
                    if (row.Cells["Name"].Value.ToString().ToUpper().Contains(textValue))
                    {
                        flag = true;
                        row.Selected = true;
                        break;
                    }
                }

                if (!flag)
                {
                    MessageBox.Show("No match found.");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            InventoryMain inventory = new InventoryMain();
            inventory.Show();

            this.Hide();
        }

        private void modifyDelete_Click(object sender, EventArgs e)
        {
            if (partsAssociatedProductView.RowCount == 0)
            {
                MessageBox.Show("No Parts To Delete");
                return;
            }

            if (!partsAssociatedProductView.CurrentRow.Selected)
            {
                MessageBox.Show("Current Row Not Selected");
                return;
            }

            var rowindex = partsAssociatedProductView.CurrentCell.RowIndex;
          
            DialogResult deleteResult = MessageBox.Show("Do you want to delete ?", "Important",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deleteResult == DialogResult.Yes)
            {
                partsAssociatedProductView.Rows.RemoveAt(rowindex);
                MessageBox.Show("Part Deleted");
            }
            else
            {
                MessageBox.Show("Part not deleted!");
            }
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifyAdd_Click(object sender, EventArgs e)
        {
            if (allPartsModify.RowCount == 0)
            {
                MessageBox.Show("No Parts To Add");
                return;
            }

            if (!allPartsModify.CurrentRow.Selected)
            {
                MessageBox.Show("Current Row Not Selected");
                return;

            }

            var selectedPart = (Part)allPartsModify.CurrentRow.DataBoundItem;
           
            partsAssociated.Add(selectedPart);
            partsAssociatedProductView.DataSource = partsAssociated;
        }

        private void modifySave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int partID = rnd.Next(1000);

          
            string partName;
            int machineid;
            int max;
            int min;
            int instock;
            decimal price;
            decimal decimalTemp;
            int intTemp;

            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Type in name of part.");
                textName.Clear();
                textName.Focus();
                return;
            }
            else
            {
                partName = textName.Text;
            }

            if (!Int32.TryParse(textID.Text, out intTemp))
            {
                MessageBox.Show("Type in an integer for the machine ID");
                textID.Clear();
                textID.Focus();
                return;
            }
            else
            {
                machineid = int.Parse(textID.Text);
            }

            if (!Int32.TryParse(textMax.Text, out intTemp))
            {
                MessageBox.Show("Please type in an integer");
                textMax.Clear();
                textMax.Focus();
                return;

            }
            else
            {
                max = int.Parse(textMax.Text);
            }

            if (!Int32.TryParse(textMin.Text, out intTemp))
            {
                MessageBox.Show("Please type in an integer");
                textMin.Clear();
                textMin.Focus();
                return;

            }
            else
            {
                min = int.Parse(textMin.Text);
            }

            if (!Int32.TryParse(textInventory.Text, out intTemp))
            {
                MessageBox.Show("Please type in an integer");
                textInventory.Clear();
                textInventory.Focus();
                return;

            }
            else
            {
                instock = int.Parse(textInventory.Text);
            }
            if (!decimal.TryParse(textPrice.Text, out decimalTemp))
            {
                MessageBox.Show("Please type in an integer");
                textPrice.Clear();
                textPrice.Focus();
                return;

            }
            else
            {
                price = int.Parse(textPrice.Text);
            }


            var modifyProduct = new Product

                      {
                //ProductID = textID,
                //Name = textName.Text,
                //Max = textMax.Parse(textMax.Text),
                //Min = textMin.Parse(textMin.Text),
                //InStock = textInventory.Parse(textInventory.Text),
                //Price = textPrice.Parse(textPrice.Text)
            };
            Inventory.addProduct(modifyProduct);

            this.Hide();
            InventoryMain inventoryMain = new InventoryMain();
            inventoryMain.Show();

        }
    }
}
