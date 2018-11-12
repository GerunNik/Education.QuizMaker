namespace QuizMaker
{
    partial class Confirmation
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
            this.confirmation_txt = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmation_txt
            // 
            this.confirmation_txt.AutoSize = true;
            this.confirmation_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.confirmation_txt.Location = new System.Drawing.Point(33, 9);
            this.confirmation_txt.Name = "confirmation_txt";
            this.confirmation_txt.Size = new System.Drawing.Size(184, 31);
            this.confirmation_txt.TabIndex = 0;
            this.confirmation_txt.Text = "Du hast recht!";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(78, 69);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Schliessen";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 149);
            this.Controls.Add(this.close);
            this.Controls.Add(this.confirmation_txt);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmation_txt;
        private System.Windows.Forms.Button close;
    }
}