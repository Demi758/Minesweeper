using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_1
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.instance.difficulty_selected = 0;
            Form1.instance.load_map();
            this.Close();
            Form1.instance.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.instance.difficulty_selected = 1;
            Form1.instance.load_map();
            this.Close();
            Form1.instance.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.instance.difficulty_selected = 2;
            Form1.instance.load_map();
            this.Close();
            Form1.instance.WindowState = FormWindowState.Normal;
        }
    }
}
