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
    public partial class modifyParts : Form
    {
        private int modPartID;

        public modifyParts()
        {
            InitializeComponent();

        }


        public modifyParts(Part part)
        {

            InitializeComponent();

            modPartID = part.PartID;
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
                MessageBox.Show("Type in an Integer for Inventory");
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
                MessageBox.Show("Type in a decimal number for Price");
                textPrice.Clear();
                textPrice.Focus();
                return;
            }
            else
            {
                price = decimal.Parse(textPrice.Text);
            }



            if (radioInHouse.Checked)
            { 
                
                if (!int.TryParse(textCompanyName.Text, out intTemp))
                {
                    MessageBox.Show("Type in an Integer for Machine ID.");
                    textCompanyName.Clear();
                    textCompanyName.Focus();
                    return;
                }
                else
                {
                   int machineID = int.Parse(textCompanyName.Text);
                }

                var inhousePart = new Inhouse
                {
                    PartID = int.Parse(textID.Text),
                    Name = textName.Text,
                    MachineID = machineid,
                    Max = max ?? 0,
                    Min = min ?? 0,
                    InStock = instock,
                    Price = price
                };
                Inventory.updatePart(modPartID,inhousePart);
           
            }
            else
            {

                var outsourced = new Outsourced
                {
                    PartID = int.Parse(textID.Text),
                    Name = textName.Text,
                    CompanyName = textCompanyName.Text,
                    Max = max ?? 0,
                    Min = min ?? 0,
                    InStock = instock,
                    Price = price
                };
               
                Inventory.updatePart(modPartID,outsourced);
                    
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

        private void modifyParts_Load(object sender, EventArgs e)
        {

        }
    }
}
