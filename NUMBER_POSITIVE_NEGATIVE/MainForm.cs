using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUMBER_POSITIVE_NEGATIVE
{
    public partial class MainForm : Form
    {
        const int zero = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        private void NumberTxtBx_TextChanged(object sender, EventArgs e)
        {
            Number_Changed();
        }
        private void Number_Changed()
        {
            try
            {

                if (NumberTxtBx.Text == zero.ToString())
                {
                    WhatInTheBoxLbl.Text = "Zero";
                }
                else if (Convert.ToInt32(NumberTxtBx.Text) > zero)
                {
                    WhatInTheBoxLbl.Text = "Positive";
                }
                else if (Convert.ToInt32(NumberTxtBx.Text) < zero)
                {
                    WhatInTheBoxLbl.Text = "Negative";
                }
            }
            catch
            {
                WhatInTheBoxLbl.Text = "NaN";
            }
        }
    }
}
