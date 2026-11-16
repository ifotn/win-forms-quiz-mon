namespace WinFormsQuiz
{
    public partial class Form1 : Form
    {
        // array of questions and answers
        string[,] questions = new string[4, 2];

        // track current question
        int currentQuestion = 0;

        // track correct answers
        int correct = 0;

        bool isDark = false;

        // startup method that runs automatically when this form loads
        public Form1()
        {
            InitializeComponent();

            // call new LoadQuestions() method to populate quiz data
            LoadQuestions();
        }

        /// <summary>
        /// populate question / answer array
        /// </summary>
        /// <author>Rich</author>
        private void LoadQuestions()
        {
            // populate array
            questions[0, 0] = "What's the capital of Japan?";
            questions[0, 1] = "Tokyo";
            questions[1, 0] = "What colour is the sky?";
            questions[1, 1] = "Blue";
            questions[2, 0] = "Which came first, the chicken or the egg?";
            questions[2, 1] = "Chicken";
            questions[3, 0] = "What day is our class?";
            questions[3, 1] = "Monday";

            // show 1st question on question label
            lblQuestion.Text = questions[0, 0];
        }

        /// <summary>
        /// give feedback on answer
        /// </summary>
        /// <param name="text">feedback to show on label</param>
        /// <param name="colour">text color for feedback label</param>
        private void ShowFeedback(string text, Color colour)
        {
            lblMessage.Text = text;
            lblMessage.ForeColor = colour;
        }

        /// <summary>
        /// user has finished
        /// </summary>
        private void FinishQuiz()
        {
            btnSubmit.Enabled = false;
            lblQuestion.Text = $"You got {correct} correct answers out of {questions.GetLength(0)} questions.";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("You clicked me");
            // if user has entered correct answer in the textbox
            if (txtAnswer.Text == questions[currentQuestion, 1])
            {
                ShowFeedback("Correct", Color.Green);

                // add 1 to correct answer count
                correct++;
            }
            else
            {
                // wrong answer
                ShowFeedback("Incorrect", Color.Red);
            }

            // increment current question 
            currentQuestion++;

            // are there more questions?
            if (currentQuestion < questions.GetLength(0))
            {
                //  move to next question                
                lblQuestion.Text = questions[currentQuestion, 0];
            }
            else
            {
                // user is done - no more questions
                FinishQuiz();
            }

            // clear last answer
            txtAnswer.Text = "";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            currentQuestion = 0;
            correct = 0;
            lblMessage.Text = "Restarting the Quiz";
            lblMessage.ForeColor = Color.Black;
            lblQuestion.Text = questions[0, 0];
            btnSubmit.Enabled = true;
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            if (isDark == true)
            {
                this.BackColor = Color.Black;
                lblMessage.ForeColor = Color.White;
                lblQuestion.ForeColor = Color.White;
                txtAnswer.ForeColor = Color.White;
                //btnSubmit.ForeColor = Color.Black;
                //btnRestart.ForeColor = Color.Black;
                //btnToggleTheme.ForeColor = Color.Black;
                txtAnswer.BackColor = Color.Gray;
                isDark = false;
            }
            else
            {
                {
                    this.BackColor = Color.White;
                    lblMessage.ForeColor = Color.Black;
                    lblQuestion.ForeColor = Color.Black;
                    txtAnswer.ForeColor = Color.Black;
                    //btnSubmit.ForeColor = Color.White;
                    //btnRestart.ForeColor = Color.White;
                    //btnToggleTheme.ForeColor = Color.White;
                    txtAnswer.BackColor = Color.DimGray;
                    isDark = true;
                }
            }
        }
    }
}
