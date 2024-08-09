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

            int totCreditHours = course1Hours + course2Hours + course3Hours + course4Hours + course5Hours;
            int gradeCredit = (course1Hours * gradeA) + (course2Hours * gradeB) + (course3Hours * gradeB)
                              + (course4Hours * gradeB) + (course5Hours * gradeA);

            decimal GPA = gradeCredit/(decimal)totCreditHours;
            //to get the first three digits
            int leadDigit = (int)GPA;//first digit
            int firstDigit = (int)(GPA * 10) % 10;//first digit after the decimal point
            int secDigit = (int)(GPA * 100) % 10;//second digit after the decimal point

            Console.WriteLine($@"
Student: {studentName}

Course          Grade      Credit Hours
{course1Name}         {gradeA}          {course1Hours}
{course2Name}         {gradeB}          {course2Hours}
{course3Name}         {gradeB}          {course3Hours}
{course4Name}  {gradeB}          {course4Hours}
{course5Name}      {gradeA}          {course5Hours}

Final GPA:          {leadDigit}.{firstDigit}{secDigit}
");


        }
    }
}
