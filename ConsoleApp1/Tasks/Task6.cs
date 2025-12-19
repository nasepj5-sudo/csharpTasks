namespace ConsoleApp1.Tasks;

class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
    }

    public bool IsPassed()
    {
        return Grade >= 75;
    }
}

class Task6
{
    static void Main(string[] args)
    {
        Student s = new Student();

        // Changed name to PJ
        s.Name = "PJ";
        s.Age = 20;
        s.Grade = 85.5;

        s.DisplayInfo();

        if (s.IsPassed())
            Console.WriteLine("Status: Passed");
        else
            Console.WriteLine("Status: Failed");
    }
}
