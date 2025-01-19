namespace Zadanie_4
{
    public partial class Form1 : Form
    {

        Dictionary<string, double> fuelPrices = new Dictionary<string, double>
        {
            { "92", 48.75 },
            { "95", 52.30 },
            { "98", 55.00 },
            { "100", 58.00 },
            { "ДТ", 50.20 }
        };

        Dictionary<string, double> menuPrices = new Dictionary<string, double>
        {
            {"Френч-док", 220.99 },
            {"Хот-дог", 165.99 },
            {"Картошка фри", 99.50 },
            {"Кола", 70.00 },
            {"Фанта", 70.00 },
            {"Латте 0.4", 120.99 },
            {"Капучино 0.4", 120.99 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedKey = comboBox1.SelectedItem.ToString();

            double selectedPrice = fuelPrices[selectedKey];

            textBox1.Text = selectedPrice.ToString();
        }




        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox checkBox = sender as CheckBox;

            if (checkBox != null && checkBox.Tag != null)
            {

                TextBox textBox = checkBox.Tag as TextBox;

                if (textBox != null)
                {

                    textBox.ReadOnly = !checkBox.Checked;
                }
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

    }
}
