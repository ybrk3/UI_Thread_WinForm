
List<Transaction> transactions = new List<Transaction>()
{
    new Transaction { Id = 1, ProductName = "Item1", Amount = 100, TransactionDate = new DateTime(2022, 5, 12) },
    new Transaction { Id = 2, ProductName = "Item2", Amount = 150, TransactionDate = new DateTime(2023, 2, 2) },
    new Transaction { Id = 3, ProductName = "Item3", Amount = 200, TransactionDate = new DateTime(2022, 7, 8) },
    new Transaction { Id = 4, ProductName = "Item4", Amount = 75, TransactionDate = new DateTime(2023, 9, 18) },
};

var list = transactions.GroupBy(t => t.TransactionDate.Year).Select(t => new { Year = t.Key, TotalAmount = t.Sum(a => a.Amount) }).ToDictionary(t => t.Year);
foreach (var transaction in list)
    if(list.TryGetValue(transaction.Key, out var result)) Console.WriteLine($"{transaction.Key} {result.TotalAmount}");





List<string> words = new List<string> { "listen", "silent", "enlist", "hello", "world", "hit", "ihit" };

var anagramGroups = words
            .GroupBy(w => new string(w.OrderBy(c => c).ToArray()))
            .Where(g => g.Count() >1)
            .Select(g => g.ToList())
            .ToList();
foreach (var group in anagramGroups)
{
    Console.WriteLine("[" + string.Join(", ", group) + "]");
}
Console.WriteLine();



var orders = new List<Order>();
var orderItems = new List< Order>();




var fibonacciSequence = Enumerable.Range(0, 50)
    .Aggregate(new { current = 0, next = 1, sequence = new List<int>() },
        (acc, _) => new
        {
            current = acc.next,
            next = acc.current + acc.next,
            sequence = acc.sequence.Append(acc.current).ToList()
        })
    .sequence;
Console.WriteLine(fibonacciSequence);

#region Objects
class Transaction
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public double Amount { get; set; }
    public DateTime TransactionDate { get; set; }
}


public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public List<OrderItem> Items { get; set; }
}

public class OrderItem
{
    public int ItemId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

#endregion