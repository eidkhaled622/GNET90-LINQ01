using LINQ.DataSources;
using LINQ.Models;

var products = Source.ProductList;
var customers = Source.CustomerList;

var getSeaFoodCategory =
    from product in products
    where product.Category == "Seafood"
    select product;

var getOnlyTheProductName = products.Select(Product => Product.ProductName);

var SortByUnitPrice =
    from product in products
    orderby product.UnitPrice
    select product;

foreach (var product in SortByUnitPrice)
{
    Console.WriteLine($"{product.ProductID} , {product.ProductName} , {product.Category} ,{product.UnitPrice} , {product.UnitsInStock}");
}