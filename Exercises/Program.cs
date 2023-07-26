using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Channels;

//HashSet<int> numbers = new HashSet<int>() { 78, -9, 0, 23, 54, 21, 7, 67, 45, 677, 876, 5456, 35523, 4634, 453234, 111 };
//numbers.OrderByDescending(x => x).Take(5).ToList().ForEach(n => Console.WriteLine(n));


//HashSet<string> words = new HashSet<string>() { "learn", "current", "deal" };
//words.Select(w => w.Contains("ea") ? w.Replace("ea", "*") : w).ToList().ForEach(n => Console.WriteLine(n));

//string word = "panda";
//char l = word.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
//Console.WriteLine(l);

//List<string> letters = new List<string>() { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" };
//letters.GroupBy(x => x)
//    .Where(x => x.Count() == 1)
//    .Select(x => x.Key)
//    .ToList().ForEach(x => Console.WriteLine(x));

//string sentence = "DDD example CQRS Event Sourcing";

//sentence.Split(" ")
//    .Where(word => string.Equals(word, word.ToUpper()))
//    .ToList<string>().ForEach(w => Console.WriteLine(w));

//int[] arr1 = new int[4] { 7, -9, 3, -5 };
//int[] arr2 = new int[5] { 9, 1, 0, -4, 5 };
//if (arr1.Length == arr2.Length) arr1.Zip(arr2, (value1, value2) => value1 * value2).ToList().ForEach(n => Console.WriteLine(n));
//else Console.WriteLine("Total number of elements in arrays must be equal to calculate dot product");


//var results = numbers.Where(x => x > 30).Select(n => n / 3).ToDictionary(x => x);
//Stopwatch stopwatch = Stopwatch.StartNew();
//foreach (var keyValuePair in results) Console.WriteLine(keyValuePair);
//stopwatch.Stop();
//Console.WriteLine(stopwatch.ElapsedMilliseconds);


///*--------------------------TryGetValue------------------------------------*/
//stopwatch.Restart();
//BenchToDictioanryTryGetvalue();
//stopwatch.Stop();
//Console.WriteLine(stopwatch.ElapsedMilliseconds);
//List<int> BenchToListTuple()
//{
//    List<(string key, int value)> list = new List<(string, int)>();
//    for (int i = 1; i < 20000; i++)
//    {
//        list.Add(($"{i}_Bora", 5345 + i));
//        list.Add(($"{i}_Mehmet", 6666 + i));
//    }
//    Random random = new Random();
//    List<int> customerIDList = new List<int>();
//    for (int i2 = 0; i2 < 100; i2++)
//    {
//        int randomNumber = random.Next(0, 20000);
//        var item = list.FirstOrDefault(item => item.key == $"{randomNumber}_Bora");
//        var item2 = list.FirstOrDefault(item => item.key == $"{randomNumber}_Mehmet");
//        customerIDList.Add(item.value);
//        customerIDList.Add(item2.value);
//    }
//    return customerIDList;
//}
//List<int> BenchToDictionary()
//{
//    Dictionary<string, int> list = new Dictionary<string, int>();
//    for (int i = 1; i < 20000; i++)
//    {
//        list.Add($"{i}_Bora", 5345 + i);
//        list.Add($"{i}_Mehmet", 6666 + i);
//    }
//    Random random = new Random();
//    List<int> customerIDList = new List<int>();
//    for (int i2 = 0; i2 < 100; i2++)
//    {
//        int randomNumber = random.Next(0, 20000);
//        var item = list.Any(x => x.Key.Equals($"{randomNumber}_Bora")) ? list[$"{randomNumber}_Bora"] : 0;
//        var item2 = list.Any(x => x.Key.Equals($"{randomNumber}_Mehmet")) ? list[$"{randomNumber}_Mehmet"] : 0;
//        customerIDList.Add(item);
//        customerIDList.Add(item2);
//    }
//    return customerIDList;
//}
//List<int> BenchToDictioanryTryGetvalue()
//{
//    Dictionary<string, int> list = new Dictionary<string, int>();
//    for (int i = 1; i < 20000; i++)
//    {
//        list.Add($"{i}_Bora", 5345 + i);
//        list.Add($"{i}_Mehmet", 6666 + i);
//    }
//    Random random = new Random();
//    List<int> customerIDList = new List<int>();
//    for (int i2 = 0; i2 < 100; i2++)
//    {
//        int randomNumber = random.Next(0, 20000);
//        var item = list.TryGetValue($"{randomNumber}_Bora", out int value);
//        var item2 = list.TryGetValue($"{randomNumber}_Mehmet", out int value2);
//        customerIDList.Add(item ? value : 0);
//        customerIDList.Add(item2 ? value2 : 0);

//    }
//    return customerIDList;
//}
///*-------------------------------------------------------------------------*/


//var people = new List<Person>
//{
//    new Person { Name = "Alice", Age = 30 },
//    new Person { Name = "Bob" },

//};
//people.Where(p => p.Age is not null).ToList().ForEach(p => Console.WriteLine(p.Name));

Stopwatch stopwatch = Stopwatch.StartNew();
var dictPersons1 = new Dictionary<int, Person>();
//for (int i = 0; i < 1000000; i++)
//    dictPersons1.Add(i, new Person()
//    {
//        Id = i,
//        Name = string.Join("", i, ". Burak"),
//        Age = 30 + i,
//    });
//stopwatch.Stop();
//Console.WriteLine(stopwatch.ElapsedMilliseconds);



//stopwatch.Start();
//var result2 = dictPersons1[999999];
//stopwatch.Stop();
//Console.WriteLine(stopwatch.ElapsedMilliseconds);


//HashSet<int> list = new HashSet<int>()
//{
//    1,2, 3, 4,1, 5, 6, 7,
//};
//var result = list.TryGetValue(1, out int value);
//if (result) Console.WriteLine("Data Found!");
List<int> numbers = new List<int> { 12, 65, 34, 89, 100, 45, 78, 23, 56 };
var quantity = numbers.Where(n => n > 50 && n < 100).Count();
Console.WriteLine(quantity);
List<string> words = new List<string> { "Apple", "Banana", "Ant", "Car", "Art", "Ape" };
words.Where(w => w.StartsWith("A") && w.Length == 3).ToList().ForEach(w => Console.WriteLine(w));

var people = new List<Person>()
{
            new Person("Bill", "Smith", 41),
            new Person("Sarah", "Jones", 22),
            new Person("Stacy","Baker", 21),
            new Person("Vivianne","Dexter", 19 ),
            new Person("Bob","Smith", 49 ),
            new Person("Brett","Baker", 51 ),
            new Person("Mark","Parker", 19),
            new Person("Alice","Thompson", 18),
            new Person("Evelyn","Thompson", 58 ),
            new Person("Mort","Martin", 58),
            new Person("Eugene","deLauter", 84 ),
            new Person("Gail","Dawson", 19 ),
};

var people1 = people.Where(p => p.LastName.StartsWith("D"));
Console.WriteLine("Number of people who's last name starts with the letter D " + people1.Count());
var people2 = people.OrderByDescending(p => p.FirstName).LastOrDefault(p => p.Age > 40).FirstName;
Console.WriteLine(people2);


List<int> numbers2 = new List<int> { 12, 65, 34, 89, 100, 45, 78, 23, 56 };
int sum = numbers2.Sum(p => p);
Console.WriteLine(sum);
List<string> words2 = new List<string> { "Apple", "Banana", "Ant", "Car", "Art", "Ape" };
IOrderedEnumerable<string> word = words2.OrderBy(w => w.Length);
Console.WriteLine(word.First());
Console.WriteLine(word.Last());


List<string> words3 = new List<string> { "apple", "banana", "orange", "grape" };
words3.Select(w => w.ToUpper()).ToList().ForEach(w => Console.WriteLine(w));

List<int> numbers3 = new List<int> { 12, 65, 34, 89, 100, 45, 78, 23, 56 };
var average = numbers3.Average();
Console.WriteLine($"Average: {((decimal)average)}");

List<string> fruits = new List<string> { "banana", "orange", "grape", "apple", "mango" };
bool isExist = fruits.Contains("apple");
Console.WriteLine(isExist);

List<int> numbers4 = new List<int> { 1, 2, 3, 4, 5 };
numbers4.Select(n => n * n).ToList().ForEach(n => Console.WriteLine(n));

List<string> words23 = new List<string> { "apple", "banana", "orange", "grape", "mango" };
int howManyE = words23.Where(w => w.Contains("e")).Count();
Console.WriteLine(howManyE);

List<Product> products = new List<Product>
{
    new Product { Name = "Laptop", Price = 999.99 },
    new Product { Name = "Phone", Price = 599.95 },
    new Product { Name = "Headphones", Price = 79.99 },
    new Product { Name = "Tablet", Price = 349.50 },
    new Product { Name = "Mouse", Price = 19.99 }
};
products.OrderBy(p => p.Price).ToList().ForEach(p => Console.WriteLine(p.Name));



#region Dictionary
List<Employee> employees = new List<Employee>
{
    new Employee { Id = 1, Name = "John", Age = 30, Salary = 50000, DepartmentId = 1 },
    new Employee { Id = 2, Name = "Alice", Age = 25, Salary = 60000, DepartmentId = 1 },
    new Employee { Id = 3, Name = "Bob", Age = 35, Salary = 70000, DepartmentId = 2 },
    new Employee { Id = 4, Name = "Mary", Age = 28, Salary = 55000, DepartmentId = 2 },
};

List<Department> departments = new List<Department>
{
    new Department { Id = 1, Name = "HR" },
    new Department { Id = 2, Name = "Finance" },
};

var query = employees.GroupBy(e => e.DepartmentId).Select(emp => new
{
    DepartmentName = departments[emp.Key - 1].Name,
    AverageSalary = emp.Average(e => e.Salary),
}).ToDictionary(x => x.DepartmentName);

foreach (var department in departments)
{
    if (query.TryGetValue(department.Name, out var result))
        Console.WriteLine($"{result?.DepartmentName} {result?.AverageSalary}");
    else Console.WriteLine("Department Not Found");
}
List<int> numbers22222 = new List<int> { 4,2, 7, 15, 13, 8, 17, 4, 23, 12 };

bool IsPrime(int number)
{
    if (number < 2) return false;

    for (int i = 2; i * i <= number; i++)
    {
        if (number % i == 0) return false;
    }

    return true;
}
numbers22222.Where(n=> IsPrime(n)).ToList().ForEach(x => Console.WriteLine(x));

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
    public int DepartmentId { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
}
#endregion

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Person
{
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    //override ToString to return the person's FirstName LastName Age
    public override string ToString()
    {
        return FirstName;
    }
}





