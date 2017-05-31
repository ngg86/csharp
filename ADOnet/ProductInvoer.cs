using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using NorthwindClasses;
using System.Data.SqlClient;

namespace ADOnet
{
    public partial class ProductInvoer : Form
    {
        public ProductInvoer()
        {
            InitializeComponent();
        }

        public EventHandler ProductToegevoegd;

        public void ProductIsToegevoegd(EventArgs e)
        {
            if(ProductToegevoegd != null)
            {
                ProductToegevoegd(this, e);
            }
        }

        private void InsertProduct()
        {
            if (string.IsNullOrEmpty(tbPNameInvoer.Text))
                return;

            Products product = new Products();
            product.productName = tbPNameInvoer.Text;
            product.discontinued = cbDiscontinued.Checked;
            int productID = ProductsDAL.InsertProduct(product);
            if(productID!=0)
            {
                product.productID = productID;
                ProductIsToegevoegd(EventArgs.Empty);
                string message = string.Format("Product met ID {0} toegevoegd.", product.productID);
                MessageBox.Show(message);
            }
            else
            {
                string message = string.Format("Geen product toegevoegd.");
                MessageBox.Show(message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertProduct();
            
            
        }
    }
}
