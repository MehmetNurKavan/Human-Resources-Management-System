﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Resource_Managment_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {  
            this.BackgroundImage = Image.FromFile("C:\\Users\\evind\\OneDrive\\Masaüstü\\Human-Resources-Management-System\\arkaPlanGorsel.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.WindowState = FormWindowState.Maximized;
           
           


        }

        private void label1_Click(object sender, EventArgs e)
        {
       
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPersonle_Click(object sender, EventArgs e)
        {
            windowSıgnIn window=new windowSıgnIn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            windowSıgnIn windowSıgnIn = new windowSıgnIn();
            windowSıgnIn.Close();   
       
            this.Close();  
        }
    }
}
