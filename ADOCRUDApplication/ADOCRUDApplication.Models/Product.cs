using System;

namespace ADOCRUDApplication.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductCategoryID { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
