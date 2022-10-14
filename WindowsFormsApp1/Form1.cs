using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAna : Form
    {

        private char _islem;
        private bool _ekrantemizlenecek;
        private int _ilkSayi;
        public frmAna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakam1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek) ekranLabel.Text = "";
            _ekrantemizlenecek = false;
            if(ekranLabel.Text == "0") ekranLabel.Text ="";
            ekranLabel.Text += "1";
        }

        private void rakam2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek) ekranLabel.Text = "";
            _ekrantemizlenecek = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek) ekranLabel.Text = "";
            _ekrantemizlenecek = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek) ekranLabel.Text = "";
            _ekrantemizlenecek = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek) ekranLabel.Text = "";
            _ekrantemizlenecek = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek) ekranLabel.Text = "";
            _ekrantemizlenecek = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek) ekranLabel.Text = "";
            _ekrantemizlenecek = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek) ekranLabel.Text = "";
            _ekrantemizlenecek = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek) ekranLabel.Text = "";
            _ekrantemizlenecek = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek) ekranLabel.Text = "";
            _ekrantemizlenecek = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void buttonartı_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecek = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void buttonesit_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;

            switch(_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void buttoncarp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecek = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void buttoneksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecek = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void buttonbolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecek = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
