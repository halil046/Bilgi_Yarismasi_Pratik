using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlıs = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            

            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgi Yarışmasına Hoşgeldiniz Unutmayınki bu bir Pratik ve Tekrar Uygulamasıdır.");
            richTextBox1.Text = "Lütfen Başla Butonuna Basarak İlerleyiniz.";
            btnSonraki.Text = "Başla !";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            
        }

        private void btnA_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;


            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnSonraki.Text = "Sonraki Soru";


            soruno++;
            lblsoru.Text = soruno.ToString();


            if (soruno == 1)
            {
                richTextBox1.Text = "Malazgirt Hangi Tarihte Fethedilmiştir ?";
                btnA.Text = "1069";
                btnB.Text = "1070";
                btnC.Text = "1071";
                btnD.Text = "1072";
                label4.Text = "1071";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Osmanlı Devleti hangi tarihte Kurulmuştur";
                btnA.Text = "1299";
                btnB.Text = "1302";
                btnC.Text = "1304";
                btnD.Text = "1301";
                label4.Text = "1302";
            }
            if (soruno==3)
            {
                richTextBox1.Text = "Mustafa Kemal Atatürk ne zaman Vefat etmiştir ? ";
                btnA.Text = "1938";
                btnB.Text = "1937";
                btnC.Text = "1939";
                btnD.Text = "1936";
                label4.Text = "1938";
                btnSonraki.Text = "Sonuçlar";
            }
            if (soruno == 4) 
            {
                btnA.Enabled =false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                lblsoru.Visible = false;
                lbldogru.Visible = false;
                lblyanlıs.Visible = false;
                MessageBox.Show("Doğru Sayınız: " + dogru +" " + "Yanlış Sayınız: " + yanlıs);
            }
            if (soruno == 5) 
            {
                MessageBox.Show("Yarışmamız Bitmiştir Katıldığınız İçin Teşekkür Ederiz.");
                richTextBox1.Text = " ";
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                lblsoru.Visible = false;
                lbldogru.Visible = false;
                lblyanlıs.Visible = false;
            }
            
        }
    }
}
