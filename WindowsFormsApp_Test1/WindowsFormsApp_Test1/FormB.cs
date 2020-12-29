﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Test1
{
    public partial class FormB : Form
    {
        public string name;
        public string corp;

        FormA frma = new FormA();

        public FormB(FormA fa)
        {
            InitializeComponent();

            frma = fa;
        }

        private void FormB_Load(object sender, EventArgs e)
        {
            txtB_Name.Text = name;
            txtB_Corp.Text = corp;

            System.Drawing.Rectangle ScreenRectVal = Screen.PrimaryScreen.WorkingArea;
            int xPos = ScreenRectVal.Width / 2 + this.Bounds.Width;
            int yPos = ScreenRectVal.Height / 2 - this.Bounds.Height / 2;

            this.SetBounds(xPos, yPos, this.Size.Width, this.Size.Height);
        }

        private void btnB_send_Click(object sender, EventArgs e)
        {
            frma.send(txtB_Name.Text, txtB_Corp.Text);
        }
    }
}
