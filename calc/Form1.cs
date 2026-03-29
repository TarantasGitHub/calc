namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox2.Items.AddRange(new object[] { "1", "3", "4", "1", "3", "4" });
        }
        //public class Angle
        //{
        //    public int Degrees { get; private set; }
        //    public int Minut { get; private set; }
        //    public int Sec { get; private set; }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cb)
            {
                switch (cb.SelectedItem?.ToString() ?? string.Empty)
                {
                    case "1":
                        var degre = Int32.Parse(string.IsNullOrEmpty(textBox1.Text) ? "0" : textBox1.Text);
                        MessageBox.Show(degre.ToString());
                        break;
                    default:
                        MessageBox.Show("Необработанное значение");
                        break;
                }
                MessageBox.Show(cb.SelectedItem?.ToString() ?? string.Empty);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            double c = Math.Cos(30);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
