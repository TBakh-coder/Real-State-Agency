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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form2_Load(object sender, EventArgs e)
        {
          // <<-- Basic Id generator -->>
          label1.Text = (char)rnd.Next('A', 'Z') + "-" + Convert.ToString( rnd.Next(1001, 9999))  ;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            // <<-- try/catch system for bug free propram -->>
            try
            {
                
                string id = label1.Text;
                string name =  comboBox2.Text;
                string surname = textBox11.Text;
                string contacttype = textBox15.Text;
                string addresshome = textBox4.Text;
                string address = textBox9.Text;
                string email = textBox13.Text;
                string additional = textBox14.Text;
                int floor = Convert.ToInt32(textBox6.Text);
                int age = Convert.ToInt32(textBox5.Text);
                int rooms = Convert.ToInt32(textBox3.Text);
                int bathroom = Convert.ToInt32(textBox8.Text);
                int price = Convert.ToInt32(textBox7.Text);
                int phonenumber = Convert.ToInt32(textBox12.Text);
                int dateofbirth = Convert.ToInt32(textBox10.Text);
                int size = Convert.ToInt32(textBox1.Text);
                int furnished = Convert.ToInt32(checkBox1.Checked);
                int withOwen = Convert.ToInt32(checkBox5.Checked);
                int internet = Convert.ToInt32(checkBox4.Checked);
                int elevator = Convert.ToInt32(checkBox3.Checked);
                int pool = Convert.ToInt32(checkBox8.Checked);
                int aircondition = Convert.ToInt32(checkBox7.Checked);
                int bathtube = Convert.ToInt32(checkBox6.Checked);
                int water = Convert.ToInt32(checkBox2.Checked);
                int incutivestew = Convert.ToInt32(checkBox9.Checked);
                int balcony = Convert.ToInt32(checkBox10.Checked);
                int securitysystem = Convert.ToInt32(checkBox11.Checked);
                int gym = Convert.ToInt32(checkBox12.Checked); 
                Program.properities.Add(new Properity(name, surname, contacttype, id, addresshome, address, email, additional, floor, age, rooms, bathroom, price, phonenumber, dateofbirth, size ,furnished, withOwen, internet, elevator, pool, aircondition, bathtube, water, incutivestew, balcony, securitysystem, gym ));

               

                MessageBox.Show("Properity has been added");

                textBox1.Text = "";
                textBox15.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                comboBox2.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                
                // <<-- File IO operation for wtiting info to test.txt file -->>
                FileStream fs = new FileStream("test.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                

                for (int i = 0; i < Program.properities.Count; i++)
                {

                   

                   
                    string blanker = "\n--------------------------------------------------------\n";
                    
                    // <<-- sw's proccess -->>
                   
                    sw.WriteLine($"Id: {Program.properities[i].Id}");
                    sw.WriteLine($"Size: {Program.properities[i].Size} M²");
                    sw.WriteLine($"Floor: {Program.properities[i].Floor}");
                    sw.WriteLine($"Age: {Program.properities[i].Age} Y" );
                    sw.WriteLine($"House Address: {Program.properities[i].Addresshome}");
                    sw.WriteLine($"Rooms: {Program.properities[i].Rooms}");
                    sw.WriteLine($"Bathroom:  {Program.properities[i].Bathroom}");
                    sw.WriteLine($"Contact Type: {Program.properities[i].Contacttype}");
                    sw.WriteLine($"Price: {Program.properities[i].Price} $");
                    sw.WriteLine($"Seller Phone Number: {Program.properities[i].Phonenumber}");
                    sw.WriteLine($"Seller Name: {Program.properities[i].Name}");
                    sw.WriteLine($"Seller Surename: {Program.properities[i].Surname}");
                    sw.WriteLine($"Seller Address: {Program.properities[i].Address}");
                    sw.WriteLine($"Seller E-Mail: {Program.properities[i].Email}");
                    sw.WriteLine($"Additional:{Program.properities[i].Additional}");
                    sw.WriteLine($"Seller Date of Birth: {Program.properities[i].Dateofbirth}\n");
                    // <<-- if you choose features it will appeared on file at the same time -->>
                    if(checkBox13.Checked)
                    {
                        sw.Write("Furnished,");
                    }
                    if(checkBox14.Checked)
                    {
                        sw.Write("With Owen,");
                    }
                    if (checkBox15.Checked)
                    {
                        sw.Write("Internet,");
                    }
                    if (checkBox16.Checked)
                    {
                        sw.Write("Elevator,");
                    }
                    if (checkBox17.Checked)
                    {
                        sw.Write("Hot/Cold Water,");
                    }
                    if (checkBox18.Checked)
                    {
                        sw.Write("Bath Tube,");
                    }
                    if (checkBox19.Checked)
                    {
                        sw.Write("Air Condition,");
                    }
                    if (checkBox20.Checked)
                    {
                        sw.Write("Pool,");
                    }
                    if (checkBox21.Checked)
                    {
                        sw.Write("Incutive Stew,");
                    }
                    if (checkBox22.Checked)
                    {
                        sw.Write("Balcony,");
                    }
                    if (checkBox23.Checked)
                    {
                        sw.Write("Security System,");
                    }
                    if (checkBox24.Checked)
                    {
                        sw.Write("Gym");
                    }

                    sw.WriteLine(blanker);



                   
                }
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // <<-- take back main menu -->>
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
