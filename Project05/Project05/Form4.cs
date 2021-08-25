using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project05
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            MessageBox.Show( "This Part is not working still", "Sorry :(",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // <<-- opening test file on that window -->>
            try
            {

                


                label8.Text = "";

                FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    label8.Text += sr.ReadLine() + "\n";
                }

                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.TextLength > 0 && textBox3.TextLength > 0)
                {
                    button1.Enabled = true;
                    textBox1.ReadOnly = true;
                    label8.Visible = true;
                }
                if (textBox1.TextLength == 0 || textBox3.TextLength == 0)
                {
                    button1.Enabled = false;
                    textBox1.ReadOnly = false;
                    label8.Visible = false;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.TextLength > 0 && textBox5.TextLength > 0)
                {
                    button1.Enabled = true;
                    textBox4.ReadOnly = true;
                    label8.Visible = true;
                }
                if (textBox4.TextLength == 0 || textBox5.TextLength == 0)
                {
                    button1.Enabled = false;
                    textBox4.ReadOnly = false;
                    label8.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.TextLength > 0 && textBox7.TextLength > 0)
                {
                    button1.Enabled = true;
                    textBox6.ReadOnly = true;
                    label8.Visible = true;
                }
                if (textBox6.TextLength == 0 || textBox7.TextLength == 0)
                {
                    button1.Enabled = false;
                    textBox6.ReadOnly = false;
                    label8.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.TextLength > 0)
                {
                    button1.Enabled = true;

                    label8.Visible = true;
                }
                if (textBox8.TextLength == 0)
                {
                    button1.Enabled = false;

                    label8.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
