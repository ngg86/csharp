using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindClasses;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProductsDAL
    {

        public static List<Products> GetProducts()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-698P2MHO\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);
            List<Products> products = new List<Products>();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    Products item = new Products();
                    item.productID = reader.GetInt32(0);
                    item.productName = reader.GetString(1);
                    if( !reader.IsDBNull(2)) item.supplierID = reader.GetInt32(2);
                    if (!reader.IsDBNull(3)) item.categorieID = reader.GetInt32(3);
                    item.quantityPerUnit = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    if (!reader.IsDBNull(5)) item.unitPrice = (decimal)reader.GetSqlMoney(5);
                    if (!reader.IsDBNull(6)) item.unitInStock = reader.GetInt16(6);
                    if (!reader.IsDBNull(7)) item.unitsOnOrder = reader.GetInt16(7);
                    if (!reader.IsDBNull(8)) item.reorderLevel = reader.GetInt16(8);
                    if (!reader.IsDBNull(9)) item.discontinued = reader.GetBoolean(9);

                    products.Add(item);
                }
                reader.Close();
            }
            catch (Exception)
            {

            }

            return products;
        }
        
        

        public static int InsertProduct(Products product)
        {
            int productID = 0;
            string connectionString = "Data Source=LAPTOP-698P2MHO\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string InsertString = "INSERT INTO Products (ProductName, Discontinued) VALUES (@ProductName, @Discontinued) SELECT CAST(SCOPE_IDENTITY() AS int);";
                SqlCommand command = new SqlCommand(InsertString, connection);
                command.Parameters.AddWithValue("@ProductName", product.productName);
                command.Parameters.AddWithValue("@Discontinued", product.discontinued);
                try
                {
                    connection.Open();
                    productID = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    productID = 0;
                    System.Diagnostics.Debug.Write(ex.Message);
                }
            } // using
            return productID;

        }


     

    }
}
