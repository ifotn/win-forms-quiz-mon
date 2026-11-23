namespace WinFormsQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnRestart;
            btnSubmit = new Button();
            lblMessage = new Label();
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            btnToggleTheme = new Button();
            btnRestart = new Button();
            SuspendLayout();
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(494, 359);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(128, 41);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(334, 359);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(128, 41);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 16F);
            lblMessage.Location = new Point(334, 150);
            lblMessage.MinimumSize = new Size(442, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(442, 37);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Enter your answer below";
            lblMessage.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(334, 270);
            lblQuestion.MinimumSize = new Size(442, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(442, 20);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "What's the capital of Japan?";
            lblQuestion.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(334, 309);
            txtAnswer.MaxLength = 11;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(442, 27);
            txtAnswer.TabIndex = 3;
            // 
            // btnToggleTheme
            // 
            btnToggleTheme.Location = new Point(648, 359);
            btnToggleTheme.Name = "btnToggleTheme";
            btnToggleTheme.Size = new Size(128, 41);
            btnToggleTheme.TabIndex = 5;
            btnToggleTheme.Text = "Toggle Theme";
            btnToggleTheme.UseVisualStyleBackColor = true;
            btnToggleTheme.Click += btnToggleTheme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 631);
            Controls.Add(btnToggleTheme);
            Controls.Add(btnRestart);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(lblMessage);
            Controls.Add(btnSubmit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblMessage;
        private Label lblQuestion;
        private TextBox txtAnswer;
        private Button btnToggleTheme;
        private Button btnRestart;
    }
}
