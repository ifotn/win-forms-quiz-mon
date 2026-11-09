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
            btnSubmit = new Button();
            lblMessage = new Label();
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(300, 266);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 16F);
            lblMessage.Location = new Point(300, 61);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(308, 37);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Enter your answer below";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(79, 152);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(194, 20);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "What's the capital of Japan?";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(300, 156);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(442, 27);
            txtAnswer.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
