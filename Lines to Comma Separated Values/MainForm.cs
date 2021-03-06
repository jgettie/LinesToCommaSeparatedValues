﻿using System;
using System.Windows.Forms;

namespace Lines_to_Comma_Separated_Values
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopyToClipboardAsCommaSeparatedValues_Click(object sender, EventArgs e)
        {
            string result = txtValue.Text.Trim().Replace("\n", ",").Replace("\r", "").Trim();
            if (result != string.Empty)
            {
                Clipboard.SetText(result);
            }
        }
    }
}
