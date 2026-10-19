using System.Diagnostics.Eventing.Reader;

namespace Mini_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc = 0;

            if (!int.TryParse(textBox1.Text, out sayi1) ||
                !int.TryParse(textBox2.Text, out sayi2))
            {
                MessageBox.Show("Lütfen geçerli bir sayý giriniz!");
                return;
            }

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen bir iþlem seçiniz!");
                return;
            }

            if (comboBox1.Text == "Toplama")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (comboBox1.Text == "Çýkarma")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (comboBox1.Text == "Çarpma")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (comboBox1.Text == "Bölme")
            {
                if (sayi2 == 0)
                {
                    MessageBox.Show("Bir sayý sýfýra bölünemez!");
                    return;
                }

                sonuc = sayi1 / sayi2;
            }

            textBox3.Text = sonuc.ToString();
        }
    }
 }

