namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(textInput1.Text);
            int input2 = int.Parse(textInput2.Text);
            int Result = input1 + input2;
            txtResult.Text = Result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(textInput1.Text);
            int input2 = int.Parse(textInput2.Text);
            int Result = input1 - input2;
            txtResult.Text = Result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(textInput1.Text);
            int input2 = int.Parse(textInput2.Text);
            int Result = input1 * input2;
            txtResult.Text = Result.ToString();


        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(textInput1.Text);
            int input2 = int.Parse(textInput2.Text);
            int Result = input1 / input2;
            txtResult.Text = Result.ToString();
            return;

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(textInput1.Text);
            int input2 = int.Parse(textInput2.Text);
            int Result = input1 % input2;
            txtResult.Text = Result.ToString();
            return;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textInput1.Text = "";
            textInput2.Text = "";
            txtResult.Text = "";
            return;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string result = txtResult.Text;
            MessageBox.Show("Your answer is" + "" + result);
            return;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textInput1_Enter(object sender, EventArgs e)
        {
            if (textInput1.Text == "Input")
            {
                textInput1.Text = "";
                textInput1.ForeColor = Color.Gray;
            }
        }

        private void textInput1_Leave(object sender, EventArgs e)
        {
            if (textInput1.Text == "")
            {
                textInput1.Text = "Input";
                textInput1.ForeColor = Color.Gray;
            }
        }

        private void txtResult_Enter(object sender, EventArgs e)
        {
            if (txtResult.Text == "Answer")
            {
                txtResult.Text = "";
                txtResult.ForeColor = Color.Gray;
            }
        }

        private void txtResult_Leave(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                txtResult.Text = "Answer";
                txtResult.ForeColor = Color.Gray;
            }
        }

        private void textInput2_Enter(object sender, EventArgs e)
        {
            if (textInput2.Text == "Input")
            {
                textInput2.Text = "";
                textInput2.ForeColor = Color.Gray;
            }
        }

        private void textInput2_Leave(object sender, EventArgs e)
        {
            if (textInput2.Text == "")
            {
                textInput2.Text = "Input";
                textInput2.ForeColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
