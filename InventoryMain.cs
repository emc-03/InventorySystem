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
    public partial class InventoryMain : Form
    {
        private BindingList<Part> listOfParts;
        public InventoryMain()
        {
            InitializeComponent();
        }

        private void InventoryMain_Load(object sender, EventArgs e)
        {

            dataParts.DataSource = Inventory.AllParts;
            dataProducts.DataSource = Inventory.Products;
            dataParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataParts.ReadOnly = true;
            dataParts.MultiSelect = false;
            dataParts.AllowUserToAddRows = false;

            dataProducts.ReadOnly = true;
            dataProducts.MultiSelect = false;
            dataProducts.AllowUserToAddRows = false;
        }


        private void dataParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {

            DialogResult exitResult = MessageBox.Show("Do you want to Exit ?", "Important",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitResult == DialogResult.Yes)
            {
                this.Hide();
                Application.Exit();
            }

        }

        private void AddParts_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.Show();

            this.Hide();
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            var selectedPart = (Part)dataParts.CurrentRow.DataBoundItem;

            modifyParts modify = new modifyParts(selectedPart);
            modify.Show();

            this.Hide();
        }

        private void DeleteParts_Click(object sender, EventArgs e)
        {
            if (dataParts.RowCount == 0)
            {
                MessageBox.Show("No Parts To Delete", "Alert");
                return;
            }

            if (!dataParts.CurrentRow.Selected)
            {
                MessageBox.Show("Current Row Not Selected", "Alert");
                return;
            }

            var selectedPart = (Part)dataParts.CurrentRow.DataBoundItem;

            DialogResult deleteResult = MessageBox.Show("Do you want to delete ?", "Alert",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deleteResult == DialogResult.Yes)
            {
                Inventory.DeletePart(selectedPart);
                MessageBox.Show("Part Deleted!", "Alert");
            }

            else
            {
                MessageBox.Show("Part not deleted!", "Alert");
            }



        }

        private void bindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {   //clear selection
            dataParts.ClearSelection();
        }

        private void AddProducts_Click(object sender, EventArgs e)
        {
            AddProducts addProduct = new AddProducts();
            addProduct.Show();

            this.Hide();
        }



        private void ModifyProducts_Click(object sender, EventArgs e)
        {
            var product = (Product)dataProducts.CurrentRow.DataBoundItem;
            ModifyProduct modifyProducts = new ModifyProduct(product);
            modifyProducts.Show();

            this.Hide();

        }

        private void DeleteProducts_Click(object sender, EventArgs e)
        {

            if (dataProducts.RowCount == 0)
            {
                MessageBox.Show("No Products To Delete");
                return;
            }

            if (!dataProducts.CurrentRow.Selected)
            {
                MessageBox.Show("Current Row Not Selected");
                return;
            }

            Product selectedProduct = (Product)dataProducts.CurrentRow.DataBoundItem;
            int productID = dataProducts.CurrentRow.Index;
            if (selectedProduct.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot Delete because a Part is assigned", "Alert");
                return;
            }

            DialogResult deleteResult = MessageBox.Show("Do you want to delete ?", "Important",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteResult == DialogResult.Yes)
            {
                Inventory.RemoveProduct(productID);
                MessageBox.Show("Part Deleted!", "Alert");
            }
            else
            {
                MessageBox.Show("Part not deleted!", "Alert");
            }


        }

        private void mainProductSearch_Click(object sender, EventArgs e)
        {
            string textValue = searchProductBox.Text.ToUpper();
            bool flag = false;

            dataProducts.ClearSelection();

            if (String.IsNullOrWhiteSpace(textValue))
            {
                MessageBox.Show("Product not found");

            }
            else
            {
                foreach (DataGridViewRow row in dataProducts.Rows)
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
        private void searchProductBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void searchPartBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainPartsSearch_Click(object sender, EventArgs e)
        {
            string textValue = searchPartBox.Text.ToUpper();
            bool flag = false;

            dataParts.ClearSelection();

            if (String.IsNullOrWhiteSpace(textValue))
            {
                MessageBox.Show("Part not found");

            }
            else
            {
                foreach (DataGridViewRow row in dataParts.Rows)
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

        private void dataProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
