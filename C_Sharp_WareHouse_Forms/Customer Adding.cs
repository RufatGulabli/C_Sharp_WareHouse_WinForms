using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace C_Sharp_WareHouse_Forms
{
    public partial class CustomerAdding : Form
    {
        public CustomerAdding()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text)))
                    throw new Exception("Please fill all rows");
                if ((!Regex.IsMatch(txtBxName.Text, @"^[a-zA-Z]{3,50}$")) 
                    || (!Regex.IsMatch(txtBxSurname.Text, @"^[a-zA-Z]{3,50}$")))
                    throw new Exception("Name or Surname can not contain any Numbers");
                if (!maskdTxtBxPhone.MaskCompleted)
                    throw new Exception("Please fill Contact Deatils");
                Containers.CreateCustomer(txtBxName.Text, txtBxSurname.Text, txtBoxEmail.Text, maskdTxtBxPhone.Text, richTxtBxAddr.Text);
                MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
