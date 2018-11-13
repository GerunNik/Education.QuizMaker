using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker
{
    public partial class Form1 : Form
    {
        public static List<bool> Grade = new List<bool>();
        static double calculatedGrade;
        public static int QuestionCounter = 0;
        public static int TotalQuestions;
        public static int amountOfQuestions;
        public Form1()
        {
            InitializeComponent();
        }

        public void quizMaker_Click(object sender, EventArgs e)
        {
            amountOfQuestions = Convert.ToInt32(numberOfQuestions.Text);
            List<Question> QuestionList = new List<Question>();
            Random rnd = new Random();

            string questions = System.IO.File.ReadAllText("Questions\\questions.txt", Encoding.Default);
            var ListOfQuestionsWhithAnswers = questions.Split(';');

            foreach (var item in ListOfQuestionsWhithAnswers)
            {
                Question Q1 = new Question(item);
                QuestionList.Add(Q1);
            }

            if (QuestionList.Count < amountOfQuestions)
            {
                amountOfQuestions = QuestionList.Count - 1;
            }
            TotalQuestions = amountOfQuestions;
            while (amountOfQuestions > 0)
            {
                int pickRiddle = rnd.Next(1, QuestionList.Count);
                Quizlet quizlet = new Quizlet(QuestionList[pickRiddle - 1]);
                quizlet.Show();
                QuestionList.Remove(QuestionList[pickRiddle - 1]);
                amountOfQuestions--;
            }

        }
        

        public static void getGrade()
        {
            double totalPoints = Grade.Count;
            double achievedPoints = 0;

            foreach (var item in Grade)
            {
                if (item)
                {
                    achievedPoints++;
                }
            }
                    calculatedGrade = achievedPoints * 5 / totalPoints + 1;

            congrats Form = new congrats(calculatedGrade);
            Form.Show();

            calculatedGrade = 0;
            achievedPoints = 0;
            totalPoints = 0;
            Grade = new List<bool>();
        }
    }
}
