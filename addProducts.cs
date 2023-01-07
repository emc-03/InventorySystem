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
    public partial class AddProducts : Form
    {


        Product product = new Product();

        public AddProducts()
        {
            InitializeComponent();

            AllPartsGrid.DataSource = Inventory.AllParts;
            AllPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            AllPartsGrid.ReadOnly = true;
            AllPartsGrid.MultiSelect = false;
            AllPartsGrid.AllowUserToAddRows = false;

            partsAssociatedProduct.DataSource = product.AssociatedParts;
            partsAssociatedProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            partsAssociatedProduct.ReadOnly = true;
            partsAssociatedProduct.MultiSelect = false;
            partsAssociatedProduct.AllowUserToAddRows = false;


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            InventoryMain inventoryMain = new InventoryMain();
            inventoryMain.Show();

            this.Hide();
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addProSearch_Click(object sender, EventArgs e)
        {

        }

        private void deletePart_Click(object sender, EventArgs e)
        {


            if (partsAssociatedProduct.RowCount == 0)
            {
                MessageBox.Show("No Parts To Delete");
                return;
            }

            if (!partsAssociatedProduct.CurrentRow.Selected)
            {
                MessageBox.Show("Current Row Not Selected");
                return;
            }

            var selectedPart = (Part)partsAssociatedProduct.CurrentRow.DataBoundItem;

            DialogResult deleteResult = MessageBox.Show("Do you want to delete ?", "Important",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deleteResult == DialogResult.Yes)
            {
                product.AssociatedParts.Remove(selectedPart);
                MessageBox.Show("Part Deleted");
            }
            else
            {
                MessageBox.Show("Part not deleted!");
            }

        }

        private void productSave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int productID = rnd.Next(1000);
            addIdBox.Text = productID.ToString();

            string partName;
            int? max;
            int? min;
            int instock;
            decimal price;
            decimal decimalTemp;
            int intTemp;

            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show("Type in name of part.");
                nameBox.Clear();
                nameBox.Focus();
                return;
            }
            else
            {
                partName = nameBox.Text;
            }


            Validator validator = new Validator();
            bool isValid;
            validator.validateMinMax(addProductMin, addProductMax, out min, out max, out isValid);

            if (!isValid)
            {
                return;
            }

            if (!int.TryParse(inventoryBox.Text, out intTemp))
            {
                MessageBox.Show("Please type in an integer for Inventory");
                inventoryBox.Clear();
                inventoryBox.Focus();
                return;

            }
            else
            {
                instock = int.Parse(inventoryBox.Text);
            }
            if (instock < min || instock > max)
            {
                MessageBox.Show("Inventory must be within range");
                inventoryBox.Clear();
                inventoryBox.Focus();
                return;

            }

            if (!decimal.TryParse(priceBox.Text, out decimalTemp))
            {
                MessageBox.Show("Please type in a decimal number for Price");
                priceBox.Clear();
                priceBox.Focus();
                return;

            }
            else
            {
                price = decimal.Parse(priceBox.Text);
            }

            var addNewProduct = new Product
            {
                ProductID = productID,
                Name = nameBox.Text,
                Max = max ?? 0,
                Min = min ?? 0,
                InStock = instock,
                Price = price
            };


            foreach (DataGridViewRow row in partsAssociatedProduct.Rows)
            {
                var selectedPart = (Part)row.DataBoundItem;
                addNewProduct.AssociatedParts.Add(selectedPart);
            }

            Inventory.addProduct(addNewProduct);

            this.Hide();
            InventoryMain inventoryMain = new InventoryMain();
            inventoryMain.Show();

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productSearch_Click(object sender, EventArgs e)
        {
            string textValue = searchBox.Text.ToUpper();
            bool flag = false;

            partsAssociatedProduct.ClearSelection();

            if (String.IsNullOrWhiteSpace(textValue))
            {
                MessageBox.Show("Part not found");

            }
            else
            {
                foreach (DataGridViewRow row in partsAssociatedProduct.Rows)

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

        private void addIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inventoryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void partsAssociatedProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addPart_Click(object sender, EventArgs e)
        {
            if (AllPartsGrid.RowCount == 0)
            {
                MessageBox.Show("No Parts To Add");
                return;
            }

            if (!AllPartsGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Current Row Not Selected");
                return;

            }

            var selectedPart = (Part)AllPartsGrid.CurrentRow.DataBoundItem;
            product.AddAssociatedPart(selectedPart);
        }

        private void addProdLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
