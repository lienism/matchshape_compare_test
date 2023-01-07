using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace MatchShape_compare_test
{
    public partial class Auto_Compare : Form
    {
        public Auto_Compare()
        {
            InitializeComponent();
        }
        public static String case_filepath_1 = "";
        public static String case_filepath_2 = "";
        Bitmap picture_1;
        Bitmap picture_2;
        private void standard_image_load_Click(object sender, EventArgs e)
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

        private void folder_select_button_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                DirectoryInfo di = new DirectoryInfo(textBox1.Text);
                FileInfo[] fi = di.GetFiles();
                for(int a = 0; a < fi.Length; a++)
                {
                    listBox1.Items.Add(fi[a].FullName);
                }
              
            }
        }

        private void start_process_button_Click(object sender, EventArgs e)
        {
            label1.ResetText();
            Mat case_1 = new Mat(picture_1.Width,picture_1.Height,MatType.CV_8UC4);
            Mat case_2 = new Mat(picture_2.Width, picture_2.Height, MatType.CV_8UC4);
            case_1 = Cv2.ImRead(case_filepath_1);
            case_2 = Cv2.ImRead(case_filepath_2);
            Cv2.CvtColor(case_1, case_1, ColorConversionCodes.BGRA2GRAY);
            Cv2.CvtColor(case_2, case_2, ColorConversionCodes.BGRA2GRAY);
            label1.Text = "" + Cv2.MatchShapes(case_1, case_2, ShapeMatchModes.I1);
        }

        private void Selected_Image_Click(object sender, EventArgs e)
        {
            String selected = "" + listBox1.SelectedItem;
            case_filepath_2 = selected;
            picture_2 = new Bitmap(selected);
            pictureBox2.Image = picture_2;
        }
    }
}
