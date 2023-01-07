using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace MatchShape_compare_test
{
    public partial class choose_Compare : Form
    {
        public choose_Compare()
        {
            InitializeComponent();
        }
        public static String case_filepath_1 = "";
        public static String case_filepath_2 = "";
        Bitmap picture_1;
        Bitmap picture_2;

        private void Case1_Load_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "open Image";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            case_filepath_1 = openFileDialog1.FileName;
            if (openFileDialog1.FileName != "")
            {
                //pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
                pictureBox1.BackColor = Color.Transparent;
                picture_1 = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = picture_1;
            }
        }

        private void Case2_Load_Click(object sender, EventArgs e)
        {
            openFileDialog2.Title = "open Image";
            openFileDialog2.FileName = "";
            openFileDialog2.ShowDialog();
            case_filepath_2 = openFileDialog2.FileName;
            if (openFileDialog2.FileName != "")
            {
                //pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
                pictureBox2.BackColor = Color.Transparent;
                picture_2 = new Bitmap(openFileDialog2.FileName);
                pictureBox2.Image = picture_2;
            }
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            result_string.ResetText();
            Mat case_1 = new Mat(picture_1.Width, picture_1.Height,MatType.CV_8UC4);
            Mat case_2 = new Mat();
            case_1 = Cv2.ImRead(case_filepath_1);
            case_2 = Cv2.ImRead(case_filepath_2);
            Cv2.CvtColor(case_1, case_1, ColorConversionCodes.BGRA2GRAY);
            Cv2.CvtColor(case_2, case_2, ColorConversionCodes.BGRA2GRAY);
            result_string.Text = "" + Cv2.MatchShapes(case_1, case_2, ShapeMatchModes.I1);
        }
    }
}
