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

            if (radioInHouse.Checked)
            {
                int machineID = int.Parse(machineNameID.Text);

                var inhousePart = new Inhouse
                {
                    PartID = partID,
                    Name = textName.Text,
                    MachineID = int.Parse(machineNameID.Text),
                    Max = int.Parse(textMax.Text),
                    Min = int.Parse(textMin.Text),
                    InStock = int.Parse(textInventory.Text),
                    Price = decimal.Parse(textPrice.Text)
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
    }
}
