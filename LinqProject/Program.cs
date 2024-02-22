
using LinqProject;

List<Category> categories = new List<Category>
{
    new Category{CategoryId=1, CategoryName="Bilgisayar"},
    new Category{CategoryId=2, CategoryName="Telefon"}
};

List<Product> products = new List<Product>
{
    new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",ProductPrice=10000,UnitsInStock=5},
     new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",ProductPrice=8000,UnitsInStock=3},
    new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",ProductPrice=6000,UnitsInStock=2},
     new Product{ProductId=4,CategoryId=1,ProductName="Samsung Laptop",ProductPrice=5000,UnitsInStock=15},
     new Product{ProductId=5,CategoryId=1,ProductName="Apple Laptop",ProductPrice=8000,UnitsInStock=0}

};


var result = products.Where(p => p.ProductPrice > 5000 && p.UnitsInStock > 3);

foreach (var product in result)
{
    Console.WriteLine(product.ProductName);
}

GetProducts(products);
static List<Product> GetProducts(List<Product> products)
{
    List<Product> filtredProducts = new List<Product>();
    foreach (var product in products)
    {
        if (product.ProductPrice > 5000 && product.UnitsInStock > 3)
        {
            filtredProducts.Add(product);
        }
        

    }
    return filtredProducts;
}
GetProductsLinq(products);

static List<Product> GetProductsLinq(List<Product> products)
{

    //where döngüde if de oluşturuyor.
    return products.Where(p => p.ProductPrice > 5000 && p.UnitsInStock > 3).ToList();
  
}