using System;

class assign1
{

    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public assign1(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }


    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Salary: ${Salary}");
    }
}

class Program
{
    static void Main()
    {

        assign1 employee1 = new assign1("John Doe", 30, 50000.0);


        employee1.DisplayDetails();
    }
}

