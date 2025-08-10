using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class PracticalExam:BaseExam
    {
       public PracticalExam(int examTime , int NumberOfQuestions):base(NumberOfQuestions,examTime) 
        { }
        public override void ShowExam()
        {
            int totalMark = 0;
            int obtainedMark = 0;
            Console.WriteLine("Practical Exam : ");
            foreach (var Q in questions)
            {
                Q.DisplayQuestions();
                Console.WriteLine("Enter Your Answer ID : ");
                int.TryParse(Console.ReadLine(), out int UserAnswerID);
                totalMark += Q.QuestionMark;
                if (UserAnswerID == Q.RightAnswer.AnswerId)
                {
                    obtainedMark += Q.QuestionMark;
                }
                Console.WriteLine($"\nYour Grade: {obtainedMark}/{totalMark}");

                Console.WriteLine("\n--- Correct Answers ---");


                Console.WriteLine($"{Q.QuestionBody} -> {Q.RightAnswer.AnswerText}");


            }
           
            


        }
    }
}
