using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_WareHouse_Forms
{
    public partial class ProductsDataGridtViewForm : Form
    {
        Containers container;
        ProductAdding AddingProductForm;

        public ProductsDataGridtViewForm(Containers cont)
        {
            InitializeComponent();
            container = cont;
            container.ProductsUpdate += UpdateProductDataGrid;
        }


        private void UpdateProductDataGrid()
        {
            dataGridViewPRD.Rows.Clear();
            var list = Containers.GetProductList();
            foreach (var item in list)
            {
                string[] row = new string[]
                {
                    item.UniqueID.ToString(),
                    item.ArticleName,
                    item.Price.ToString(),
                    item.Quantity.ToString()
                };
                dataGridViewPRD.Rows.Add(row);
            }
        }


        private void btnAddPRD_Click(object sender, EventArgs e)
        {
            if (AddingProductForm == null)
            {
                AddingProductForm = new ProductAdding(container);
                AddingProductForm.StartPosition = FormStartPosition.CenterParent;
                AddingProductForm.FormClosed += AddingProductForm_FormClosed;
                AddingProductForm.Show();
            }
            else
                AddingProductForm.Activate();
        }

        private void AddingProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddingProductForm = null;
        }

        private void ProductsDataGridtViewForm_Load(object sender, EventArgs e)
        {
            dataGridViewPRD.Rows.Clear();
            var list = Containers.GetProductList();
            foreach (var item in list)
            {
                string[] row = new string[]
                {
                    item.UniqueID.ToString(),
                    item.ArticleName,
                    item.Price.ToString(),
                    item.Quantity.ToString()
                };
                dataGridViewPRD.Rows.Add(row);
            }
        }
    }
}
