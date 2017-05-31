using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindClasses;
using DataAccessLayer;

namespace ADOnet
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = ProductsDAL.GetProducts();
        }

        private void btnVoegProduct_Click(object sender, EventArgs e)
        {
            ProductInvoer pInvoer = new ProductInvoer();
            pInvoer.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = ProductsDAL.GetProducts();
        }

        private void btnDeleteForm_Click(object sender, EventArgs e)
        {
            DeleteForm del = new DeleteForm();
            del.Show();
        }

        /* private void ShowInsertForm()
         {
             ProductInvoer prodinv = new ProductInvoer();
             prodinv.ProductToegevoegd += ProductInserted;
             prodinv.Show();
         }

         private void ProductInserted(object sender, EventArgs e)
         {
             dgvProducts.DataSource = ProductsDAL.GetProducts();
         }*/
    }


}
