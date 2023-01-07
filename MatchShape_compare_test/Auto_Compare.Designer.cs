namespace MatchShape_compare_test
{
    partial class Auto_Compare
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.standard_image_load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Result_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.start_process_button = new System.Windows.Forms.Button();
            this.folder_select_button = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Selected_Image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // standard_image_load
            // 
            this.standard_image_load.Location = new System.Drawing.Point(300, 46);
            this.standard_image_load.Name = "standard_image_load";
            this.standard_image_load.Size = new System.Drawing.Size(132, 35);
            this.standard_image_load.TabIndex = 6;
            this.standard_image_load.Text = "standard image load";
            this.standard_image_load.UseVisualStyleBackColor = true;
            this.standard_image_load.Click += new System.EventHandler(this.standard_image_load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(448, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 400);
            this.listBox1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 244);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 246);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Location = new System.Drawing.Point(287, 269);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(48, 12);
            this.Result_label.TabIndex = 10;
            this.Result_label.Text = "Result : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(341, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 11;
            // 
            // start_process_button
            // 
            this.start_process_button.Location = new System.Drawing.Point(300, 196);
            this.start_process_button.Name = "start_process_button";
            this.start_process_button.Size = new System.Drawing.Size(132, 42);
            this.start_process_button.TabIndex = 12;
            this.start_process_button.Text = "Process!";
            this.start_process_button.UseVisualStyleBackColor = true;
            this.start_process_button.Click += new System.EventHandler(this.start_process_button_Click);
            // 
            // folder_select_button
            // 
            this.folder_select_button.Location = new System.Drawing.Point(300, 87);
            this.folder_select_button.Name = "folder_select_button";
            this.folder_select_button.Size = new System.Drawing.Size(132, 42);
            this.folder_select_button.TabIndex = 13;
            this.folder_select_button.Text = "Selected_folder";
            this.folder_select_button.UseVisualStyleBackColor = true;
            this.folder_select_button.Click += new System.EventHandler(this.folder_select_button_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 19);
            this.textBox1.TabIndex = 14;
            // 
            // Selected_Image
            // 
            this.Selected_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selected_Image.Location = new System.Drawing.Point(300, 135);
            this.Selected_Image.Name = "Selected_Image";
            this.Selected_Image.Size = new System.Drawing.Size(132, 42);
            this.Selected_Image.TabIndex = 15;
            this.Selected_Image.Text = "Selected_Image";
            this.Selected_Image.UseVisualStyleBackColor = true;
            this.Selected_Image.Click += new System.EventHandler(this.Selected_Image_Click);
            // 
            // Auto_Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 507);
            this.Controls.Add(this.Selected_Image);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.folder_select_button);
            this.Controls.Add(this.start_process_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.standard_image_load);
            this.Name = "Auto_Compare";
            this.Text = "Auto_Compare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button standard_image_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_process_button;
        private System.Windows.Forms.Button folder_select_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Selected_Image;
    }
}