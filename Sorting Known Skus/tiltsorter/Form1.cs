using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Threading;

namespace tiltsorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] skus = textBox1.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            string[] qty = textBox2.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);


            string box = "Box";




            int numb = skus.Length;


        dick:
            

            string sku = Interaction.InputBox("Enter Sku");

        if (sku == "ppp")
        {
            Application.Exit();

        }


        int i = 0;

            queef:

        try
        {
            if (sku != skus[i])
            {
                i++;
                goto queef;

            }
        }

        catch
        {
            MessageBox.Show("Sku was not on list");
            goto dick;
        }

            string punk = qty[i];

            // MessageBox.Show("box" + " " + i.ToString() + " " + "quantity" + " " + punk);

            textBox3.Text = "box" + " " + i.ToString() + " " + "quantity" + " " + punk;
        

            


                goto dick;










            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        // private void Form1_Load(object sender, EventArgs e)
        //{

        // }


    }
}
