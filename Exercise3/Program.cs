
// Sample data for demonstration purposes
List<Order> orders = new List<Order>
        {
            new Order { OrderId = 1, CustomerId = 101, ProductId = 201 },
            new Order { OrderId = 2, CustomerId = 102, ProductId = 202 },
            new Order { OrderId = 3, CustomerId = 101, ProductId = 203 },
            // Add more orders as needed
        };

List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerId = 101, CustomerName = "John Doe" },
            new Customer { CustomerId = 102, CustomerName = "Jane Smith" },
            // Add more customers as needed
        };

List<Product> products = new List<Product>
        {
            new Product { ProductId = 201, ProductName = "Product A" },
            new Product { ProductId = 202, ProductName = "Product B" },
            new Product { ProductId = 203, ProductName = "Product C" },
            // Add more products as needed
        };

// Perform the double inner join using LINQ
var result = (from order in orders
              join customer in customers on order.CustomerId equals customer.CustomerId
              join product in products on order.ProductId equals product.ProductId
              select new
              {
                  OrderId = order.OrderId,
                  CustomerName = customer.CustomerName,
                  ProductName = product.ProductName
                  // Add other properties as needed
              }).ToDictionary(order => order.OrderId);

// Display the result
foreach (var keyValuePair in result)
{
    Console.WriteLine($"Order ID: {keyValuePair.Key}, Customer Name: {keyValuePair.Value.CustomerName}, Product Name: {keyValuePair.Value.ProductName}");
}


//Entities

// Define the Order, Customer, and Product classes
public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    // Other order-related properties
}

public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    // Other customer-related properties
}

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    // Other product-related properties
}