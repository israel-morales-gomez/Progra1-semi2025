﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicacsharpprogra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);

            respuesta = num1 + num2;

            lblrespuesta.Text = "RESPUESTA: " + respuesta;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
