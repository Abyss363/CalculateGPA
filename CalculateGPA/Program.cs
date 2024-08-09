namespace CalculateGPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Hours = 3;
            int course2Hours = 3;
            int course3Hours = 4;
            int course4Hours = 4;
            int course5Hours = 3;

            int gradeA = 4;
            int gradeB = 3;

            int gradeCredit = (course1Hours * gradeA) + (course2Hours * gradeB) + (course3Hours * gradeB)
                              + (course4Hours * gradeB) + (course5Hours * gradeA);

            int GPA = gradeCredit/(course1Hours + course2Hours + course3Hours + course4Hours + course5Hours);

            Console.WriteLine(GPA);


        }
    }
}
