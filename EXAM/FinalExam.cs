using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class FinalExam:BaseExam
    {
       
        public FinalExam(int examTime,int NumberOfQuestions):base(NumberOfQuestions,examTime)
        {
        }
        public override void ShowExam()
        {
            int totalMark = 0;
            int obtainedMark = 0;
            Console.WriteLine("Final Exam : ");
            foreach (var Q in questions)
            {
                Q.DisplayQuestions();
                Console.Write("Your Answer ID : ");
                int.TryParse(Console.ReadLine(), out int UserAnswerID);
                if (UserAnswerID ==Q.RightAnswer.AnswerId )
                {
                    obtainedMark += Q.QuestionMark;
                }
            }
            Console.WriteLine($"\nYour Grade: {obtainedMark}/{totalMark}");
        }

    }
}
