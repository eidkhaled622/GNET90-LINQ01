using LINQ.DataSources;

var products = Source.ProductList;
var customers = Source.CustomerList;

var getSeaFoodCategory =
    from product in products
    where product.Category == "Seafood"
    select product;


foreach (var product in getSeaFoodCategory)
{
    Console.WriteLine($"{product.ProductID} , {product.ProductName} , {product.Category} , {product.UnitPrice} , {product.UnitsInStock}");
}