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
    public partial class Camera_Compare : Form
    {
        public Camera_Compare()
        {
            InitializeComponent();
        }
        public static String case_filepath_1 = "";
        Bitmap Selected_picture;
        
        Mat frame = new Mat();
        Mat case2 = new Mat();

        private void button1_Click(object sender, EventArgs e)
        {
            VideoCapture capture = new VideoCapture(1);
            Mat RGB_result = new Mat();
            Mat toumei_Result = new Mat();
            Cv2.CvtColor(case2, case2, ColorConversionCodes.BGRA2GRAY);
            int i = 0;
            while (Cv2.WaitKey(1) < 0)
            {
                if(i++ % 50 == 0)
                {
                    capture.Read(frame);
                    RGB_result = RGB_Process(frame);
                    toumei_Result = Overlay_process(frame, RGB_result);
                    pictureBox1.Image = toumei_Result.ToBitmap();
                    Cv2.CvtColor(toumei_Result, toumei_Result, ColorConversionCodes.BGRA2GRAY);

                    label2.Text = "" + Cv2.MatchShapes(toumei_Result, case2, ShapeMatchModes.I1, 0.0);
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "open Image";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            case_filepath_1 = openFileDialog1.FileName;
            if (openFileDialog1.FileName != "")
            {
                //pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
                pictureBox2.BackColor = Color.Transparent;
                Selected_picture = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Image = Selected_picture;
            }
            case2 = Cv2.ImRead(case_filepath_1);
        }
        public Mat Overlay_process(Mat Background, Mat Mask)
        {
            Mat result = new Mat(Background.Width, Background.Height, MatType.CV_8UC4);
            Mat[] BGRA;
            Cv2.Threshold(Mask, Mask, 1, 255, ThresholdTypes.BinaryInv);
            if (Mask.Channels() != 1)
            {
                Cv2.CvtColor(Mask, Mask, ColorConversionCodes.BGR2GRAY);
            }

            if (Background.Channels() != 4)
            {
                Cv2.CvtColor(Background, Background, ColorConversionCodes.BGR2BGRA);
            }
            BGRA = Cv2.Split(Background);
            BGRA[3] = Mask;
            Cv2.Merge(BGRA, result);
            return result;
        }
        public Mat RGB_Process(Mat src)
        {
            Mat result = new Mat();
            Mat Dummy_mat = new Mat();
            OpenCvSharp.Point[][] Blue;
            OpenCvSharp.Point[][] Green;
            OpenCvSharp.Point[][] Red;
            OpenCvSharp.Point[][] Dummy;
            OpenCvSharp.Point[][] result_contour;
            HierarchyIndex[] result_hierachy;
            HierarchyIndex[] blue_hi;
            HierarchyIndex[] green_hi;
            HierarchyIndex[] red_hi;
            Mat[] BGR;
            BGR = Cv2.Split(src);
            for (int i = 0; i < BGR.Length; i++)
            {
                Cv2.CvtColor(BGR[i], BGR[i], ColorConversionCodes.GRAY2BGR);
                Cv2.CvtColor(BGR[i], BGR[i], ColorConversionCodes.BGR2GRAY);
                Cv2.Threshold(BGR[i], BGR[i], 0, 255, ThresholdTypes.Otsu | ThresholdTypes.Binary);
                for (int a = 0; a <= 6; a++)
                {
                    Cv2.Erode(BGR[i], BGR[i], new Mat());
                    Cv2.Dilate(BGR[i], BGR[i], new Mat());
                }
            }
            Cv2.FindContours(BGR[0], out Blue, out blue_hi, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            Cv2.FindContours(BGR[1], out Green, out green_hi, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            Cv2.FindContours(BGR[2], out Red, out red_hi, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            double Blue_sum = 0;
            for (int i = 0; i < Blue.Length; i++)
            {
                Blue_sum = Blue_sum + Cv2.ContourArea(Blue[i]);
            }
            double Green_sum = 0;
            for (int i = 0; i < Green.Length; i++)
            {
                Green_sum = Green_sum + Cv2.ContourArea(Green[i]);
            }
            double Red_sum = 0;
            for (int i = 0; i < Red.Length; i++)
            {
                Red_sum = Red_sum + Cv2.ContourArea(Red[i]);
            }
            if (Blue_sum < Red_sum)
            {
                Dummy = Blue;
                Dummy_mat = BGR[0];
                Blue = Red;
                BGR[0] = BGR[2];
                Red = Dummy;
                BGR[2] = Dummy_mat;
            }
            if (Blue_sum < Green_sum)
            {
                Dummy = Blue;
                Dummy_mat = BGR[0];
                Blue = Green;
                Dummy_mat = BGR[1];
                Green = Dummy;
                BGR[1] = Dummy_mat;
            }
            if (Red_sum < Green_sum)
            {
                Dummy = Green;
                Dummy_mat = BGR[1];
                Green = Red;
                BGR[1] = BGR[2];
                Red = Dummy;
                BGR[1] = Dummy_mat;
            }

            Cv2.BitwiseAnd(BGR[0], BGR[1], result);
            Cv2.BitwiseOr(result, BGR[2], result);
            Cv2.FindContours(result, out result_contour, out result_hierachy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            Cv2.BitwiseAnd(result.CvtColor(ColorConversionCodes.GRAY2BGR), src, result);
           
            return result;
        }
    }
}
