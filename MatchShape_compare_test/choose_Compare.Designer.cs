namespace MatchShape_compare_test
{
    partial class choose_Compare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Case1_Load = new System.Windows.Forms.Button();
            this.Case2_Load = new System.Windows.Forms.Button();
            this.Compare = new System.Windows.Forms.Button();
            this.result_alert = new System.Windows.Forms.Label();
            this.result_string = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Case1_Load
            // 
            this.Case1_Load.Location = new System.Drawing.Point(99, 309);
            this.Case1_Load.Name = "Case1_Load";
            this.Case1_Load.Size = new System.Drawing.Size(75, 23);
            this.Case1_Load.TabIndex = 0;
            this.Case1_Load.Text = "Case1 Load";
            this.Case1_Load.UseVisualStyleBackColor = true;
            this.Case1_Load.Click += new System.EventHandler(this.Case1_Load_Click);
            // 
            // Case2_Load
            // 
            this.Case2_Load.Location = new System.Drawing.Point(583, 309);
            this.Case2_Load.Name = "Case2_Load";
            this.Case2_Load.Size = new System.Drawing.Size(75, 23);
            this.Case2_Load.TabIndex = 1;
            this.Case2_Load.Text = "Case2 Load";
            this.Case2_Load.UseVisualStyleBackColor = true;
            this.Case2_Load.Click += new System.EventHandler(this.Case2_Load_Click);
            // 
            // Compare
            // 
            this.Compare.Location = new System.Drawing.Point(356, 352);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(75, 23);
            this.Compare.TabIndex = 2;
            this.Compare.Text = "Compare!";
            this.Compare.UseVisualStyleBackColor = true;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // result_alert
            // 
            this.result_alert.AutoSize = true;
            this.result_alert.Location = new System.Drawing.Point(525, 380);
            this.result_alert.Name = "result_alert";
            this.result_alert.Size = new System.Drawing.Size(44, 12);
            this.result_alert.TabIndex = 3;
            this.result_alert.Text = "result : ";
            // 
            // result_string
            // 
            this.result_string.AutoSize = true;
            this.result_string.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.result_string.Location = new System.Drawing.Point(580, 380);
            this.result_string.Name = "result_string";
            this.result_string.Size = new System.Drawing.Size(0, 16);
            this.result_string.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(484, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 269);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // choose_Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.result_string);
            this.Controls.Add(this.result_alert);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.Case2_Load);
            this.Controls.Add(this.Case1_Load);
            this.Name = "choose_Compare";
            this.Text = "choose_Compare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Case1_Load;
        private System.Windows.Forms.Button Case2_Load;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.Label result_alert;
        private System.Windows.Forms.Label result_string;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}