namespace ConsoleApp1.Tasks;

class Task5
{
    static void Main()
    {
        Console.Write("Enter Total Students : ");
        string? tsInput = Console.ReadLine();
        int totalStudents = Convert.ToInt32(tsInput ?? "0");

        string[,] students = new string[totalStudents, 5];

        for (int i = 0; i < totalStudents; i++)
        {
            Console.Write("Enter Student Name : ");
            students[i, 0] = Console.ReadLine() ?? "";

            students[i, 1] = GetValidMarks("Enter English Marks (Out Of 100) : ");
            students[i, 2] = GetValidMarks("Enter Math Marks (Out Of 100) : ");
            students[i, 3] = GetValidMarks("Enter Computer Marks (Out Of 100) : ");

            int total = Convert.ToInt32(students[i, 1]) +
                        Convert.ToInt32(students[i, 2]) +
                        Convert.ToInt32(students[i, 3]);

            students[i, 4] = total.ToString();

            Console.WriteLine("*********************************************");
        }

        for (int i = 0; i < totalStudents - 1; i++)
        {
            for (int j = i + 1; j < totalStudents; j++)
            {
                int total_i = Convert.ToInt32(students[i, 4]);
                int total_j = Convert.ToInt32(students[j, 4]);

                if (total_j > total_i)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        string temp = students[i, k];
                        students[i, k] = students[j, k];
                        students[j, k] = temp;
                    }
                }
            }
        }

        Console.WriteLine("****************Report Card*******************");

        for (int i = 0; i < totalStudents; i++)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine($"Student Name: {students[i, 0]}, " +
                              $"Position: {i + 1}, Total: {students[i, 4]}/300");
        }

        Console.WriteLine("****************************************");
    }

    static string GetValidMarks(string message)
    {
        int marks;

        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out marks))
                continue;

            if (marks < 0 || marks > 100)
                continue;

            return marks.ToString();
        }
    }
}