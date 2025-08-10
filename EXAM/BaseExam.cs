using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public abstract class BaseExam:IComparable<BaseExam>
    {
      
        public int ExamTime { get; set; }

        public Question[] questions { get; set; }
       
        public int NumberOfQuestions { get; set; }
        public BaseExam(int examTime, int numberOfQuestions)
        {
            ExamTime = examTime;
            questions = new Question[numberOfQuestions];
            NumberOfQuestions = numberOfQuestions;
        }
        public abstract void ShowExam();

        public int CompareTo(BaseExam? other)
        {
           return ExamTime.CompareTo(other?.ExamTime);
        }
    }
}
