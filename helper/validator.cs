using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_EmilyCarter.helper
{
    public class Validator
    { //helper class to prevent redundancy 
        public void validateMinMax(TextBox textBoxMin, TextBox textBoxMax, out int? minimum, out int? maximum, out bool isValid)
        {

            int intTemp;
            minimum = null;
            maximum = null;
            isValid = true;

            if (!int.TryParse(textBoxMax.Text, out intTemp))
            {
                MessageBox.Show("Please type in an integer for Max");
                textBoxMax.Clear();
                textBoxMax.Focus();
                isValid = false;

            }
            else
            {
                maximum = int.Parse(textBoxMax.Text);
            }

            if (!int.TryParse(textBoxMin.Text, out intTemp))
            {
                MessageBox.Show("Please type in an integer for Min");
                textBoxMin.Clear();
                textBoxMin.Focus();
                isValid = false;

            }
            else
            {
                minimum = int.Parse(textBoxMin.Text);
            }

            if (maximum < 0)
            {
                MessageBox.Show("Max should not be less than Zero");
                textBoxMax.Clear();
                textBoxMax.Focus();
                isValid = false;

            }
            if (minimum > maximum)
            {
                MessageBox.Show("Min should be less than or equal to Max");
                textBoxMin.Clear();
                textBoxMin.Focus();
                isValid = false;
            }

            if (minimum < 0)
            {
                MessageBox.Show("Min should not be less than Zero");
                textBoxMin.Clear();
                textBoxMin.Focus();
                isValid = false;

            }
        }
    }
}
