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
        //public static BindingList<Product> addProducts = new BindingList<Product>();
        //public static BindingList<Product> associatedProducts = new BindingList<Product>();

        public AddProducts()
        {
         InitializeComponent();

            AllPartsGrid.DataSource = Inventory.AllParts;
            AllPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

            AllPartsGrid.ReadOnly = true;
            AllPartsGrid.MultiSelect = false;
            AllPartsGrid.AllowUserToAddRows = false;

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
            //if (addPart.RowCount == 0)
            //{
            //    MessageBox.Show("No Parts To Delete");
            //    return;
            //}

            //if (!addParts.CurrentRow.Selected)
            //{
            //    MessageBox.Show("Current Row Not Selected");
            //    return;
            //}

            //var selectedProducts = (Part)addPart.CurrentRow.DataBoundItem;

            //DialogResult deleteResult = MessageBox.Show("Do you want to delete ?", "Important",
            //MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        private void productSave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int productID = rnd.Next(1000);


            var addNewProduct = new Product
            {
                ProductID = productID,
                Name = nameBox.Text,
                Max = int.Parse(addProductMax.Text),
                Min = int.Parse(addProductMin.Text),
                InStock = int.Parse(inventoryBox.Text),
                Price = decimal.Parse(priceBox.Text)
            };
            Inventory.addProduct(addNewProduct);

            this.Hide();
            InventoryMain inventoryMain = new InventoryMain();
            inventoryMain.Show();
                
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchBox.Text = " ";
        }

        private void productSearch_Click(object sender, EventArgs e)
        {
            // try {} catch {} to catch errors 
            //
            //if searchBox.Text.Length >  )
            {

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
    }
}
