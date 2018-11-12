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
    public partial class congrats : Form
    {
        public congrats(double value)
        {
            InitializeComponent();
            this.Grade_txt.Text = value.ToString();
        }
    }
}
