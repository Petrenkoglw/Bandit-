using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_HandedBandit
{
    public partial class Form1 : Form
    {
        int balance = 100;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            balance -= 5;
            balanceBox.Text = System.Convert.ToString(balance);
            rotate1.Enabled = true;
            rotate2.Enabled = true;
            rotate3.Enabled = true;
            stop1.Enabled = true;
            stop2.Enabled = true;
            stop3.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rotate1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(8);
            n1.Text = System.Convert.ToString(num);
        }

        private void rotate2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(8);
            n2.Text = System.Convert.ToString(num);
        }

        private void rotate3_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(8);
            n3.Text = System.Convert.ToString(num);
        }

        private void stop1_Tick(object sender, EventArgs e)
        {
            rotate1.Enabled = false;
            stop1.Enabled = false;
        }

        private void stop2_Tick(object sender, EventArgs e)
        {
            rotate2.Enabled = false;
            stop2.Enabled = false;
        }

        private void stop3_Tick(object sender, EventArgs e)
        {
            rotate3.Enabled = false;
            stop3.Enabled = false;
            if (balance < 0)
            {
                MessageBox.Show("GAME OVER !");
                balance = 100;
            }


            if ((n1.Text == "7") && (n2.Text == "7") && (n3.Text == "7"))
            {
                balance += 100000;
                balanceBox.Text = System.Convert.ToString(balance);
                MessageBox.Show("!!!JACKPOT!!!");
                MessageBox.Show("You won 100 000$");
            }


            if ((n1.Text == "6") && (n2.Text == "6") && (n3.Text == "6"))
            {
                balance += 10000;
                balanceBox.Text = System.Convert.ToString(balance);
                MessageBox.Show("You won 10000$!");
            }


            if ((n1.Text == "5") && (n2.Text == "5") && (n3.Text == "5"))
            {
                balance += 5000;
                balanceBox.Text = System.Convert.ToString(balance);
                MessageBox.Show("You won 5000$!");
            }

            if ((n1.Text == "4") && (n2.Text == "4") && (n3.Text == "4"))
            {
                balance += 1000;
                balanceBox.Text = System.Convert.ToString(balance);
                MessageBox.Show("You won 1000$!");
            }

            if ((n1.Text == "3") && (n2.Text == "3") && (n3.Text == "3"))
            {
                balance += 500;
                balanceBox.Text = System.Convert.ToString(balance);
                MessageBox.Show("You won 500$!");
            }

            if ((n1.Text == "2") && (n2.Text == "2") && (n3.Text == "2"))
            {
                balance += 100;
                balanceBox.Text = System.Convert.ToString(balance);
                MessageBox.Show("You won 100$!");
            }


            if ((n1.Text == "2") && (n2.Text == "2"))
            {
                if (n3.Text != "2")
                {
                    balance += 15;
                    balanceBox.Text = System.Convert.ToString(balance);
                    MessageBox.Show("You won 15$!");
                }
            }
            if ((n1.Text == "2") && (n3.Text == "2"))
            {
                if (n2.Text != "2")
                {
                    balance += 15;
                    balanceBox.Text = System.Convert.ToString(balance);
                    MessageBox.Show("You won 15$!");
                }
            }
            if ((n3.Text == "2") && (n2.Text == "2"))
            {
                if (n1.Text != "2")
                {
                    balance += 15;
                    balanceBox.Text = System.Convert.ToString(balance);
                    MessageBox.Show("You won 15$!");
                }
            }


            if ((n1.Text == "1") && (n2.Text == "1") && (n3.Text == "1"))
            {
                balance += 10;
                balanceBox.Text = System.Convert.ToString(balance);
                MessageBox.Show("You won 10$!");
            }

            if ((n1.Text == "1") && (n2.Text == "1"))
            {
                if (n3.Text != "1")
                {
                    balance += 5;
                    balanceBox.Text = System.Convert.ToString(balance);
                    MessageBox.Show("You won 5$!");
                }
            }
            if ((n1.Text == "1") && (n3.Text == "1"))
            {
                if (n2.Text != "1")
                {
                    balance += 5;
                    balanceBox.Text = System.Convert.ToString(balance);
                    MessageBox.Show("You won 5$!");
                }
            }
            if ((n3.Text == "1") && (n2.Text == "1"))
            {
                if (n1.Text != "1")
                {
                    balance += 5;
                    balanceBox.Text = System.Convert.ToString(balance);
                    MessageBox.Show("You won 5$!");
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
