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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            string pName = tbPNameInvoer.Text;
            bool disContinued = cbDiscontinued.Checked;
            
            product.productName = pName;
            product.discontinued = disContinued;
            ProductsDAL.InsertProduct(product);           
            
        }
    }
}
