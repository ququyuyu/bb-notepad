﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace baby_notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.Opacity = 0;
            this.Hide();
            var form2 = new Form2();
            form2.Show();

            timer1.Stop();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    

    }
}

