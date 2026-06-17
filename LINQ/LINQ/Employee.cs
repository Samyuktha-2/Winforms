using System.Collections.Generic;

namespace LINQ
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }

    class JobSection
    {
        public int EmployeeId { get; set; }
        public string JobDescription { get; set; }
    }

    class SkilledEmployee
    {
        public string Name { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
    }
}
