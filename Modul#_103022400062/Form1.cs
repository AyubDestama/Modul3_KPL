using System;
using System.Windows.Forms;

namespace Modul__103022400062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // isi comboBox
            comboBox1.Items.AddRange(new string[]
            {
                "Celcius",
                "Fahrenheit",
                "Kelvin",
                "Reamur"
            });

            comboBox2.Items.AddRange(new string[]
            {
                "Celcius",
                "Fahrenheit",
                "Kelvin",
                "Reamur"
            });

            // textbox hasil readonly
            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu");
                return;
            }

            if (!double.TryParse(textBox1.Text, out double nilai))
            {
                MessageBox.Show("Masukkan angka yang valid");
                return;
            }

            string dari = comboBox1.SelectedItem.ToString();
            string ke = comboBox2.SelectedItem.ToString();

            double hasil = nilai;

            // ubah ke celcius dulu
            if (dari == "Fahrenheit")
                hasil = (nilai - 32) * 5 / 9;
            else if (dari == "Kelvin")
                hasil = nilai - 273.15;
            else if (dari == "Reamur")
                hasil = nilai * 5 / 4;

            // dari celcius ke tujuan
            if (ke == "Fahrenheit")
                hasil = (hasil * 9 / 5) + 32;
            else if (ke == "Kelvin")
                hasil = hasil + 273.15;
            else if (ke == "Reamur")
                hasil = hasil * 4 / 5;

            textBox2.Text = hasil.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}