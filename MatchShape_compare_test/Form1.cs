using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchShape_compare_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auto_Compare auto_Compare = new Auto_Compare();
            auto_Compare.Show();
            choose_Compare choose_Compare = new choose_Compare();
            choose_Compare.Show();
            Camera_Compare camera_Compare = new Camera_Compare();
            camera_Compare.Show();
        }
    }
}
