using LINQ.DataSources;
using LINQ.Models;

var products = Source.ProductList;
var customers = Source.CustomerList;

var getSeaFoodCategory =
    from product in products
    where product.Category == "Seafood"
    select product;

var getOnlyTheProductName = products.Select(Product => Product.ProductName);

foreach (var name in getOnlyTheProductName)
{
    Console.WriteLine($"{name}");
}