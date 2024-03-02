namespace ParkIn
{
    public partial class ParkInDash : Form
    {
        public ParkInDash()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void plateNum_Enter(object sender, EventArgs e)
        {
            if (plateNum.Text == "Plate Number")
            {
                plateNum.Text = "";

                plateNum.ForeColor = Color.Black;
            }
        }
        private void plateNum_Leave(object sender, EventArgs e)
        {
            if (plateNum.Text == "")
            {
                plateNum.Text = "Plate Number";

                plateNum.ForeColor = Color.DimGray;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            parkOut form = new parkOut();
            form.ShowDialog();
            this.Close();

        }

        private void parkOutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
