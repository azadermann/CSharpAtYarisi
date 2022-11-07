using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatınsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;
        Random rnd = new Random();
       private void SesOynatma()
        {
        SoundPlayer sndply = new SoundPlayer(@"C:\\Users\\azade\\OneDrive\\Masaüstü\\res\\atsesi.wav");
            sndply.Play();
            
        }
        private void SesDurdurma()
        {
            SoundPlayer sndply = new SoundPlayer(@"C:\\Users\\azade\\OneDrive\\Masaüstü\\res\\atsesi.wav");
            sndply.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SesOynatma();
            YazıcıLabel.Visible = true;
            button1.Visible = false;
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox3.Left)
            {
                YazıcıLabel.Text = "Bir Numaralı At Yarışı Önde Götürüyor Değerli Seyirciler ";
            }
            else if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left)
            {
                YazıcıLabel.Text = "İki Numaralı Yarışı Önde Götürüyor Değerli Seyirciler ";
            }
            else if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left)
            {
                YazıcıLabel.Text = "Üç Numaralı At Yarışı Önde Götürüyor Değerli Seyirciler ";
            }
            int birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;
            int ucuncuatgenislik = pictureBox3.Width;
            int bittiscizgisi = BittisLabel.Left;

            pictureBox1.Left += rnd.Next(2, 17);
            pictureBox2.Left += rnd.Next(2, 15);
            pictureBox3.Left += rnd.Next(2, 15);

            if (pictureBox1.Left + pictureBox1.Width > bittiscizgisi)
            {
                timer1.Stop();
                SesDurdurma();
                MessageBox.Show("Bir Numaralı At Yarışı Kazandı");
                pictureBox1.Left = birinciatınsolauzaklık;
                pictureBox2.Left = ikinciatsolauzaklık;
                pictureBox3.Left = ucuncuatsolauzaklık;
                YazıcıLabel.Text = null;
                button1.Visible = true;
                YazıcıLabel.Visible = false;

            }
            else if (pictureBox2.Left + pictureBox2.Width > bittiscizgisi)
            {
                timer1.Stop();
                SesDurdurma();
                MessageBox.Show("İki Numaralı At Yarışı Kazandı");
                pictureBox1.Left = birinciatınsolauzaklık;
                pictureBox2.Left = ikinciatsolauzaklık;
                pictureBox3.Left = ucuncuatsolauzaklık;
                YazıcıLabel.Text = null;
                button1.Visible = true;
                YazıcıLabel.Visible = false;

            }
            else if (pictureBox3.Left + pictureBox3.Width > bittiscizgisi)
            {
                timer1.Stop();
                SesDurdurma();
                MessageBox.Show("Üç Numaralı At Yarışı Kazandı");
                pictureBox1.Left = birinciatınsolauzaklık;
                pictureBox2.Left = ikinciatsolauzaklık;
                pictureBox3.Left = ucuncuatsolauzaklık;
                YazıcıLabel.Text = null;
                button1.Visible = true;
                YazıcıLabel.Visible = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YazıcıLabel.Visible = false;
            birinciatınsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;


        }
    }
}
