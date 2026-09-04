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

            #region Exercise 2 

            SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

            leaderboard.Add(500, "Ahmed");
            leaderboard.Add(200, "Sara");
            leaderboard.Add(800, "Ali");
            leaderboard.Add(350, "Mona");


            foreach (var player in leaderboard)
            {
                Console.WriteLine(player.Key + " = " + player.Value);
            }


            int firstKey = leaderboard.First().Key;
            string firstValue = leaderboard.First().Value;

            Console.WriteLine("First Key: " + firstKey);
            Console.WriteLine("First Value: " + firstValue);





            bool exists = leaderboard.ContainsKey(500);

            Console.WriteLine("Score 500 exists: " + exists);


            if (leaderboard.TryGetValue(999, out string playerName))
            {
                Console.WriteLine("Player: " + playerName);
            }
            else
            {
                Console.WriteLine("Score 999 not found.");
            }

            leaderboard.Remove(200);

            Console.WriteLine("Updated Leaderboard:");

            foreach (var player in leaderboard)
            {
                Console.WriteLine(player.Key + " = " + player.Value);
            }


            #endregion



            #region Exercise 3

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook.Add("Ahmed", "01012345678");
            phoneBook.Add("Sara", "01123456789");
            phoneBook.Add("Ali", "01234567890");
            phoneBook.Add("Mona", "01534567890");


            phoneBook["Youssef"] = "01098765432";

            try
            {
                phoneBook.Add("Ahmed", "01099999999");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            bool added = phoneBook.TryAdd("Sara", "01000000000");

            Console.WriteLine("Was contact added? " + added);


            bool found = phoneBook.ContainsKey("Omar");

            Console.WriteLine("Omar exists: " + found);


            string phone = phoneBook.TryGetValue("Omar", out string number)
    ? number
    : "Not Found";

            Console.WriteLine("Omar's phone: " + phone);

            Console.WriteLine("Keys:");
            Console.WriteLine(string.Join(", ", phoneBook.Keys));

            Console.WriteLine("Values:");
            Console.WriteLine(string.Join(", ", phoneBook.Values));

            #endregion






        }
    }
}
