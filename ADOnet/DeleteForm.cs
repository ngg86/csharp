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
using System.Data.SqlClient;
using NorthwindClasses;

namespace ADOnet
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            GetProductsForDropDown();
        }

        public void GetProductsForDropDown()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName FROM Products", con);
         
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {                
                while (reader.Read())
                {
                    cbDelProduct.Items.Add(reader[1]);
                }
                reader.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        public void DeleteProduct()
        {
            string item = cbDelProduct.SelectedItem.ToString();

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductName = item", con);


        }
    }
}
