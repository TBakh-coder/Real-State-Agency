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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        
        
        private void Form3_Load(object sender, EventArgs e)
        {
            
            
            

            // <<-- try/catch system for bug free propram -->>
            try
            {

               






                // <<-- here is for counting properities -->>
                // properitys = Convert.ToInt32(label22.Text);
               

               //<<-- if you have no properity then you will see message box which it says you don't have proiperity -->>
               


                

                label8.Text = "";

                // <<-- Filo io operation for reading the file -->>
                FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    label8.Text += sr.ReadLine() + "\n";
                }
                // <<-- Properity Counter -->>
                string ID = "Id:";
                string Label = label8.Text;
                int location = Label.IndexOf(ID);
                
                int Num;
                for (Num = 0; location > -1; Num++)
                {
                    Label = (Label.Substring(0, location) + Label.Substring(location + ID.Length)).Replace("  ", " ");
                    location = Label.IndexOf(ID);
                }

                label22.Text = Convert.ToString(Num);
                if (Num > 0)
                {
                    MessageBox.Show($"you have {Num} properities");
                }
                if(Num == 0)
                {
                    string message = "You don't have any properity do you want to add?";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                        this.Close();
                    }
                    button1.Enabled = false;
                    button2.Enabled = false;
                    groupBox2.Enabled = false;
                    //MessageBox.Show("You don't have any properity do you want to add?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                
                


                sr.Close();
                fs.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            // <<-- Take Back to main menu -->> 
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // <<-- Close the propram -->>
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Location = new Point(label8.Location.X, label8.Location.Y - 30);
            label8.Size = new Size(label8.Height, label8.Width + 60);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Location = new Point(label8.Location.X, label8.Location.Y + 30);
            label8.Size = new Size(label8.Height, label8.Width - 60);
        }
    }
        
       
        
    
}
