﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKK_Kelas_12_RPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btn(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            textBox1.Clear();
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            var hasil = new DataTable().Compute(a, null);
            hasil = Math.Round(Convert.ToDouble(hasil), 8)
            textBox1.Text = hasil.ToString(); 
        
        }
    }
}
