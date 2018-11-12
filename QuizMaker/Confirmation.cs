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
    public partial class Confirmation : Form
    {
        public Confirmation(bool value)
        {
            InitializeComponent();
            if (value)
            {
                this.confirmation_txt.Text = "Korrekt";
            }
            else
            {
                this.confirmation_txt.Text = "Inkorrekt";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Form1.QuestionCounter++;
                if (Form1.QuestionCounter == Form1.TotalQuestions)
                {
                    Form1.getGrade();
                    Form1.QuestionCounter = 0;
                }
            this.Close();
        }
    }
}
