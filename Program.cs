using static System.Formats.Asn1.AsnWriter;

namespace COMP003A.LectureActivity4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                int grade = -1;
                while (grade <0 || grade > 100)
                {
                    Console.Write($"Enter grade for student {i + 1} (0-100): ");
                    if (int.TryParse(Console.ReadLine(), out grade)) //check if input is valid interger
                    {
                        if (grade < 0 || grade > 100)
                        {
                            grades[i] = grade;
                        }
                        else
                        {
                            Console.WriteLine("Grade must be between 0 and 100");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Please enter a valid number");
                        grade = -1;
                    }
                }
            }
            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            double average = sum / grades.Length;

            Console.WriteLine("\nGrades:");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine($"Average Grade: {average:F2}");
        }
    }
}
