using System;

abstract class Employee
{
    public abstract decimal GetPay();
}

class HourlyEmployee : Employee
{
    decimal rate;
    decimal hours;

    public HourlyEmployee(decimal rate, decimal hours)
    {
        this.rate = rate;
        this.hours = hours;
    }

    public override decimal GetPay()
    {
        return rate * hours;
    }
}

class SalariedEmployee : Employee
{
    decimal salary;

    public SalariedEmployee(decimal salary)
    {
        this.salary = salary;
    }

    public override decimal GetPay()
    {
        return salary;
    }
}

class CommissionEmployee : Employee
{
    decimal commission;
    decimal baseSalary;

    public CommissionEmployee(decimal commission, decimal baseSalary)
    {
        this.commission = commission;
        this.baseSalary = baseSalary;
    }

    public override decimal GetPay()
    {
        return baseSalary + commission;
    }
}

class Poly
{
    public static void poly()
    {
        string[] employees =
        {
            "H 100 10",
            "S 30000",
            "C 5000 20000"
        };

        decimal totalPay = 0;

        foreach (string emp in employees)
        {
            string[] parts = emp.Split(' ');
            Employee e = null;

            if (parts[0] == "H")
                e = new HourlyEmployee(decimal.Parse(parts[1]), decimal.Parse(parts[2]));
            else if (parts[0] == "S")
                e = new SalariedEmployee(decimal.Parse(parts[1]));
            else if (parts[0] == "C")
                e = new CommissionEmployee(decimal.Parse(parts[1]), decimal.Parse(parts[2]));

            totalPay += e.GetPay();
        }

        Console.WriteLine(Math.Round(totalPay, 2));
    }
}
