using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreGirisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           //Şifre Gücünü İnceleme
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = textBox1.Text;
            if (sifre.Length < 6 || sifre.All(char.IsLetter) || sifre.All(char.IsDigit) || !sifre.Any(char.IsLetterOrDigit))
            {
                label2.Text = "Şifrenizin Gücü Düşük";
                label2.ForeColor = Color.Red;
            }
            else if (sifre.Any(char.IsLetter) && sifre.Any(char.IsDigit) && !sifre.All(char.IsLetterOrDigit))
            {
                label2.Text = "Şifrenizin Gücü Yüksek";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "Orta";
                label2.ForeColor = Color.Blue;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
