using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WADproject.Models
{
    public class Product
    {
        private int productId;

        private string productName;

        private int supplierId;

        private int categoryId;

        private string quantityPerUnit;

        private string unitPrice;

        private string unitsInStock;

        private string unitsOnOrder;

        private string reorderLevel;

        private string discontinued;

        public virtual Category Categories { get; set; }

        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string QuantityPerUnit { get => quantityPerUnit; set => quantityPerUnit = value; }
        public string UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string UnitsInStock { get => unitsInStock; set => unitsInStock = value; }
        public string UnitsOnOrder { get => unitsOnOrder; set => unitsOnOrder = value; }
        public string ReorderLevel { get => reorderLevel; set => reorderLevel = value; }
        public string Discontinued { get => discontinued; set => discontinued = value; }
    }
}
