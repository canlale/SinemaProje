using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class CustomerInfo : Form
    {
        
        public int sonuc = 0;
        
        public CustomerInfo(Form1  form, string no)
        {
            InitializeComponent();
            comboBox1.Items.Add("Öğrenci");
            comboBox1.Items.Add("Tam");
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Text = no;
            textBox1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat=0;
            int gozlukfiyat=0;
            int menu=0;
            if (comboBox1.Text=="Öğrenci" && fiyat==0)
            {
                fiyat = 15;
            }
            else if (comboBox1.Text=="Tam" && fiyat == 0)
            {
                fiyat = 25;
            }
            if (checkBox1.Checked && gozlukfiyat==0)
            {
                gozlukfiyat = 3;
            }
            if (checkBox2.Checked && menu==0)
            {
                menu = 10;
            }
            int toplamfiyat=0;
            toplamfiyat = fiyat + gozlukfiyat + menu;
            string toplam = Convert.ToString(toplamfiyat);
            label2.Visible = true;
            label3.Visible = true;
            label2.Text = toplam;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Öğrenci"||comboBox1.Text=="Tam")
            {
                sonuc = 1;
                this.Close();

            }
            else
            {
                MessageBox.Show("Müşteri bilgilerini doldurunuz!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
