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
    public partial class modifyParts : Form
    {
        public modifyParts()
        {
            InitializeComponent();
        }


        public modifyParts(Part part)
        {

            InitializeComponent();

            textID.Text = part.PartID.ToString();
            textName.Text = part.Name;
            textInventory.Text = part.InStock.ToString();
            textPrice.Text = part.Price.ToString();
            textMax.Text = part.Max.ToString();
            textMin.Text = part.Min.ToString();

            if (part is Inhouse)
            {
                radioInHouse.Checked = true;
                labelCompName.Text = "Machine ID";

                Inhouse inhouse = (Inhouse)part;
                textCompanyName.Text = inhouse.MachineID.ToString();
                       }
            else
            {
                Outsourced.Checked = true;
                labelCompName.Text = "Company Name";
                Outsourced radioOutsorced = (Outsourced)part;
                textCompanyName.Text = radioOutsorced.CompanyName.ToString();

            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            InventoryMain inventory = new InventoryMain();
            inventory.Show();

            this.Hide();
        }

        private void modPartSave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int partID = rnd.Next(1000);

            if (radioInHouse.Checked)
            {
                int machineID = int.Parse(textCompanyName.Text);

                var inhousePart = new Inhouse
                {
                    PartID = partID,
                    Name = textName.Text,
                    MachineID = int.Parse(textCompanyName.Text),
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
                    CompanyName = textCompanyName.Text,
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioInHouse_CheckedChanged(object sender, EventArgs e)
        {
           labelCompName.Text = "Machine ID";
        }

        private void Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            labelCompName.Text = "Company Name";
        }
    }
}
