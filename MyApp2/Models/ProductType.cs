using System.Collections.Generic;

namespace FinalProject.Models{
    public partial class ProductType{

        public int Id { get; set; } 
        public string Name { get; set; }
    }

    public partial class ProductType {
        public IList<Product> Products {get; } = new List<Product>();
        public bool CanBeRemoved {get => Products.Count == 0; }
    }

}