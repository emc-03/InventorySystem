using InventorySystem_EmilyCarter.helper;
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

        private void modifySearch_Click(object sender, EventArgs e)
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

        private void modifyRemove_Click(object sender, EventArgs e)
        {
            if (partsAssociatedProductView.RowCount == 0)
            {
                MessageBox.Show("No Parts To Remove");
                return;
            }

            if (!partsAssociatedProductView.CurrentRow.Selected)
            {
                MessageBox.Show("Current Row Not Selected");
                return;
            }

            var rowindex = partsAssociatedProductView.CurrentCell.RowIndex;

            DialogResult removeResult = MessageBox.Show("Do you want to Remove?", "Important",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (removeResult == DialogResult.Yes)
            {
                partsAssociatedProductView.Rows.RemoveAt(rowindex);
                MessageBox.Show("Part Removed");
            }
            else
            {
                MessageBox.Show("Part not Removed!");
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

            string partName;
            int machineid;
            int? max;
            int? min;
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

            if (!int.TryParse(textID.Text, out intTemp))
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



            Validator validator = new Validator();
            bool isValid;
            validator.validateMinMax(textMin, textMax, out min, out max, out isValid);

            if (!isValid)
            {
                return;
            }

            if (!int.TryParse(textInventory.Text, out intTemp))
            {
                MessageBox.Show("Please type in an integer for Inventory");
                textInventory.Clear();
                textInventory.Focus();
                return;

            }
            else
            {
                instock = int.Parse(textInventory.Text);
            }
            if (instock < min || instock > max)
            {
                MessageBox.Show("Inventory must be within range");
                textInventory.Clear();
                textInventory.Focus();
                return;

            }

            if (!decimal.TryParse(textPrice.Text, out decimalTemp))
            {
                MessageBox.Show("Please type in a decimal number for Price");
                textPrice.Clear();
                textPrice.Focus();
                return;

            }
            else
            {
                price = decimal.Parse(textPrice.Text);
            }

            Inventory.UpdateProduct(
                int.Parse(textID.Text),
                textName.Text,
                price,
                instock,
                max ?? 0,
                min ?? 0);
            this.Hide();
            InventoryMain inventoryMain = new InventoryMain();
            inventoryMain.Show();

        }

        private void labelModifyProd_Click(object sender, EventArgs e)
        {

        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifySearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
