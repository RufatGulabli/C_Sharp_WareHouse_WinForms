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
        Containers container ;
        public CustomerAdding(Containers cont)
        {
            InitializeComponent();
            container = cont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txtBoxEmail.Text,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase))
                    throw new Exception("WRONG EMAIL FORMAT");
                if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text)))
                    throw new Exception("Please fill all rows");
                if ((!Regex.IsMatch(txtBxName.Text, @"^[a-zA-Z]{3,50}$")) 
                    || (!Regex.IsMatch(txtBxSurname.Text, @"^[a-zA-Z]{3,50}$")))
                    throw new Exception("Name or Surname can not contain any Numbers");
                if (!maskdTxtBxPhone.MaskCompleted)
                    throw new Exception("Please fill Contact Deatils");
                Customer cust = new Customer(txtBxName.Text, txtBxSurname.Text, txtBoxEmail.Text, maskdTxtBxPhone.Text, richTxtBxAddr.Text);
                container.AddCustomer(cust);
                MessageBox.Show("Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerAdding_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
