<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Sam", JobTitle = "IT", Salary = 60000, Age = 24 },
                new Employee { Id = 2, Name = "John", JobTitle = "HR", Salary = 45000, Age = 30 },
                new Employee { Id = 3, Name = "David", JobTitle = "IT", Salary = 75000, Age = 28 },
                new Employee { Id = 4, Name = "Saran", JobTitle = "Finance", Salary = 50000, Age = 26 },
                new Employee { Id = 5, Name = "Mike", JobTitle = "IT", Salary = 80000, Age = 15 },
                new Employee { Id = 6, Name = "Sam", JobTitle = "HR", Salary = 10, Age = 23 },

            };

            List<JobSection> jobSections = new List<JobSection>
            {
                new JobSection{EmployeeId = 1, JobDescription = "Software"},
                new JobSection{EmployeeId = 2, JobDescription = "Manager"},
                new JobSection{EmployeeId = 3, JobDescription = "Software"},
                new JobSection{EmployeeId = 4, JobDescription = "Finance Management"},
                new JobSection{EmployeeId = 5, JobDescription = "Software"}, 
            };

            List<Student> students = new List<Student>
            {
                new Student{ StudentName = "Alice", CourseId = 1 },
                new Student{ StudentName = "Bob", CourseId = 2},
                new Student{ StudentName = "Charlie", CourseId = 3},
                new Student{ StudentName = "Daniel", CourseId = 1},
                new Student{ StudentName = "Eric", CourseId = 4}
            };

            List<Course> courses = new List<Course>
            {
                new Course{ CourseId = 1, CourseName = "Math"},
                new Course{ CourseId = 2, CourseName = "Science"},
                new Course{ CourseId = 3, CourseName = "English"}
            };

            List<SkilledEmployee> skilledEmployees = new List<SkilledEmployee>
            {
                new SkilledEmployee
                {
                    Name = "Alice",
                    Skills = new List<string> { "C#", "SQL", "JavaScript" }
                },
                new SkilledEmployee
                {
                    Name = "Bob",
                    Skills = new List<string> { "Python", "Data Analysis" }
                },
                new SkilledEmployee
                {
                    Name = "Charlie",
                    Skills = new List<string> { "C#", "ASP.NET", "Azure" }
                }
            };

            List<Customers> customers = new List<Customers>
            {
                new Customers { Id = 1, CustomerName = "Alice Johnson" },
                new Customers { Id = 2, CustomerName = "Bob Smith" }
            };

            List<Product> products = new List<Product>
            {
                new Product { Id = 1, ProductName = "Laptop", Price = 1000 },
                new Product { Id = 2, ProductName = "Mouse", Price = 100 }
            };

            List<Order> orders = new List<Order>
            {
                new Order
                {
                    Id = 101,
                    CustomerId = 1,
                    OrderDate = DateTime.Now,
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductId = 1, Quantity = 1 },
                        new OrderItem { ProductId = 2, Quantity = 2 }
                    }
                },
                new Order
                {
                    Id = 102,
                    CustomerId = 2,
                    OrderDate = DateTime.Now,
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductId = 1, Quantity = 3},
                        new OrderItem { ProductId = 2, Quantity = 2}
                    }
                }
            };

            //display all IT employees - WHERE
            var ItEmployees = employees.Where(e => e.JobTitle == "IT");

            //get all employees name - SELECT
            var EmployeesName = employees.Select(e => e.Name);

            //sort employee with descending salary - OrderByDescending
            var result = employees.OrderByDescending(e => e.Salary);

            //first highest salary - OrderByDescending, FirstOrDefault
            var HighestSalary = employees.OrderByDescending(e => e.Salary).FirstOrDefault();

            //count IT employees - Count
            var ItEmployeeCount = employees.Count(e => e.JobTitle == "IT");

            //group employees by JobTitle - GROUPBY
            var group = employees.GroupBy(e => e.JobTitle);

            //Average salary by jobtitle
            var AvgSalary = employees.GroupBy(e => e.JobTitle).Select(g => new { JobTitle = g.Key, AverageSalary = g.Average(e => e.Salary) });

            //Top 2 high paid employees
            var HighPaidEmployees = employees.OrderByDescending(e => e.Salary).Select(g => g.Name).Take(2);

            //Sum salary based on Jobtitle
            var SalarySum = employees.GroupBy(e => e.JobTitle).Select(g => new { JobTitle = g.Key, Sum = g.Sum(e => e.Salary) });

            //join query
            var JoinResult = employees.Join(jobSections, e => e.Id, j => j.EmployeeId, (e, j) => new
            {
                EmployeeName = e.Name,
                Department = e.JobTitle,
                JobDesc = j.JobDescription
            });

            //Get all employees whose salary is greater than 50,000.
            var q1 = employees.OrderByDescending(e => e.Salary).Where(e => e.Salary > 50000).Select(e => new { Name = e.Name, Salary = e.Salary });

            //Sort employees by age ascending.
            var q2 = employees.OrderBy(e => e.Age).Select(e => new { Name = e.Name, Age = e.Age });

            //Find the first employee from IT department.
            var q3 = employees.Where(e => e.JobTitle == "IT").FirstOrDefault();

            //Check whether any employee has salary greater than 1 lakh
            var q4 = employees.Any(e => e.Salary > 100000);

            //Check whether all employees are older than 18
            var q5 = employees.All(e => e.Age > 18);

            //Count number of employees in Finance department
            var q6 = employees.Count(e => e.JobTitle == "HR");

            //Get employee names starting with letter 'S'
            var q7 = employees.Where(e => e.Name.StartsWith("S"));

            //Find highest salary among employees
            var q8 = employees.Max(e => e.Salary);

            //Find lowest salary among employees
            var q9 = employees.Min(e => e.Salary);

            //Avg Salary
            var q10 = employees.Average(e => e.Salary);

            //Get top 3 highest paid employees
            var q11 = employees.OrderByDescending(e => e.Salary).Take(3);

            //Skip first 2 employees and display remaining
            var q12 = employees.Skip(2);

            //Get distinct department names
            var q13 = employees.Select(e => e.JobTitle).Distinct();

            //Find average age department-wise
            var q14 = employees.GroupBy(e => e.JobTitle).Select(g => new { JobTilte = g.Key, AvgAge = g.Average(e => e.Age) });

            //Find employee count department-wise
            var q15 = employees.GroupBy(e => e.JobTitle).Select(g => new { Department = g.Key, Count = g.Count() });

            //Find employees whose names contain "an"
            var q16 = employees.Where(e => e.Name.Contains("an"));

            //Get employees ordered by department and then salary descending
            var q17 = employees.OrderBy(e => e.JobTitle).ThenByDescending(e => e.Salary);

            //Find second highest salary employee
            var q18 = employees.Select(e => e.Salary).Distinct().OrderByDescending(e => e).Skip(1).FirstOrDefault();

            //Find youngest employee 
            var q19 = employees.OrderBy(e => e.Age).FirstOrDefault();

            //Find youngest employee in each department
            var q20 = employees.GroupBy(e => e.JobTitle).Select(g => g.OrderBy(e => e.Age).First());

            //Find department having maximum employees
            var q21 = employees.GroupBy(e => e.JobTitle).OrderByDescending(g => g.Count()).First().Key;

            //Create Student and Course lists and perform INNER JOIN using LINQ
            var q22 = students.Join(courses, s => s.CourseId, c => c.CourseId, (s, c) =>
              new
              {
                  StudentName = s.StudentName,
                  CourseName = c.CourseName

              });

            //Display all students with their enrolled courses
            var q23 = students.GroupJoin(courses, s => s.CourseId, c => c.CourseId, (s, c) => new { students = s, courses = c }).SelectMany(x => x.courses.DefaultIfEmpty(), (studentGroup, course) =>
             new
             {
                 StudentName = studentGroup.students.StudentName,
                 CourseName = course?.CourseName ?? "Not_Enrolled"
             });

            //Use GroupBy to create: Department Name, Employee Count, Average Salary, Highest Salary in single query.
            var q24 = employees.GroupBy(e => e.JobTitle).Select(g => new
            {
                DepartmentName = g.Key,
                EmployeeCount = g.Count(),
                AvgSalary = g.Average(e => e.Salary),
                HighestSalary = g.Max(e => e.Salary)
            });

            //Use SelectMany on nested collections.
            //Example: Each employee has multiple skills. Flatten all skills into single list.
            var AllSkill = skilledEmployees.SelectMany(s => s.Skills);
            var uniqueSkills = skilledEmployees.SelectMany(s => s.Skills).Distinct();

            //Create an E - Commerce scenario:  Customers, Orders, Products
            //Using LINQ: Find top spending customer, Most ordered product, Total revenue, Orders grouped by customer
            //Top spending customer
            var q25 = customers.Select(c => new
            {
                Name = c.CustomerName,
                TotalSpent = orders.Where(o => o.CustomerId == c.Id).SelectMany(o => o.Items).Sum(i => i.Quantity * products.First(p => p.Id == i.ProductId).Price)
            }).OrderByDescending(x => x.TotalSpent).First().Name;

            //most ordered product
            var MostOrderedProduct = products.Select(p => new
            {
                ProductName = p,
                TotalQuantity = orders.SelectMany(o => o.Items).Where(i => i.ProductId == p.Id).Sum(i => i.Quantity)
            }).OrderByDescending(x => x.TotalQuantity).First().ProductName; 

            //Total Revenue
            var TotalRevenue = orders.SelectMany(o => o.Items).Sum(s => s.Quantity * products.First(p => p.Id == s.ProductId).Price);

            //Order grouped by customer
            var OrderGroupedCustomer = customers.Select(c => new
            {
                CustomerName = c.CustomerName,
                Orders = orders.Where(o => o.CustomerId == c.Id).ToList()
            });

            //Find duplicate employees based on name
            var DuplicateEmpName = employees.GroupBy(e => e.Name).Where(g => g.Count() > 1).Select(e => new
            {
                Name = e.Key,
                Count = e.Count()
            }); 

            //Find employees whose salary is above department average
            var q26 = employees.GroupBy(e => e.JobTitle).SelectMany(g=>g.Where(emp => emp.Salary > g.Average(e=>e.Salary)));
            foreach (var i in q26)
            {
                Console.WriteLine(i.Name + " " + i.Salary);
            }

            Console.ReadLine();
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Sam", JobTitle = "IT", Salary = 60000, Age = 24 },
                new Employee { Id = 2, Name = "John", JobTitle = "HR", Salary = 45000, Age = 30 },
                new Employee { Id = 3, Name = "David", JobTitle = "IT", Salary = 75000, Age = 28 },
                new Employee { Id = 4, Name = "Saran", JobTitle = "Finance", Salary = 50000, Age = 26 },
                new Employee { Id = 5, Name = "Mike", JobTitle = "IT", Salary = 80000, Age = 15 },
                new Employee { Id = 6, Name = "Sam", JobTitle = "HR", Salary = 10, Age = 23 },

            };

            List<JobSection> jobSections = new List<JobSection>
            {
                new JobSection{EmployeeId = 1, JobDescription = "Software"},
                new JobSection{EmployeeId = 2, JobDescription = "Manager"},
                new JobSection{EmployeeId = 3, JobDescription = "Software"},
                new JobSection{EmployeeId = 4, JobDescription = "Finance Management"},
                new JobSection{EmployeeId = 5, JobDescription = "Software"}, 
            };

            List<Student> students = new List<Student>
            {
                new Student{ StudentName = "Alice", CourseId = 1 },
                new Student{ StudentName = "Bob", CourseId = 2},
                new Student{ StudentName = "Charlie", CourseId = 3},
                new Student{ StudentName = "Daniel", CourseId = 1},
                new Student{ StudentName = "Eric", CourseId = 4}
            };

            List<Course> courses = new List<Course>
            {
                new Course{ CourseId = 1, CourseName = "Math"},
                new Course{ CourseId = 2, CourseName = "Science"},
                new Course{ CourseId = 3, CourseName = "English"}
            };

            List<SkilledEmployee> skilledEmployees = new List<SkilledEmployee>
            {
                new SkilledEmployee
                {
                    Name = "Alice",
                    Skills = new List<string> { "C#", "SQL", "JavaScript" }
                },
                new SkilledEmployee
                {
                    Name = "Bob",
                    Skills = new List<string> { "Python", "Data Analysis" }
                },
                new SkilledEmployee
                {
                    Name = "Charlie",
                    Skills = new List<string> { "C#", "ASP.NET", "Azure" }
                }
            };

            List<Customers> customers = new List<Customers>
            {
                new Customers { Id = 1, CustomerName = "Alice Johnson" },
                new Customers { Id = 2, CustomerName = "Bob Smith" }
            };

            List<Product> products = new List<Product>
            {
                new Product { Id = 1, ProductName = "Laptop", Price = 1000 },
                new Product { Id = 2, ProductName = "Mouse", Price = 100 }
            };

            List<Order> orders = new List<Order>
            {
                new Order
                {
                    Id = 101,
                    CustomerId = 1,
                    OrderDate = DateTime.Now,
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductId = 1, Quantity = 1 },
                        new OrderItem { ProductId = 2, Quantity = 2 }
                    }
                },
                new Order
                {
                    Id = 102,
                    CustomerId = 2,
                    OrderDate = DateTime.Now,
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductId = 1, Quantity = 3},
                        new OrderItem { ProductId = 2, Quantity = 2}
                    }
                }
            };

            //display all IT employees - WHERE
            var ItEmployees = employees.Where(e => e.JobTitle == "IT");

            //get all employees name - SELECT
            var EmployeesName = employees.Select(e => e.Name);

            //sort employee with descending salary - OrderByDescending
            var result = employees.OrderByDescending(e => e.Salary);

            //first highest salary - OrderByDescending, FirstOrDefault
            var HighestSalary = employees.OrderByDescending(e => e.Salary).FirstOrDefault();

            //count IT employees - Count
            var ItEmployeeCount = employees.Count(e => e.JobTitle == "IT");

            //group employees by JobTitle - GROUPBY
            var group = employees.GroupBy(e => e.JobTitle);

            //Average salary by jobtitle
            var AvgSalary = employees.GroupBy(e => e.JobTitle).Select(g => new { JobTitle = g.Key, AverageSalary = g.Average(e => e.Salary) });

            //Top 2 high paid employees
            var HighPaidEmployees = employees.OrderByDescending(e => e.Salary).Select(g => g.Name).Take(2);

            //Sum salary based on Jobtitle
            var SalarySum = employees.GroupBy(e => e.JobTitle).Select(g => new { JobTitle = g.Key, Sum = g.Sum(e => e.Salary) });

            //join query
            var JoinResult = employees.Join(jobSections, e => e.Id, j => j.EmployeeId, (e, j) => new
            {
                EmployeeName = e.Name,
                Department = e.JobTitle,
                JobDesc = j.JobDescription
            });

            //Get all employees whose salary is greater than 50,000.
            var q1 = employees.OrderByDescending(e => e.Salary).Where(e => e.Salary > 50000).Select(e => new { Name = e.Name, Salary = e.Salary });

            //Sort employees by age ascending.
            var q2 = employees.OrderBy(e => e.Age).Select(e => new { Name = e.Name, Age = e.Age });

            //Find the first employee from IT department.
            var q3 = employees.Where(e => e.JobTitle == "IT").FirstOrDefault();

            //Check whether any employee has salary greater than 1 lakh
            var q4 = employees.Any(e => e.Salary > 100000);

            //Check whether all employees are older than 18
            var q5 = employees.All(e => e.Age > 18);

            //Count number of employees in Finance department
            var q6 = employees.Count(e => e.JobTitle == "HR");

            //Get employee names starting with letter 'S'
            var q7 = employees.Where(e => e.Name.StartsWith("S"));

            //Find highest salary among employees
            var q8 = employees.Max(e => e.Salary);

            //Find lowest salary among employees
            var q9 = employees.Min(e => e.Salary);

            //Avg Salary
            var q10 = employees.Average(e => e.Salary);

            //Get top 3 highest paid employees
            var q11 = employees.OrderByDescending(e => e.Salary).Take(3);

            //Skip first 2 employees and display remaining
            var q12 = employees.Skip(2);

            //Get distinct department names
            var q13 = employees.Select(e => e.JobTitle).Distinct();

            //Find average age department-wise
            var q14 = employees.GroupBy(e => e.JobTitle).Select(g => new { JobTilte = g.Key, AvgAge = g.Average(e => e.Age) });

            //Find employee count department-wise
            var q15 = employees.GroupBy(e => e.JobTitle).Select(g => new { Department = g.Key, Count = g.Count() });

            //Find employees whose names contain "an"
            var q16 = employees.Where(e => e.Name.Contains("an"));

            //Get employees ordered by department and then salary descending
            var q17 = employees.OrderBy(e => e.JobTitle).ThenByDescending(e => e.Salary);

            //Find second highest salary employee
            var q18 = employees.Select(e => e.Salary).Distinct().OrderByDescending(e => e).Skip(1).FirstOrDefault();

            //Find youngest employee 
            var q19 = employees.OrderBy(e => e.Age).FirstOrDefault();

            //Find youngest employee in each department
            var q20 = employees.GroupBy(e => e.JobTitle).Select(g => g.OrderBy(e => e.Age).First());

            //Find department having maximum employees
            var q21 = employees.GroupBy(e => e.JobTitle).OrderByDescending(g => g.Count()).First().Key;

            //Create Student and Course lists and perform INNER JOIN using LINQ
            var q22 = students.Join(courses, s => s.CourseId, c => c.CourseId, (s, c) =>
              new
              {
                  StudentName = s.StudentName,
                  CourseName = c.CourseName

              });

            //Display all students with their enrolled courses
            var q23 = students.GroupJoin(courses, s => s.CourseId, c => c.CourseId, (s, c) => new { students = s, courses = c }).SelectMany(x => x.courses.DefaultIfEmpty(), (studentGroup, course) =>
             new
             {
                 StudentName = studentGroup.students.StudentName,
                 CourseName = course?.CourseName ?? "Not_Enrolled"
             });

            //Use GroupBy to create: Department Name, Employee Count, Average Salary, Highest Salary in single query.
            var q24 = employees.GroupBy(e => e.JobTitle).Select(g => new
            {
                DepartmentName = g.Key,
                EmployeeCount = g.Count(),
                AvgSalary = g.Average(e => e.Salary),
                HighestSalary = g.Max(e => e.Salary)
            });

            //Use SelectMany on nested collections.
            //Example: Each employee has multiple skills. Flatten all skills into single list.
            var AllSkill = skilledEmployees.SelectMany(s => s.Skills);
            var uniqueSkills = skilledEmployees.SelectMany(s => s.Skills).Distinct();

            //Create an E - Commerce scenario:  Customers, Orders, Products
            //Using LINQ: Find top spending customer, Most ordered product, Total revenue, Orders grouped by customer
            //Top spending customer
            var q25 = customers.Select(c => new
            {
                Name = c.CustomerName,
                TotalSpent = orders.Where(o => o.CustomerId == c.Id).SelectMany(o => o.Items).Sum(i => i.Quantity * products.First(p => p.Id == i.ProductId).Price)
            }).OrderByDescending(x => x.TotalSpent).First().Name;

            //most ordered product
            var MostOrderedProduct = products.Select(p => new
            {
                ProductName = p,
                TotalQuantity = orders.SelectMany(o => o.Items).Where(i => i.ProductId == p.Id).Sum(i => i.Quantity)
            }).OrderByDescending(x => x.TotalQuantity).First().ProductName; 

            //Total Revenue
            var TotalRevenue = orders.SelectMany(o => o.Items).Sum(s => s.Quantity * products.First(p => p.Id == s.ProductId).Price);

            //Order grouped by customer
            var OrderGroupedCustomer = customers.Select(c => new
            {
                CustomerName = c.CustomerName,
                Orders = orders.Where(o => o.CustomerId == c.Id).ToList()
            });

            //Find duplicate employees based on name
            var DuplicateEmpName = employees.GroupBy(e => e.Name).Where(g => g.Count() > 1).Select(e => new
            {
                Name = e.Key,
                Count = e.Count()
            }); 

            //Find employees whose salary is above department average
            var q26 = employees.GroupBy(e => e.JobTitle).SelectMany(g=>g.Where(emp => emp.Salary > g.Average(e=>e.Salary)));
            foreach (var i in q26)
            {
                Console.WriteLine(i.Name + " " + i.Salary);
            }

            Console.ReadLine();
        }
    }
>>>>>>> ce989f112d0cb0f04d2e6cd1ec7397960250381f
} 