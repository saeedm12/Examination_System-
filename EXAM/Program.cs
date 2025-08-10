namespace EXAM
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject ID: ");
           int.TryParse(Console.ReadLine(), out int SubID);

            Console.Write("Enter Subject Name: ");
            string? subName = Console.ReadLine();

            Subject subject = new Subject(SubID, subName);
            subject.CreateExam();

            Console.WriteLine($"\n{subject}");
            subject?.SubjectExam?.ShowExam();
        }
    }
}
