using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub_Readme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //<p><a href="https://linkhere">https://linkhere</a></p>

            MessageBox.Show("Added");
            final.Text = final.Text + Environment.NewLine + "<p><a href=" + textBox6.Text + "\"> " + textBox5.Text + " </a></p> <br >";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //   <hr />
            final.Text = final.Text + "<hr />";
            MessageBox.Show("Added");
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            ///px" width="
            ///px" align="right" alt="BresoDEV created this stuff">
            MessageBox.Show("Added");
            final.Text = final.Text + Environment.NewLine +
                "<img src=\"" + textBox7.Text + "\" alt = \"BresoDEV created this stuff\" >" + Environment.NewLine;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //<li>&nbsp; Item 1</li>
            final.Text = final.Text + "<li>&nbsp; <br >";
            MessageBox.Show("Added");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            final.Text = final.Text + Environment.NewLine + "<h1>" + textBox1.Text + "</h1><br >";
            MessageBox.Show("Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //<p>Teste de descricao</p>


            MessageBox.Show("Added");
            final.Text = final.Text + Environment.NewLine + "<p>" + textBox2.Text + "</p>" + Environment.NewLine + Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //  <br >
            MessageBox.Show("Added");
            final.Text = final.Text + Environment.NewLine + "<br >" + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //```C++

            MessageBox.Show("Added");
            final.Text = final.Text + Environment.NewLine + Environment.NewLine + "```" + textBox4.Text + Environment.NewLine + textBox3.Text + Environment.NewLine + "```" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = final.Text;
            MessageBox.Show("Copy and paste gerenated code on your README.md and be happy!!");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ""; final.Text = "";
            MessageBox.Show("All code errased");
        }
    }
}
