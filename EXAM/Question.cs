using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{

    
    public abstract class Question
    {
      

        public string? QuestionHeader { get; set; }
        public string? QuestionBody { get; set; }

        public int QuestionMark { get; set; }
        //public string[] Answers { get; set; }
        public Answers[] AnswerList { get; set; }
        public Answers RightAnswer { get; set; }

        public Question(string? questionHeader, string? questionBody, int questionMark, Answers[] answerList, Answers rightAnswer)
        {
            QuestionHeader = questionHeader;
            QuestionBody = questionBody;
            QuestionMark = questionMark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }
        public abstract void DisplayQuestions();
    }
}
