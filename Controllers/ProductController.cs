using Microsoft.AspNetCore.Mvc;

namespace hello_ecs.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private static readonly Product[] Products = new[]
    {
       new Product { SKU = "001", Name = "Widget", Description = "Widget, standard", Price = 1.00M },
       new Product { SKU = "002", Name = "Blivet", Description = "Blivet, standard", Price = 1.50M },
       new Product { SKU = "003", Name = "Blivet LH", Description = "Blivet, left-handed", Price = 2.50M },
       new Product { SKU = "004", Name = "Sprocket", Description = "Sprocket, standard", Price = 37.00M },
       new Product { SKU = "005", Name = "Sprocket Max", Description = "Sprocket, extra large", Price = 54.00M }
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public ProductController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("catalog")]
    public Product[] Get()
    {
        return Products;
    }
}

public class Product
{
    public string SKU { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Decimal Price { get; set; }
}
