﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maths
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int i1 = 3 * 4;
            int i2 = 12 / 4;
            int i3 = 14 / 4;
            int i4 = 15 % 4;
            int i5 = 2 + 3 * 4;
            int i6 = 2 + (3 * 4) / (2 - 4);
            double d1 = 3.1 * 2.3;
            double d2 = 1.0 / 3.0;
            double d3 = 1 / 3;

            RTB.AppendText(i1 + "\n" + i2 + "\n" + i3 + "\n" + i4 + "\n" + i5 + "\n" + i6 + "\n");
            RTB.AppendText(d1 + "\n" + d2 + "\n" + d3 + "\n");

            string st = "3";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + " is not an integar");
            }

            string s2 = "3.2";
            try
            {
                int it = int.Parse(s2);
            }
            catch
            {
                MessageBox.Show(s2 + " is not an integer");
                int i7 = 0;
            }

            string s3 = "pi";
            try
            {
                double d7 = double.Parse(s3);
            }
            catch
            {
                double d7 = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RTB_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
