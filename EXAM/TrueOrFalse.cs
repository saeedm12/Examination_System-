using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class TrueOrFalse:Question
    {
        public TrueOrFalse(string? questionHeader, string? questionBody, int questionMark, Answers rightAnswer) :base (questionHeader, questionBody, questionMark,new Answers[] {new Answers(1,"True"),new Answers(2,"False")},rightAnswer)
        {
        }
        public override void DisplayQuestions()
        {
            Console.WriteLine($" True Or False: \n {QuestionMark} : Point \n {QuestionHeader}");
            Console.WriteLine(QuestionBody);
            foreach (var ans in AnswerList)
            {
                Console.WriteLine(ans.ToString());
            }
        }
      

    }
}
