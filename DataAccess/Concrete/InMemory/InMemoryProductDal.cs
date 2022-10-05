using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List <Product> _products; //global değişkenleri genellikle alt çizgiyle veririz
        private Product? productToDelete;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            { 
             new Product{
                 ProductId=1,
                 CategoryId=1,
                 ProductName="Glass",
                 UnitPrice=15,
                 UnitsInStock=5
             },
                new Product{
                 ProductId=2,
                 CategoryId=2,
                 ProductName="Camera",
                 UnitPrice=15,
                 UnitsInStock=5
             },
                 new Product{
                 ProductId=3,
                 CategoryId=3,
                 ProductName="Telephone",
                 UnitPrice=15,
                 UnitsInStock=1 
             }
            };   
        }
        public void Add(Product product)
        {
          _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ-Language Integrated Query
            Product productToDelete = _products.SingleOrDefault(P=>P.ProductId==product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
          return _products;
        }


        public void Update(Product product)
        {
            //gönderdiğim ürün idsine sağip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(P => P.ProductId == product.ProductId);
            productToUpdate.ProductName= product.ProductName;
            productToUpdate.UnitPrice= product.UnitPrice;
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.CategoryId = product.CategoryId;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
