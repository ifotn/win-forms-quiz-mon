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

        // startup method that runs automatically when this form loads
        public Form1()
        {
            InitializeComponent();

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("You clicked me");
            // if user has entered correct answer in the textbox
            if (txtAnswer.Text == questions[currentQuestion, 1])
            {
                lblMessage.Text = "Correct";
                lblMessage.ForeColor = Color.Green;

                // add 1 to correct answer count
                correct++;
            }
            else
            {
                lblMessage.Text = "Incorrect";
                lblMessage.ForeColor = Color.Red;
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
                btnSubmit.Enabled = false;
                lblQuestion.Text = $"You got {correct} correct answers out of {questions.GetLength(0)} questions.";
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
    }
}
