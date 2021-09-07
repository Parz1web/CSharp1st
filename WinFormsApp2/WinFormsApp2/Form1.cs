using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + (sender as Button).Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + (sender as Button).Text;
            }
        }

        public enum Actions
        {
            SUM, MINUS, MULTI, DIV, MRC
        }

        private Actions lastAction;
        private double var1, var2, save = 0, last;
        private int counter = 0;
        


        //====
        private void button15_Click(object sender, EventArgs e)
        {
            var2 = double.Parse(textBox1.Text);
            if (lastAction == Actions.SUM)
            {
                textBox1.Text = (var1 + var2).ToString();
            }
            if (lastAction == Actions.MINUS)
            {
                textBox1.Text = (var1 - var2).ToString();
            }
            if (lastAction == Actions.MULTI)
            {
                textBox1.Text = (var1 * var2).ToString();
            }
            if (lastAction == Actions.DIV)
            {
                textBox1.Text = (var1 / var2).ToString();
            }
        }
        //===

        //+++
        private void button11_Click(object sender, EventArgs e)
        {
            var1 = double.Parse(textBox1.Text);
            lastAction = Actions.SUM;
            textBox1.Text = "";
        }
        //+++



        //---
        private void button12_Click(object sender, EventArgs e)
        {
            var1 = double.Parse(textBox1.Text);
            lastAction = Actions.MINUS;
            textBox1.Text = "";
        }
        //---


        //***
        private void button13_Click(object sender, EventArgs e)
        {
            var1 = double.Parse(textBox1.Text);
            lastAction = Actions.MULTI;
            textBox1.Text = "";
        }

        //***



        //  ///
        private void button14_Click(object sender, EventArgs e)
        {
            var1 = double.Parse(textBox1.Text);
            lastAction = Actions.DIV;
            textBox1.Text = "";
        }
        //  ///

        //clear
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        //clear


        //MRC
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = save.ToString();
            if (lastAction == Actions.MRC)
            {
                save = 0;
                textBox1.Text = last.ToString();
            }
            lastAction = Actions.MRC;
        }
        //MRC


        //M+
        private void button18_Click(object sender, EventArgs e)
        {
            save = save + double.Parse(textBox1.Text);
            lastAction = 0;
        }
        //M+

        //M-
        private void button19_Click(object sender, EventArgs e)
        {
            save = save - double.Parse(textBox1.Text);
            lastAction = 0;
        }
        //M-
    }
}
