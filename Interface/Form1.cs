using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            output_textBox.ReadOnly= true;
            output_textBox.Text = "214124";
        }

        private void языкToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void output_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Accuracy_Scroll(object sender, EventArgs e)
        {
            accuracy_label.Text = "Accuracy: " + Accuracy.Value.ToString();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox frmAbout = new AboutBox();
            frmAbout.ShowDialog();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
