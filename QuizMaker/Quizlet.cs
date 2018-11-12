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
    public partial class Quizlet : Form
    {
        Question question = new Question();
        public Quizlet(Question value)
        {
            question = value;
            InitializeComponent();
            question_Txt.Text = question.getRiddle();
            
        }

        public void answer_btn_Click(object sender, EventArgs e)
        {
            foreach (var item in question.GetAnswer())
            {
                string answer = this.Answer_txt.Text;
                if (item.ToLower() == answer.ToLower())
                {
                    question.setTrueOrFalse('t');
                    break;
                }
                else
                {
                    question.setTrueOrFalse('f');
                }
            }

            Form1.Grade.Add(question.getTrueOrFalse());
            Confirmation conf = new Confirmation(question.getTrueOrFalse());
            conf.Show();
            this.Close();
        }
    }
}
