using System;
using System.Collections.Generic;
using System.Text;
using ADOCRUDApplication.Models;

namespace DAL
{
    public interface IDBOperations
    {
        /// <summary>
        /// This method is used to get all products
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> GetProducts();

        /// <summary>
        /// This method is used to add a product
        /// </summary>
        /// <param name="product">Product Object</param>
        /// <returns>Number of Rows Affected</returns>
        int AddProduct(Product product);

        /// <summary>
        /// This method is used to update a product
        /// </summary>
        /// <param name="product">Product Object</param>
        /// <returns>Number of Rows Affected</returns>
        int UpdateProduct(Product product);

        /// <summary>
        /// This method is used to get a product by its product ID
        /// </summary>
        /// <param name="productID">Product ID</param>
        /// <returns>Employee Object</returns>
        Product GetProduct(int productID);       

        /// <summary>
        /// This method is used to delete a product by its product ID
        /// </summary>
        /// <param name="productID">Product ID</param>
        /// <returns>Number of rows affected</returns>
        int DeleteProduct(int productID);       
    }
}
