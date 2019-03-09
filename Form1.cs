using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int[] lotterynumbers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lotterynumbers = new int[4];

            lotterynumbers[0] = 1;
            lotterynumbers[1] = 2;
            lotterynumbers[2] = 3;
            lotterynumbers[3] = 4;

        }

        private void fillBTN_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i != (lotterynumbers.Length); i++)
            {
                listBox1.Items.Add(lotterynumbers[i]);
            }
        }

        private void comboBTN_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            for (int i = 0; i != (lotterynumbers.Length); i++)
            {
                comboBox1.Items.Add(lotterynumbers[i]);
            }
        }
    }
}
