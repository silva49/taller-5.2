﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= Convert.ToInt16(txtnumero.Text))
            {

                listBox1.Items.Add(i.ToString());
                i++;
            }
        }
    }
}
