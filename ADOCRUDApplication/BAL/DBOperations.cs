using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ADOCRUDApplication.Models;

namespace DAL
{
    public class DBOperations : IDBOperations
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;

        private string connectionString = "Data Source=LAPTOP-335E2OI0;Initial Catalog=ProductDatabase;Integrated Security=True";

        public IEnumerable<Product> GetProducts()
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("SELECT * FROM ProductTable ", sqlConnection);

                List<Product> products = new List<Product>();

                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    products.Add(new Product
                    {
                        ProductId = Convert.ToInt32(dataReader["ProductId"]),
                        ProductName = Convert.ToString(dataReader["ProductName"]),
                        ProductCategoryID = Convert.ToInt32(dataReader["ProductCategoryID"]),
                        ProductPrice = Convert.ToInt32(dataReader["ProductPrice"]),
                        DateCreated = Convert.ToDateTime(dataReader["DateCreated"])
                    });
                }

                return products;
            }
        }

        public int AddProduct(Product product)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("INSERT INTO ProductTable (ProductID, ProductName, ProductPrice, ProductCategoryID, DateCreated) VALUES (@id, @name, @price, @categoryID, @dateCreated)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@id", product.ProductId);
                sqlCommand.Parameters.AddWithValue("@name", product.ProductName);
                sqlCommand.Parameters.AddWithValue("@price", product.ProductPrice);
                sqlCommand.Parameters.AddWithValue("@categoryID", product.ProductCategoryID);
                sqlCommand.Parameters.AddWithValue("@dateCreated", product.DateCreated);

                var result = sqlCommand.ExecuteNonQuery();

                return result;
            }
        }

        public int UpdateProduct(Product product)
        {
            //using (sqlConnection = new SqlConnection(connectionString))
            //{
            //    sqlConnection.Open();

            //    sqlCommand = new SqlCommand();
            //    sqlCommand.Connection = sqlConnection;
            //    sqlCommand.CommandText = "";
            //    sqlCommand.CommandType = CommandType.StoredProcedure;
            //    sqlCommand.Parameters.AddWithValue("@id", product.ProductId);
            //    var dataReader = sqlCommand.ExecuteReader();
            //    if(dataReader.HasRows)
            //    {

            //    }
            //}
            return 0;
        }

        public int DeleteProduct(int productID)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int productID)
        {
            throw new NotImplementedException();
        }

        
    }
}

