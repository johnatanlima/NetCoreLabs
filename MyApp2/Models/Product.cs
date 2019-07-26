namespace FinalProject.Models{

    public partial class Product{
        public int Id { get; set; }
        public int TypeId { get; set; } 
        public string Name { get; set; }    
        public double Price {get; set; }

    }

    public partial class Product{
        public ProductType Type {get; set; }
    }
}

