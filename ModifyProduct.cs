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
        public ModifyProduct()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        }
    }
}
