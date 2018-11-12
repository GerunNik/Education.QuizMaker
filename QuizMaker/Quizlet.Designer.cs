namespace QuizMaker
{
    partial class Quizlet
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
            this.question_Txt = new System.Windows.Forms.TextBox();
            this.Answer_txt = new System.Windows.Forms.TextBox();
            this.answer_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question_Txt
            // 
            this.question_Txt.Location = new System.Drawing.Point(12, 12);
            this.question_Txt.Multiline = true;
            this.question_Txt.Name = "question_Txt";
            this.question_Txt.ReadOnly = true;
            this.question_Txt.Size = new System.Drawing.Size(776, 159);
            this.question_Txt.TabIndex = 0;
            // 
            // Answer_txt
            // 
            this.Answer_txt.Location = new System.Drawing.Point(248, 244);
            this.Answer_txt.Name = "Answer_txt";
            this.Answer_txt.Size = new System.Drawing.Size(267, 20);
            this.Answer_txt.TabIndex = 1;
            // 
            // answer_btn
            // 
            this.answer_btn.Location = new System.Drawing.Point(339, 270);
            this.answer_btn.Name = "answer_btn";
            this.answer_btn.Size = new System.Drawing.Size(75, 23);
            this.answer_btn.TabIndex = 2;
            this.answer_btn.Text = "Antworten";
            this.answer_btn.UseVisualStyleBackColor = true;
            this.answer_btn.Click += new System.EventHandler(this.answer_btn_Click);
            // 
            // Quizlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answer_btn);
            this.Controls.Add(this.Answer_txt);
            this.Controls.Add(this.question_Txt);
            this.Name = "Quizlet";
            this.Text = "Quizlet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question_Txt;
        private System.Windows.Forms.TextBox Answer_txt;
        private System.Windows.Forms.Button answer_btn;
    }
}