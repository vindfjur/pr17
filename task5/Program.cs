using System;

namespace task5
{
    enum EmploymentStatus
    {
        Active,
        OnLeave,
        Terminated
    }

    class Employee
    {
        public string Name { get; set; }
        public DateTime? HireDate { get; set; }
        public EmploymentStatus Status { get; set; }

        public int GetYearsWorked()
        {
            if (!HireDate.HasValue) return -1;
            var today = DateTime.Today;
            var hire = HireDate.Value;
            var years = today.Year - hire.Year;
            if (hire > today.AddYears(-years)) years--;
            return years;
        }

        public override string ToString()
        {
            var years = GetYearsWorked();
            var exp = years >= 0 ? years.ToString() : "не указан";
            return $"{Name}, статус: {Status}, стаж: {exp}";
        }
    }

    class Program
    {
        static void Main()
        {
            var emp = new Employee
            {
                Name = "Петр",
                HireDate = new DateTime(2020, 3, 15),
                Status = EmploymentStatus.Active
            };

            Console.WriteLine(emp.GetYearsWorked());
            emp.HireDate = null;
            Console.WriteLine(emp.GetYearsWorked());
            Console.WriteLine(emp);
        }
    }
}
