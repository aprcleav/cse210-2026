using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        HourlyEmployee h = new HourlyEmployee();
        h.SetName("John");
        h.SetIdNumber("123abc");
        h.SetPayRate(15);
        h.SetHoursWorked(35);

        SalaryEmployee s = new SalaryEmployee();
        s.SetName("Peter");
        s.SetIdNumber("456def");
        s.SetSalary(60000);

        DisplayEmployeeInformation(h);
        DisplayEmployeeInformation(s);

        List<Employee> employees = new List<Employee>();
        employees.Add(h);
        employees.Add(s);

        foreach (Employee e in employees)
        {
            float pay = e.GetPay();
        }

    }
    
    public static void DisplayEmployeeInformation(Employee employee)
    {

        float pay = employee.GetPay();
        Console.WriteLine($"{employee.GetName()} will be paid ${pay}");

    }
}