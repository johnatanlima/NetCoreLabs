using System.Linq;
using System.Collections.Generic;

namespace FinalProject.Models {
    public class DataSource {
        private static IDictionary<int, ProductType> _productTypes;
        private static IDictionary<int, Product> _products;

        static DataSource() {
            _productTypes = new Dictionary<int, ProductType>();
            _products = new Dictionary<int, Product>();

            _productTypes.Add(1, new ProductType { ID = 1, Name = "Book" });
            _productTypes.Add(2, new ProductType { ID = 2, Name = "Fruit" });

            _products.Add(1, new Product { ID = 1, Name = "Learning C#", TypeID = 1, Price = 9.99 });
            _products.Add(2, new Product { ID = 2, Name = "Learning Java", TypeID = 1, Price = 9.99 });
            _products.Add(3, new Product { ID = 3, Name = "Learning Python", TypeID = 1, Price = 9.99 });
            _products.Add(4, new Product { ID = 4, Name = "Apple", TypeID = 2, Price = 0.99 });
            _products.Add(5, new Product { ID = 5, Name = "Banana", TypeID = 2, Price = 0.99 });
            _products.Add(6, new Product { ID = 6, Name = "Orange", TypeID = 2, Price = 0.99 });
        }

        public static IList<Product> GetProducts() {
            var result = _products.Values.ToList();
            result.ForEach(p => p.Type = _productTypes[p.TypeID]);
            return result;
        }

        public static Product GetProductByID(int id) {
            if (_products.ContainsKey(id)) {
                var result = _products[id];
                result.Type = _productTypes[result.TypeID];
                return result;
            }
            return null;
        }

        public static IList<Product> GetProductsByTypeID(int typeID) {
            var result = new List<Product>();
            if (_productTypes.ContainsKey(typeID)) {
                result = _products.Values.Where(p => p.TypeID == typeID).ToList();
                result.ForEach(p => p.Type = _productTypes[typeID]);
            }

            return result;
        }

        public static Product AddProduct(Product product) {
            product.ID = _products.Keys.Max() + 1;
            _products.Add(product.ID, product);
            return product;
        }

        public static bool UpdateProductByID(int id, Product product) {
            if (_products.ContainsKey(id)) {
                _products[id] = product;
                return true;
            }

            return false;
        }

        public static bool RemoveProductByID(int id) {
            if (_products.ContainsKey(id)) {
                _products.Remove(id);
                return true;
            }

            return false;
        }

        public static IList<ProductType> GetProductTypes() {
            var result = _productTypes.Values.ToList();
            foreach (var t in result) {
                var products = GetProductsByTypeID(t.ID);
                t.Products.Clear();
                foreach (var p in products) {
                    t.Products.Add(p);
                }
            }
            return result;
        }

        public static ProductType GetProductTypeByID(int id) {
            if (_productTypes.ContainsKey(id)) {
                var result = _productTypes[id];
                var products = GetProductsByTypeID(result.ID);
                result.Products.Clear();
                foreach (var p in products) {
                    result.Products.Add(p);
                }

                return result;
            }
            return null;
        }

        public static ProductType AddProductType(ProductType type) {
            type.ID = _productTypes.Keys.Max() + 1;
            _productTypes.Add(type.ID, type);
            return type;
        }

        public static bool UpdateProductTypeByID(int id, ProductType type) {
            if (_productTypes.ContainsKey(id)) {
                _productTypes[id] = type;
                return true;
            }

            return false;
        }

        public static bool RemoveProductTypeByID(int id) {
            if (_productTypes.ContainsKey(id)) {
                _productTypes.Remove(id);
                return true;
            }

            return false;
        }
    }
}