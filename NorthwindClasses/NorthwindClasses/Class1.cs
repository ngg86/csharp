using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindClasses
{
    public class Products
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public int? supplierID { get; set; }
        public int? categorieID { get; set; }
        public string quantityPerUnit { get; set; }
        public double unitPrice { get; set; }
        public int? unitInStock { get; set; }
        public int? unitsOnOrder { get; set; }
        public int? reorderLevel { get; set; }
        public bool discontinued { get; set; }
    }

    public class Category
    {
        public int? categoryID { get; set; }
        public string categoryName { get; set; }
        public string? Description { get; set; }
    }

    public class Customers
    {
        public int? customerID { get; set; }
        public string companyName { get; set; }
        public string contactName { get; set; }
        public string contactTitle { get; set; }
        public string Adres { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string postalCode { get; set; }
        public string Country { get; set; }
        public int Phone { get; set; }
        public int? Fax { get; set; }
    }

    public class CustomerCustomerDemo
    {
        public string customerTypeID;
        public string customerID;
    }

    public class CustomerDemographics : CustomerCustomerDemo
    {

    }

    public class Employees
    {
        public int? employeeID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string Title { get; set; }
        public string titleOfCourtesy { get; set; }
        public double birthDate { get; set; }
        public double hireDate { get; set; }
        public string Adres { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string postalCode { get; set; }
        public string Country { get; set; }
        public int homePhonepublic { get; set; }
        public int Extension { get; set; }
        public string Notes { get; set; }
        public int? reportsTo { get; set; }


    }

    public class EmployeeTerritories
    {
        public int? employeeID { get; set; }
        public string territoryID { get; set; }
    }

    public class Orders
    {
        public int? orderID { get; set; }
        public string customerID { get; set; }
        public int? employeeID { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime requiredDate { get; set; }
        public DateTime shippedDate { get; set; }
        public int? shipVia { get; set; }
        public decimal Freight { get; set; }
        //nog niet af
    }
}
