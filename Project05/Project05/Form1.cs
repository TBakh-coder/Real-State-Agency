﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // <<--Exit Propram -->>
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // <<- opening add properity Window -->>
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // <<-- see all the properities -->>
            this.Hide();
            Form3 f2 = new Form3();
            f2.ShowDialog();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // <<-- search engine button -->>
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }
    }
}