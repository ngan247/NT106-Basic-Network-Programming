﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Bai1().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Bai2().ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Bai3().ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Bai4().ShowDialog();

        }
    }
}
