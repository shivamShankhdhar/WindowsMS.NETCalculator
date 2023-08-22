namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fn = Double.Parse(first_number.Text);
            double sn = Double.Parse(second_number.Text);
            double rslt = 0;
            string error = "";
            int choice = Convert.ToInt32(operation.SelectedIndex);
            switch (choice)
            {
                case 0: rslt = fn + sn; break;
                case 1: rslt = fn - sn; break;
                case 2: rslt = fn * sn; break;
                case 3:
                    if (sn > 0) { rslt = fn / sn; }
                    else { error += "Denominator should not be 0"; }
                    break;
            }
            if (error != "") { Result.Text = error; }
            else { Result.Text = rslt.ToString(); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}