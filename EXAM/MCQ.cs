using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class MCQ:Question
    {
        public MCQ(string? questionHeader, string? questionBody, int questionMark, Answers[] answerList, Answers rightAnswer) : base(questionHeader, questionBody, questionMark, answerList , rightAnswer)
        {
        }
        public override void DisplayQuestions()
        {
            Console.WriteLine($"MCQ : \nPoints : {QuestionMark}\n{QuestionHeader}");
            Console.WriteLine(QuestionBody);
            foreach (var ans in AnswerList)
            {
                Console.WriteLine(ans.ToString());   
            }
        }
    }
}
