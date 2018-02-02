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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this,"22");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button21.BackColor = Color.Red;
                button21.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "1");
            ci.ShowDialog();
            if (ci.sonuc==1)
            {
                button1.BackColor = Color.Red;
                button1.Enabled= false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this,"2");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button2.BackColor = Color.Red;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this,"3");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button3.BackColor = Color.Red;
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this,"4");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button4.BackColor = Color.Red;
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this,"5");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button5.BackColor = Color.Red;
                button5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this,"6");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button6.BackColor = Color.Red;
                button6.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this,"7");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button7.BackColor = Color.Red;
                button7.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "8");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button8.BackColor = Color.Red;
                button8.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "9");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button9.BackColor = Color.Red;
                button9.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "10");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button10.BackColor = Color.Red;
                button10.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "11");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button11.BackColor = Color.Red;
                button11.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "12");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button12.BackColor = Color.Red;
                button12.Enabled = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "13");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button13.BackColor = Color.Red;
                button13.Enabled = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "14");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button14.BackColor = Color.Red;
                button14.Enabled = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "15");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button15.BackColor = Color.Red;
                button15.Enabled = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "16");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button16.BackColor = Color.Red;
                button16.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "17");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button17.BackColor = Color.Red;
                button17.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "18");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button18.BackColor = Color.Red;
                button18.Enabled = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "19");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button19.BackColor = Color.Red;
                button19.Enabled = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "20");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button20.BackColor = Color.Red;
                button20.Enabled = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "21");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button21.BackColor = Color.Red;
                button21.Enabled = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "23");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button23.BackColor = Color.Red;
                button23.Enabled = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            CustomerInfo ci = new CustomerInfo(this, "24");
            ci.ShowDialog();
            if (ci.sonuc == 1)
            {
                button24.BackColor = Color.Red;
                button24.Enabled = false;
            }
        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            CustomerList cl = new CustomerList();
        }
    }
}
