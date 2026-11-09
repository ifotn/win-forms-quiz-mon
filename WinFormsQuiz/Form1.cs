namespace WinFormsQuiz
{
    public partial class Form1 : Form
    {
        // array of questions and answers
        string[,] questions = new string[3, 2];

        


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

            // show 1st question on question label
            lblQuestion.Text = questions[0, 0];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("You clicked me");
            // if user has entered correct answer in the textbox
            if (txtAnswer.Text == "Tokyo")
            {
                lblMessage.Text = "Correct";
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.Text = "Incorrect";
                lblMessage.ForeColor = Color.Red;
            }
        }
    }
}
