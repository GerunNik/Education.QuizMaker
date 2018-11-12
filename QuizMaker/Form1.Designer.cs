namespace QuizMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.quizMaker = new System.Windows.Forms.Button();
            this.numberOfQuestions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many questions do you want?";
            // 
            // quizMaker
            // 
            this.quizMaker.Location = new System.Drawing.Point(136, 73);
            this.quizMaker.Name = "quizMaker";
            this.quizMaker.Size = new System.Drawing.Size(148, 23);
            this.quizMaker.TabIndex = 1;
            this.quizMaker.Text = "Generate Quiz";
            this.quizMaker.UseVisualStyleBackColor = true;
            this.quizMaker.Click += new System.EventHandler(this.quizMaker_Click);
            // 
            // numberOfQuestions
            // 
            this.numberOfQuestions.Location = new System.Drawing.Point(213, 30);
            this.numberOfQuestions.Name = "numberOfQuestions";
            this.numberOfQuestions.Size = new System.Drawing.Size(100, 20);
            this.numberOfQuestions.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 172);
            this.Controls.Add(this.numberOfQuestions);
            this.Controls.Add(this.quizMaker);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quizMaker;
        private System.Windows.Forms.TextBox numberOfQuestions;
    }
}

