namespace Calculator
{
    public partial class FrmCalculateGrade : Form
    {
        public FrmCalculateGrade()
        {
            InitializeComponent();

            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal NumberGrade = decimal.Parse(txtNumberGrade.Text);

            if (NumberGrade >= 90)
            {
                txtLetterGrade.Text = "A";
            }
            else if (NumberGrade >= 80 &&  NumberGrade <= 89)
            {
                txtLetterGrade.Text = "B";
            }
            else if (NumberGrade >= 70 && NumberGrade <= 79)
            {
                txtLetterGrade.Text = "C";
            }
            else if (NumberGrade >= 60 && NumberGrade <= 69)
            {
                txtLetterGrade.Text = "D";
            }
            else if (NumberGrade < 60)
            {
                txtLetterGrade.Text = "F";
            }
                  
        }
        private void btnExt_Click(object sender, EventArgs e)
        { 
            this.Close();
        
        }
    }
}
