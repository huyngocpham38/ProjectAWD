using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WADproject.Models
{
    public class Category
    {
        private int categoryId;
        private string categoryName;
        private string description;
        private string picture;

        public virtual Product Product { get; set; }

        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string Description { get => description; set => description = value; }
        public string Picture { get => picture; set => picture = value; }
    }
}
