namespace Advanced_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            List<int> grades = new List<int>
{
    85, 92, 78, 95, 88, 70, 100, 65
};

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine("Count: " + grades.Count);
            Console.WriteLine("First Grade: " + grades.First());
            Console.WriteLine("Last Grade: " + grades.Last());



            grades.Sort();

            Console.WriteLine("Sorted Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }


            int firstAbove90 = grades.First(grade => grade > 90);

            Console.WriteLine("First grade above 90: " + firstAbove90);


            List<int> failingGrades = grades.Where(grade => grade < 75).ToList();

            Console.WriteLine("Failing Grades:");

            foreach (int grade in failingGrades)
            {
                Console.WriteLine(grade);
            }


            grades.RemoveAll(grade => grade < 75);

            Console.WriteLine("Grades after removing failing grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            bool has100 = grades.Any(grade => grade == 100);

            Console.WriteLine("Any grade equals 100: " + has100);


            List<string> gradeStrings = grades
    .Select(grade => "Grade: " + grade)
    .ToList();

            foreach (string grade in gradeStrings)
            {
                Console.WriteLine(grade);
            }

            #endregion




        }
    }
}
