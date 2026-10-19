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

var getAllProductsByUnitPrice = products.Select(p => p).Where(p => p.UnitPrice > 10 && p.UnitPrice < 30);

var getTheUnitInStock =
    from product in products
    where product.Category.Contains("Condiments")
    orderby product.ProductID
    select product;

var anonymousType = products.Select(p => new
{
    Name = p.ProductName,
    Price = p.UnitPrice,
    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
});

var oneBasedNumbers = products.Select((p, index) => $"{index + 1} , {p.ProductName}");

var getProductListWithOrder =
    from product in products
    orderby product.Category, product.UnitPrice descending
    select product;

var descendingUnitinStock =
    from product in products
    where product.Category == "Beverages"
    orderby product.UnitsInStock descending
    select product;


foreach (var product in descendingUnitinStock)
{
    Console.WriteLine($"{product.ProductName} , {product.Category} ,{product.UnitsInStock}");
}