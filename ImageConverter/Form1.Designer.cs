
namespace ImageEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Functional_Tab = new System.Windows.Forms.TabControl();
            this.Convert_Img_Page = new System.Windows.Forms.TabPage();
            this.txtPathFile = new System.Windows.Forms.TextBox();
            this.ConvertTo_Panel = new System.Windows.Forms.Panel();
            this.ImgExtension = new System.Windows.Forms.ComboBox();
            this.ConvertTo_lbl = new System.Windows.Forms.Label();
            this.ChangeResolutionIcon_Panel = new System.Windows.Forms.Panel();
            this.SizeY = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Resolution_lbl = new System.Windows.Forms.Label();
            this.sizeX = new System.Windows.Forms.ComboBox();
            this.ConvertSettings_Panel = new System.Windows.Forms.Panel();
            this.SelectOneFile_radbtn = new System.Windows.Forms.RadioButton();
            this.SelectMultipleFiles_radbtn = new System.Windows.Forms.RadioButton();
            this.Edit_Img_Page = new System.Windows.Forms.TabPage();
            this.Quality_Panel = new System.Windows.Forms.Panel();
            this.SliderValue = new System.Windows.Forms.Label();
            this.Compression_ratio_bar = new System.Windows.Forms.TrackBar();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Main_Buttons_Panel = new System.Windows.Forms.Panel();
            this.OpenFile_btn = new System.Windows.Forms.Button();
            this.SaveImg_btn = new System.Windows.Forms.Button();
            this.Functional_Tab.SuspendLayout();
            this.Convert_Img_Page.SuspendLayout();
            this.ConvertTo_Panel.SuspendLayout();
            this.ChangeResolutionIcon_Panel.SuspendLayout();
            this.Edit_Img_Page.SuspendLayout();
            this.Quality_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Compression_ratio_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.Main_Buttons_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Functional_Tab
            // 
            this.Functional_Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Functional_Tab.Controls.Add(this.Convert_Img_Page);
            this.Functional_Tab.Controls.Add(this.Edit_Img_Page);
            this.Functional_Tab.HotTrack = true;
            this.Functional_Tab.Location = new System.Drawing.Point(0, -1);
            this.Functional_Tab.Name = "Functional_Tab";
            this.Functional_Tab.SelectedIndex = 0;
            this.Functional_Tab.Size = new System.Drawing.Size(384, 319);
            this.Functional_Tab.TabIndex = 10;
            // 
            // Convert_Img_Page
            // 
            this.Convert_Img_Page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Convert_Img_Page.Controls.Add(this.txtPathFile);
            this.Convert_Img_Page.Controls.Add(this.ConvertTo_Panel);
            this.Convert_Img_Page.Controls.Add(this.ChangeResolutionIcon_Panel);
            this.Convert_Img_Page.Controls.Add(this.ConvertSettings_Panel);
            this.Convert_Img_Page.Controls.Add(this.SelectOneFile_radbtn);
            this.Convert_Img_Page.Controls.Add(this.SelectMultipleFiles_radbtn);
            this.Convert_Img_Page.Location = new System.Drawing.Point(4, 22);
            this.Convert_Img_Page.Name = "Convert_Img_Page";
            this.Convert_Img_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Convert_Img_Page.Size = new System.Drawing.Size(376, 293);
            this.Convert_Img_Page.TabIndex = 0;
            this.Convert_Img_Page.Text = "Конвертация изображения";
            this.Convert_Img_Page.UseVisualStyleBackColor = true;
            // 
            // txtPathFile
            // 
            this.txtPathFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathFile.Location = new System.Drawing.Point(13, 40);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Size = new System.Drawing.Size(349, 20);
            this.txtPathFile.TabIndex = 2;
            // 
            // ConvertTo_Panel
            // 
            this.ConvertTo_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertTo_Panel.AutoSize = true;
            this.ConvertTo_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ConvertTo_Panel.Controls.Add(this.ImgExtension);
            this.ConvertTo_Panel.Controls.Add(this.ConvertTo_lbl);
            this.ConvertTo_Panel.Location = new System.Drawing.Point(1, 252);
            this.ConvertTo_Panel.Name = "ConvertTo_Panel";
            this.ConvertTo_Panel.Size = new System.Drawing.Size(370, 32);
            this.ConvertTo_Panel.TabIndex = 5;
            // 
            // ImgExtension
            // 
            this.ImgExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImgExtension.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ImgExtension.FormattingEnabled = true;
            this.ImgExtension.Items.AddRange(new object[] {
            "PNG",
            "JPG",
            "ICO",
            "BMP",
            "TIFF"});
            this.ImgExtension.Location = new System.Drawing.Point(277, 3);
            this.ImgExtension.Name = "ImgExtension";
            this.ImgExtension.Size = new System.Drawing.Size(86, 21);
            this.ImgExtension.TabIndex = 6;
            this.ImgExtension.SelectedValueChanged += new System.EventHandler(this.ImgExtension_SelectedValueChanged);
            // 
            // ConvertTo_lbl
            // 
            this.ConvertTo_lbl.AutoSize = true;
            this.ConvertTo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertTo_lbl.Location = new System.Drawing.Point(3, 4);
            this.ConvertTo_lbl.Name = "ConvertTo_lbl";
            this.ConvertTo_lbl.Size = new System.Drawing.Size(153, 20);
            this.ConvertTo_lbl.TabIndex = 5;
            this.ConvertTo_lbl.Text = "Конвертировать в:";
            // 
            // ChangeResolutionIcon_Panel
            // 
            this.ChangeResolutionIcon_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeResolutionIcon_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChangeResolutionIcon_Panel.Controls.Add(this.SizeY);
            this.ChangeResolutionIcon_Panel.Controls.Add(this.label2);
            this.ChangeResolutionIcon_Panel.Controls.Add(this.Resolution_lbl);
            this.ChangeResolutionIcon_Panel.Controls.Add(this.sizeX);
            this.ChangeResolutionIcon_Panel.Location = new System.Drawing.Point(1, 204);
            this.ChangeResolutionIcon_Panel.Name = "ChangeResolutionIcon_Panel";
            this.ChangeResolutionIcon_Panel.Size = new System.Drawing.Size(370, 42);
            this.ChangeResolutionIcon_Panel.TabIndex = 5;
            this.ChangeResolutionIcon_Panel.Visible = false;
            // 
            // SizeY
            // 
            this.SizeY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SizeY.FormattingEnabled = true;
            this.SizeY.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "256"});
            this.SizeY.Location = new System.Drawing.Point(299, 10);
            this.SizeY.Name = "SizeY";
            this.SizeY.Size = new System.Drawing.Size(60, 21);
            this.SizeY.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(281, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "x";
            // 
            // Resolution_lbl
            // 
            this.Resolution_lbl.AutoSize = true;
            this.Resolution_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Resolution_lbl.Location = new System.Drawing.Point(6, 11);
            this.Resolution_lbl.Name = "Resolution_lbl";
            this.Resolution_lbl.Size = new System.Drawing.Size(163, 20);
            this.Resolution_lbl.TabIndex = 6;
            this.Resolution_lbl.Text = "Разрешение иконки:";
            // 
            // sizeX
            // 
            this.sizeX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeX.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sizeX.FormattingEnabled = true;
            this.sizeX.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "256"});
            this.sizeX.Location = new System.Drawing.Point(213, 10);
            this.sizeX.Name = "sizeX";
            this.sizeX.Size = new System.Drawing.Size(60, 21);
            this.sizeX.TabIndex = 7;
            // 
            // ConvertSettings_Panel
            // 
            this.ConvertSettings_Panel.AutoSize = true;
            this.ConvertSettings_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConvertSettings_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConvertSettings_Panel.Location = new System.Drawing.Point(3, 286);
            this.ConvertSettings_Panel.Name = "ConvertSettings_Panel";
            this.ConvertSettings_Panel.Size = new System.Drawing.Size(368, 2);
            this.ConvertSettings_Panel.TabIndex = 4;
            // 
            // SelectOneFile_radbtn
            // 
            this.SelectOneFile_radbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectOneFile_radbtn.AutoSize = true;
            this.SelectOneFile_radbtn.Location = new System.Drawing.Point(217, 17);
            this.SelectOneFile_radbtn.Name = "SelectOneFile_radbtn";
            this.SelectOneFile_radbtn.Size = new System.Drawing.Size(149, 17);
            this.SelectOneFile_radbtn.TabIndex = 1;
            this.SelectOneFile_radbtn.TabStop = true;
            this.SelectOneFile_radbtn.Text = "Выбрать 1 изображение";
            this.SelectOneFile_radbtn.UseVisualStyleBackColor = true;
            this.SelectOneFile_radbtn.CheckedChanged += new System.EventHandler(this.SelectOneFile_radbtn_CheckedChanged);
            // 
            // SelectMultipleFiles_radbtn
            // 
            this.SelectMultipleFiles_radbtn.AutoSize = true;
            this.SelectMultipleFiles_radbtn.Location = new System.Drawing.Point(7, 17);
            this.SelectMultipleFiles_radbtn.Name = "SelectMultipleFiles_radbtn";
            this.SelectMultipleFiles_radbtn.Size = new System.Drawing.Size(144, 17);
            this.SelectMultipleFiles_radbtn.TabIndex = 0;
            this.SelectMultipleFiles_radbtn.TabStop = true;
            this.SelectMultipleFiles_radbtn.Text = "Массовая конвертация";
            this.SelectMultipleFiles_radbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectMultipleFiles_radbtn.UseVisualStyleBackColor = true;
            this.SelectMultipleFiles_radbtn.CheckedChanged += new System.EventHandler(this.SelectMultipleFiles_radbtn_CheckedChanged);
            // 
            // Edit_Img_Page
            // 
            this.Edit_Img_Page.Controls.Add(this.Quality_Panel);
            this.Edit_Img_Page.Controls.Add(this.PictureBox);
            this.Edit_Img_Page.Location = new System.Drawing.Point(4, 22);
            this.Edit_Img_Page.Name = "Edit_Img_Page";
            this.Edit_Img_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Edit_Img_Page.Size = new System.Drawing.Size(376, 293);
            this.Edit_Img_Page.TabIndex = 1;
            this.Edit_Img_Page.Text = "Изменение изображения";
            this.Edit_Img_Page.UseVisualStyleBackColor = true;
            // 
            // Quality_Panel
            // 
            this.Quality_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Quality_Panel.Controls.Add(this.SliderValue);
            this.Quality_Panel.Controls.Add(this.Compression_ratio_bar);
            this.Quality_Panel.Location = new System.Drawing.Point(318, 6);
            this.Quality_Panel.Name = "Quality_Panel";
            this.Quality_Panel.Size = new System.Drawing.Size(55, 284);
            this.Quality_Panel.TabIndex = 5;
            // 
            // SliderValue
            // 
            this.SliderValue.AutoSize = true;
            this.SliderValue.Location = new System.Drawing.Point(3, 0);
            this.SliderValue.Name = "SliderValue";
            this.SliderValue.Size = new System.Drawing.Size(54, 26);
            this.SliderValue.TabIndex = 4;
            this.SliderValue.Text = "Качество\r\n    100%";
            // 
            // Compression_ratio_bar
            // 
            this.Compression_ratio_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Compression_ratio_bar.Location = new System.Drawing.Point(11, 29);
            this.Compression_ratio_bar.Maximum = 100;
            this.Compression_ratio_bar.Name = "Compression_ratio_bar";
            this.Compression_ratio_bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Compression_ratio_bar.Size = new System.Drawing.Size(37, 252);
            this.Compression_ratio_bar.TabIndex = 1;
            this.Compression_ratio_bar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Compression_ratio_bar.Value = 100;
            this.Compression_ratio_bar.Scroll += new System.EventHandler(this.Compression_ratio_bar_Scroll);
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox.Location = new System.Drawing.Point(6, 6);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(306, 287);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // Main_Buttons_Panel
            // 
            this.Main_Buttons_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Buttons_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_Buttons_Panel.Controls.Add(this.OpenFile_btn);
            this.Main_Buttons_Panel.Controls.Add(this.SaveImg_btn);
            this.Main_Buttons_Panel.Location = new System.Drawing.Point(4, 317);
            this.Main_Buttons_Panel.Name = "Main_Buttons_Panel";
            this.Main_Buttons_Panel.Size = new System.Drawing.Size(376, 41);
            this.Main_Buttons_Panel.TabIndex = 11;
            // 
            // OpenFile_btn
            // 
            this.OpenFile_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFile_btn.Location = new System.Drawing.Point(279, 6);
            this.OpenFile_btn.Name = "OpenFile_btn";
            this.OpenFile_btn.Size = new System.Drawing.Size(88, 28);
            this.OpenFile_btn.TabIndex = 9;
            this.OpenFile_btn.Text = "Открыть файл";
            this.OpenFile_btn.UseVisualStyleBackColor = true;
            this.OpenFile_btn.Click += new System.EventHandler(this.OpenFile_btn_Click);
            // 
            // SaveImg_btn
            // 
            this.SaveImg_btn.Enabled = false;
            this.SaveImg_btn.Location = new System.Drawing.Point(7, 6);
            this.SaveImg_btn.Name = "SaveImg_btn";
            this.SaveImg_btn.Size = new System.Drawing.Size(75, 28);
            this.SaveImg_btn.TabIndex = 5;
            this.SaveImg_btn.Text = "Сохранить";
            this.SaveImg_btn.UseVisualStyleBackColor = true;
            this.SaveImg_btn.Click += new System.EventHandler(this.SaveImg_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Main_Buttons_Panel);
            this.Controls.Add(this.Functional_Tab);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "Image Converter";
            this.Functional_Tab.ResumeLayout(false);
            this.Convert_Img_Page.ResumeLayout(false);
            this.Convert_Img_Page.PerformLayout();
            this.ConvertTo_Panel.ResumeLayout(false);
            this.ConvertTo_Panel.PerformLayout();
            this.ChangeResolutionIcon_Panel.ResumeLayout(false);
            this.ChangeResolutionIcon_Panel.PerformLayout();
            this.Edit_Img_Page.ResumeLayout(false);
            this.Quality_Panel.ResumeLayout(false);
            this.Quality_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Compression_ratio_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.Main_Buttons_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.TabControl Functional_Tab;
        private System.Windows.Forms.TabPage Convert_Img_Page;
        private System.Windows.Forms.TabPage Edit_Img_Page;
        private System.Windows.Forms.TextBox txtPathFile;
        private System.Windows.Forms.RadioButton SelectOneFile_radbtn;
        private System.Windows.Forms.RadioButton SelectMultipleFiles_radbtn;
        private System.Windows.Forms.Panel ConvertSettings_Panel;
        private System.Windows.Forms.Panel ConvertTo_Panel;
        private System.Windows.Forms.ComboBox ImgExtension;
        private System.Windows.Forms.Label ConvertTo_lbl;
        private System.Windows.Forms.Panel ChangeResolutionIcon_Panel;
        private System.Windows.Forms.ComboBox SizeY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Resolution_lbl;
        private System.Windows.Forms.ComboBox sizeX;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TrackBar Compression_ratio_bar;
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Panel Main_Buttons_Panel;
        private System.Windows.Forms.Button OpenFile_btn;
        private System.Windows.Forms.Button SaveImg_btn;
        private System.Windows.Forms.Label SliderValue;
        private System.Windows.Forms.Panel Quality_Panel;
    }
}

