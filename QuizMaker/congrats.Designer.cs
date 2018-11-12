namespace QuizMaker
{
    partial class congrats
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
            this.Grade_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(185, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kongratulation zu deiner Note:";
            // 
            // Grade_txt
            // 
            this.Grade_txt.AutoSize = true;
            this.Grade_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Grade_txt.Location = new System.Drawing.Point(365, 221);
            this.Grade_txt.Name = "Grade_txt";
            this.Grade_txt.Size = new System.Drawing.Size(42, 46);
            this.Grade_txt.TabIndex = 1;
            this.Grade_txt.Text = "6";
            // 
            // congrats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grade_txt);
            this.Controls.Add(this.label1);
            this.Name = "congrats";
            this.Text = "congrats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Grade_txt;
    }
}