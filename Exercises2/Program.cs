
#region Exercise #1

//Data Set
List<Student> students = new List<Student>
{
    new Student { StudentId = 1, Name = "Alice", Grades = new List<int> { 85, 90, 78 } },
    new Student { StudentId = 2, Name = "Bob", Grades = new List<int> { 95, 88, 92 } },
    new Student { StudentId = 3, Name = "Charlie", Grades = new List<int> { 78, 86, 80 } }
};

List<Course> courses = new List<Course>
{
    new Course { CourseId = 101, Name = "Math", Credits = 4 },
    new Course { CourseId = 102, Name = "Science", Credits = 3 },
    new Course { CourseId = 103, Name = "History", Credits = 3 }
};

List<Enrollment> enrollments = new List<Enrollment>
{
    new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 101 },
    new Enrollment { EnrollmentId = 2, StudentId = 1, CourseId = 102 },
    new Enrollment { EnrollmentId = 3, StudentId = 2, CourseId = 101 },
    new Enrollment { EnrollmentId = 4, StudentId = 2, CourseId = 103 },
    new Enrollment { EnrollmentId = 5, StudentId = 3, CourseId = 102 }
};

//Exercise 1.1: Find the names of students who scored more than 85 in all their courses.
var studentsWithHighGrade = students
    .Where(student => student.Grades.All(g => g > 85))
    .Select(student => new { student.StudentId, student.Name })
    .ToDictionary(s => s.StudentId);
foreach (var student in studentsWithHighGrade)
    Console.WriteLine(student.Value.Name);


//Exercise 1.2: Find the average grade of each student.
var studentsAverageGrade = students
    .Select(student => new
    {
        StudentId = student.StudentId,
        StudentName = student.Name,
        AverageGrade = student.Grades.Average(g => g)
    }).ToDictionary(s => s.StudentId);
foreach (var kvp in studentsAverageGrade)
{
    Console.WriteLine($"{kvp.Value.StudentName} with average grade of {String.Format("{0:0.##}", kvp.Value.AverageGrade)}");
}


//Exercise 3: Find the courses that have at least one student with a grade lower than 80.
var coursesWithLowGrades = courses
    .Where(course => enrollments
            .Any(enrollment => enrollment.CourseId == course.CourseId &&
                        students.Any(student => student.StudentId == enrollment.StudentId &&
                                                student.Grades.Any(grade => grade > 80))))
    .ToDictionary(c => c.CourseId);

//Exercise 4: Find the students who are enrolled in more than two courses.
var studentsWithEnrolledMultipleCourses = students
    .Where(student => enrollments.Where(e => e.StudentId == student.StudentId).Count() > 1).ToList();

//Exercise 5: Find the course names along with the total number of students enrolled in each course.
var coursesWithStudents = courses
    .Select(course => new
    {
        CourseId = course.CourseId,
        CourseName = course.Name,
        EnrollmentCount = enrollments.Count(enrollment => enrollment.CourseId == course.CourseId),
    })
    .ToDictionary(c => c.CourseId);

if (coursesWithStudents.TryGetValue(101, out var course))
    Console.WriteLine($"{course.EnrollmentCount} students enrolled to {course.CourseName}");


//Exercise 6: Find the students who are not enrolled in any course.
var studentsNotEnrolled = students
    .Where(student => !enrollments.Any(enrollment => enrollment.StudentId == student.StudentId))
    .ToDictionary(student => student.StudentId);
if (studentsNotEnrolled.Count() == 0) Console.WriteLine("All students are enrolled courses");


//Exercise 7: Find the courses with the highest average grade among all students.

/* Gets the courseId with highest average grade */
var courseIdWithHighestAvgGrade = enrollments
    .GroupBy(enrollment => enrollment.CourseId)
    .Select(groupByCourseId => new
    {
        CourseId = groupByCourseId.Key,
        AverageGradeOfStudents = groupByCourseId.Average(elementOfGroup => students
                                                         .First(student => student.StudentId == elementOfGroup.StudentId)
                                                         .Grades
                                                         .Average())
    })
    .OrderByDescending(courseGroup => courseGroup.AverageGradeOfStudents)
    .FirstOrDefault();


/* Gets the course name of above course id */
string? courseNameOfHighestAvgGrade = courses
    .FirstOrDefault(course => course.CourseId == courseIdWithHighestAvgGrade?.CourseId)?.Name;


//Exercise 8: Find the students who are enrolled in "Math" and "Science" courses.
var studentsEnrolledToMathAndScience = students
    .Where(student => enrollments.Any(enrollment => enrollment.StudentId == student.StudentId && (courses.Any(course => course.CourseId == enrollment.CourseId && course.Name == "Math" || course.Name == "Science"))));




#endregion

#region Exercise #2
//Data Set
List<Employee> employees = new List<Employee>
{
    new Employee { EmployeeId = 1, Name = "John", Age = 30, Salary = 50000, Department = "IT" },
    new Employee { EmployeeId = 2, Name = "Alice", Age = 25, Salary = 45000, Department = "HR" },
    new Employee { EmployeeId = 3, Name = "Bob", Age = 28, Salary = 55000, Department = "Finance" },
    new Employee { EmployeeId = 4, Name = "Tom", Age = 26, Salary = 30000, Department = "Finance" },
    new Employee { EmployeeId = 5, Name = "Modric", Age = 34, Salary = 60000, Department = "IT" },
};

List<Product> products = new List<Product>
{
    new Product { ProductId = 101, Name = "Laptop", Price = 1000, StockQuantity = 50 },
    new Product { ProductId = 102, Name = "Phone", Price = 500, StockQuantity = 100 },
    new Product { ProductId = 103, Name = "Tablet", Price = 300, StockQuantity = 80 }
};

List<Order> orders = new List<Order>
{
    new Order { OrderId = 1, ProductId = 101, Quantity = 2 },
    new Order { OrderId = 2, ProductId = 102, Quantity = 5 },
    new Order { OrderId = 3, ProductId = 101, Quantity = 3 },
    new Order { OrderId = 4, ProductId = 103, Quantity = 1 },
    new Order { OrderId = 5, ProductId = 101, Quantity = 4 },
    new Order { OrderId = 6, ProductId = 102, Quantity = 2 }
};

//Exercise 1: Find the employees who are older than 25 and earn a salary greater than $50,000.
var employessOlderAndEarned = employees
    .Where(employee => employee.Age > 25 && employee.Salary > 50000)
    .ToList();

//Exercise 2: Find the products with less than 10 items in stock.
var productWithStockLessThan10 = products
    .Where(p => p.StockQuantity < 10)
    .ToDictionary(p => p.ProductId);

//Exercise 3: Find the employees with the highest salary in each department.
var employessWithHighestSalaries = employees
    .GroupBy(e => e.Department)
    .Select(group => group.Max(e => e.Salary))
    .ToList();

//Exercise 4: Find the average age of employees in each department.
var avgAgesAsPerDepart = employees
    .GroupBy(e => e.Department)
    .Select(g => new
    {
        DepartmentName = g.Key,
        AverageAge = g.Average(e => e.Age),
    })
    .ToDictionary(e => e.DepartmentName);

//Exercise 5: Find the total price of all orders for each product.
var productsWithTotalOrderPrice = orders
    .GroupBy(o => o.ProductId)
    .Select(g => new
    {
        ProductName = products.First(p => p.ProductId == g.Key).Name,
        TotalPriceOfOrders = g.Sum(o => o.Quantity * products.First(p => p.ProductId == g.Key).Price)
    })
    .ToDictionary(p => p.ProductName);

//Exercise 6: Find the products that have been ordered at least once.
var productsOrdered = products
    .Where(p => orders.Any(o => o.ProductId == p.ProductId)).ToDictionary(p => p.ProductId);

//Exercise 8: Find the products that have the highest total order quantity.
var ordersWithTotalOrderQty = orders
    .GroupBy(o => o.ProductId)
    .Select(g => new
    {
        ProductId = g.Key,
        ProductName = products.First(p => p.ProductId == g.Key).Name,
        TotalOrderQty = g.Sum(o => o.Quantity)
    }).ToDictionary(p => p.ProductId);
#endregion

#region Exercise #3
//Data Set
List<Employee3> employees3 = new List<Employee3>
{
    new Employee3 { EmployeeId = 1, FirstName = "John", LastName = "Doe", Age = 30, Salary = 65000, Department = "IT", Skills = new List<string> { "C#", "SQL", "ASP.NET" } },
    new Employee3 { EmployeeId = 2, FirstName = "Alice", LastName = "Smith", Age = 28, Salary = 55000, Department = "HR", Skills = new List<string> { "Communication", "Recruitment" } },
    new Employee3 { EmployeeId = 3, FirstName = "Bob", LastName = "Johnson", Age = 35, Salary = 75000, Department = "Finance", Skills = new List<string> { "Financial Analysis", "Excel" } }
};

List<Product3> products3 = new List<Product3>
{
    new Product3 { ProductId = 101, Name = "Laptop", Price = 1200, StockQuantity = 50, Categories = new List<string> { "Electronics", "Computers" } },
    new Product3 { ProductId = 102, Name = "Phone", Price = 800, StockQuantity = 100, Categories = new List<string> { "Electronics", "Mobile" } },
    new Product3 { ProductId = 103, Name = "Tablet", Price = 500, StockQuantity = 80, Categories = new List<string> { "Electronics", "Computers" } }
};

List<Order3> orders3 = new List<Order3>
{
    new Order3 { OrderId = 1, ProductId = 101, Quantity = 2, CustomerName = "David Johnson" },
    new Order3 { OrderId = 2, ProductId = 102, Quantity = 5, CustomerName = "Mary Smith" },
    new Order3 { OrderId = 3, ProductId = 101, Quantity = 3, CustomerName = "John Doe" },
    new Order3 { OrderId = 4, ProductId = 103, Quantity = 1, CustomerName = "Alice Johnson" },
    new Order3 { OrderId = 5, ProductId = 101, Quantity = 4, CustomerName = "Robert Smith" },
    new Order3 { OrderId = 6, ProductId = 102, Quantity = 5, CustomerName = "John Doe" }
};

//Exercise 1: Find the employees who have skills in both "C#" and "SQL".
var employeesWithSpecificTalent = employees3
    .Where(e => e.Skills.Contains("C#") && e.Skills.Contains("SQL"))
    .ToDictionary(e => e.EmployeeId);

//Exercise 2: Find the products that belong to both "Electronics" and "Computers" categories.
var productsWithSpecCategory = products3
    .Where(p => p.Categories.Contains("Electronics") && p.Categories.Contains("Computers"))
    .ToDictionary(p => p.ProductId);


//Exercise 3: Find the department with the highest average salary of its employees.
var departmentWithHighestSalary = employees3
    .GroupBy(e => e.Department)
    .Select(g => new
    {
        DepartmentName = g.Key,
        AvgSalary = g.Average(e => e.Salary),
    })
    .OrderByDescending(d => d.AvgSalary)
    .First();

//Exercise 4: Find the employees who have ordered the most expensive product (based on order total amount).
var employeeWithMostExpensiveOrder = employees3
    .Where(e => orders3
               .Any(o => o.CustomerName == $"{e.FirstName} {e.LastName}"))
    .OrderByDescending(e => orders3
                .Where(o => o.CustomerName == $"{e.FirstName} {e.LastName}")
                .Sum(o => products3
                    .Where(p => p.ProductId == o.ProductId)
                    .Sum(p => p.Price * o.Quantity)))
    .FirstOrDefault();

//Exercise 5: Find the average salary of employees who have ordered at least one product.
var avgSalaryOfActiveEmployees = employees3
    .Where(e => orders3
        .Any(o => o.CustomerName == $"{e.FirstName} {e.LastName}"))
    .Average(e => e.Salary);

//Exercise 6: Find the top 3 most frequently ordered products along with the total quantity sold.
var most3ProductsOrdered = orders3
    .GroupBy(o => o.ProductId)
    .OrderByDescending(g => g.Sum(o => o.Quantity))
    .Take(3)
    .ToList();

//Exercise 7: Find the employees who have all the skills required by a specific project (provided as a list of required skills).
List<string> requiredSkillsForProject = new List<string> { "C#", "ASP.NET" };

var employeesWithRequiredSkilss = employees3
    .Where(e => requiredSkillsForProject.All(requiredSkill => e.Skills.Contains(requiredSkill)))
    .ToList();

//Exercise 8: Find the employees who have placed at least two orders with a total quantity greater than 5.
var employeesWithAtLeastTwoOrders = employees3
    .Where(e => orders3
                    .Where(o => o.CustomerName == $"{e.FirstName} {e.LastName}")
                    .GroupBy(o => o.CustomerName)
                    .Any(o => o.Sum(o => o.Quantity) > 5))
    .ToList();

#endregion

#region Exercise #4
//Data Set
List<Project4> projects4 = new List<Project4>
{
    new Project4 { ProjectId = 1, Name = "Web Application", RequiredSkills = new List<string> { "C#", "ASP.NET", "JavaScript", "HTML", "CSS" } },
    new Project4 { ProjectId = 2, Name = "Data Analysis", RequiredSkills = new List<string> { "Python", "SQL", "Statistics", "Machine Learning" } },
    new Project4 { ProjectId = 3, Name = "Mobile App", RequiredSkills = new List<string> { "C#", "Xamarin", "Mobile Development" } }
};

List<Department4> departments4 = new List<Department4>
{
    new Department4 { Name = "IT", EmployeeIds = new List<int> { 1, 2, 4 } },
    new Department4 { Name = "HR", EmployeeIds = new List<int> { 3, 5, 6 } },
    new Department4 { Name = "Finance", EmployeeIds = new List<int> { 7, 8, 9 } }
};
List<Employee3> employees4 = new List<Employee3>
{
    new Employee3 { EmployeeId = 1, FirstName = "John", LastName = "Doe", Age = 30, Salary = 65000, Department = "IT", Skills = new List<string> { "C#", "SQL", "ASP.NET", "JavaScript", "HTML", "CSS" } },
    new Employee3 { EmployeeId = 2, FirstName = "Alice", LastName = "Smith", Age = 28, Salary = 55000, Department = "HR", Skills = new List<string> { "Communication", "Recruitment" } },
    new Employee3 { EmployeeId = 3, FirstName = "Bob", LastName = "Johnson", Age = 35, Salary = 75000, Department = "Finance", Skills = new List<string> { "Financial Analysis", "Excel" } }
};


//Exercise 9: Find the employees who have worked on all the required skills for the "Web Application" project.


#endregion

Console.WriteLine();

#region Objects
public class Employee4
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
    public List<string> Skills { get; set; }
}

public class Product4
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public List<string> Categories { get; set; }
}

public class Order4
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public string CustomerName { get; set; }
}

public class Project4
{
    public int ProjectId { get; set; }
    public string Name { get; set; }
    public List<string> RequiredSkills { get; set; }
}

public class Department4
{
    public string Name { get; set; }
    public List<int> EmployeeIds { get; set; }
}

public class Employee3
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
    public List<string> Skills { get; set; }
}

public class Product3
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public List<string> Categories { get; set; }
}

public class Order3
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public string CustomerName { get; set; }
}




public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
}

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public List<int> Grades { get; set; }
}

public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public int Credits { get; set; }
}

public class Enrollment
{
    public int EnrollmentId { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
}

#endregion