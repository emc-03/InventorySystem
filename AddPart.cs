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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void addSave_Click(object sender, EventArgs e)
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

            if (!Int32.TryParse(machineNameID.Text, out intTemp))
            {
                MessageBox.Show("Type in an integer for the machine ID");
                machineNameID.Clear();
                machineNameID.Focus();
                return;
            }
            else
            {
                machineid = int.Parse(machineNameID.Text);
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




            if (radioInHouse.Checked)
            {
                int machineID = int.Parse(machineNameID.Text);


                var inhousePart = new Inhouse
                {
                    PartID = partID,
                    Name = partName,
                    MachineID = machineid,
                    Max = max,
                    Min = min,
                    InStock = instock,
                    Price = price   
                };
                Inventory.AddPart(inhousePart);
            }
            else
            {
               
                     var outsourced = new Outsourced
                     {
                         PartID = partID,
                         Name = textName.Text,
                         CompanyName = machineNameID.Text,
                         Max = int.Parse(textMax.Text),
                         Min = int.Parse(textMin.Text),
                         InStock = int.Parse(textInventory.Text),
                         Price = decimal.Parse(textPrice.Text)
                     };
                Inventory.AddPart(outsourced);
            }

            InventoryMain inventoryMain = new InventoryMain();
            inventoryMain.Show();
            this.Hide();
        }

        private void partCancel_Click(object sender, EventArgs e)
        {
           
            InventoryMain inventoryMain = new InventoryMain();
            inventoryMain.Show();
            this.Hide();

        }

        private void radioInHouse_CheckedChanged(object sender, EventArgs e)
        {
            companyNameMachineID.Text = "Machine ID";
        }

        private void radioOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            companyNameMachineID.Text = "Company Name";
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textInventory_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCompName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
