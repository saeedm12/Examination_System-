using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class Subject
    {
        

        public int SubjectID {  get; set; }
        public string? SubjectName { get; set; }
        public BaseExam? SubjectExam { get; set; }

        public Subject(int subjectID, string? subjectName)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
        }
       
        public void CreateExam()
        {

            Console.WriteLine("Please Enter Type of Exam (1 For Final | 2 For Practical)");
            int.TryParse(Console.ReadLine(), out int ExamType);
            Console.WriteLine("Please Enter Time of Exam : ");

            int.TryParse(Console.ReadLine(), out int ExamTime);
            Console.WriteLine("Please Enter Number Of Questions of Exam : ");
            int.TryParse(Console.ReadLine(), out int NumberOfQuestions);

            SubjectExam = (ExamType==1) ? new FinalExam(ExamTime,NumberOfQuestions) : new PracticalExam(ExamTime,NumberOfQuestions);


            

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine($"Creating Question {i+1}");
                Console.WriteLine($"Enter Question {i + 1} Header");
                string? Header = Console.ReadLine();
                Console.WriteLine($"Enter Question {i + 1} Body");
                string? Body = Console.ReadLine();
                Console.WriteLine($"Enter Question {i + 1} Mark");
                int.TryParse(Console.ReadLine(), out int mark);

                if (ExamType == 1) // FinalExam True Or False & MCQ
                {

                    Console.WriteLine($"Select Question {i + 1} Type (MCQ / TRUE OR FALSE) : ");
                    int.TryParse(Console.ReadLine(), out int QuestionType);
                    if (QuestionType == 1) //True Or False
                    {
                        Console.WriteLine("Select 1 True or 2 False : ");
                        int.TryParse(Console.ReadLine(), out int RightID);
                        SubjectExam.questions[i] = new TrueOrFalse(Header, Body, mark, new Answers(RightID, RightID == 1 ? "True" : "False"));
                    }
                    else //MCQ
                    {
                        Console.WriteLine("MCQ : Choose number of Choices ");
                        int.TryParse(Console.ReadLine(), out int NumChoices);
                        Answers[] answers = new Answers[NumChoices];
                        for (int j = 0; j < NumChoices; j++)
                        {
                            Console.WriteLine($"Enter Choice {j + 1}");
                            answers[j] = new Answers(j + 1, Console.ReadLine());
                        }
                        Console.WriteLine("Enter Correct Choice ID : ");
                        int.TryParse(Console.ReadLine(), out int RightID);
                        SubjectExam.questions[i] = new MCQ(Header, Body, mark, answers, answers[RightID - 1]);
                    }
                }
                else //Practical Exam MCQ ONLY 
                {
                    Console.WriteLine("MCQ : Enter Number of Choices : ");
                    int.TryParse(Console.ReadLine(), out int ChoicesNum);
                    Answers[] answers = new Answers[ChoicesNum];
                    for (int j = 0; j < ChoicesNum; j++)
                    {
                        Console.WriteLine($"Enter Choice Number {j+1}");
                        answers[j] = new Answers(j+1, Console.ReadLine());  
                    }
                    Console.WriteLine("Enter Correct Answer ID : ");
                    int.TryParse(Console.ReadLine(), out int RightID);
                    SubjectExam.questions[i] = new MCQ(Header, Body, mark, answers, answers[RightID-1]);

                }

    }



           




    }
        public override string ToString() => $"Subject: {SubjectName} (ID: {SubjectID})";
    }
}
