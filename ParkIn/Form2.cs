﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkIn
{
    public partial class parkOut : Form
    {
        public parkOut()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void parkInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParkInDash form = new ParkInDash();
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button23_Click(object sender, EventArgs e)
        {
           
        }
    }
}
