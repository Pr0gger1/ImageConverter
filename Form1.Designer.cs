
namespace Image_Converter
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.OpenFile_btn = new System.Windows.Forms.Button();
            this.NavBar = new System.Windows.Forms.Panel();
            this.ChangeResolution_btn = new System.Windows.Forms.Button();
            this.CompressImg_btn = new System.Windows.Forms.Button();
            this.SaveFile_btn = new System.Windows.Forms.Button();
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ChangeImg_panel = new System.Windows.Forms.Panel();
            this.CompressImg_bar = new System.Windows.Forms.Panel();
            this.CompRatio_bar = new System.Windows.Forms.TrackBar();
            this.SliderValue = new System.Windows.Forms.Label();
            this.FormatImg_panel = new System.Windows.Forms.Panel();
            this.ResolutionChoice_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ResolutionY = new System.Windows.Forms.ComboBox();
            this.ResolutionX = new System.Windows.Forms.ComboBox();
            this.Resolution_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FileExtension = new System.Windows.Forms.ComboBox();
            this.ConvertTo_lbl = new System.Windows.Forms.Label();
            this.NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            this.ChangeImg_panel.SuspendLayout();
            this.CompressImg_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompRatio_bar)).BeginInit();
            this.FormatImg_panel.SuspendLayout();
            this.ResolutionChoice_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile_btn
            // 
            this.OpenFile_btn.BackColor = System.Drawing.Color.Transparent;
            this.OpenFile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenFile_btn.BackgroundImage")));
            this.OpenFile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFile_btn.FlatAppearance.BorderSize = 0;
            this.OpenFile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile_btn.Location = new System.Drawing.Point(22, 10);
            this.OpenFile_btn.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.OpenFile_btn.Name = "OpenFile_btn";
            this.OpenFile_btn.Size = new System.Drawing.Size(51, 47);
            this.OpenFile_btn.TabIndex = 2;
            this.OpenFile_btn.UseVisualStyleBackColor = false;
            this.OpenFile_btn.Click += new System.EventHandler(this.OpenFile_btn_Click);
            this.OpenFile_btn.MouseHover += new System.EventHandler(this.OpenFile_btn_MouseHover);
            // 
            // NavBar
            // 
            this.NavBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavBar.Controls.Add(this.ChangeResolution_btn);
            this.NavBar.Controls.Add(this.CompressImg_btn);
            this.NavBar.Controls.Add(this.SaveFile_btn);
            this.NavBar.Controls.Add(this.OpenFile_btn);
            this.NavBar.Location = new System.Drawing.Point(0, -1);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(800, 68);
            this.NavBar.TabIndex = 3;
            // 
            // ChangeResolution_btn
            // 
            this.ChangeResolution_btn.BackColor = System.Drawing.Color.Transparent;
            this.ChangeResolution_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeResolution_btn.BackgroundImage")));
            this.ChangeResolution_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeResolution_btn.FlatAppearance.BorderSize = 0;
            this.ChangeResolution_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeResolution_btn.Location = new System.Drawing.Point(238, 10);
            this.ChangeResolution_btn.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.ChangeResolution_btn.Name = "ChangeResolution_btn";
            this.ChangeResolution_btn.Size = new System.Drawing.Size(51, 47);
            this.ChangeResolution_btn.TabIndex = 5;
            this.ChangeResolution_btn.UseVisualStyleBackColor = false;
            this.ChangeResolution_btn.MouseHover += new System.EventHandler(this.ChangeResolution_btn_MouseHover);
            // 
            // CompressImg_btn
            // 
            this.CompressImg_btn.BackColor = System.Drawing.Color.Transparent;
            this.CompressImg_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CompressImg_btn.BackgroundImage")));
            this.CompressImg_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CompressImg_btn.FlatAppearance.BorderSize = 0;
            this.CompressImg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompressImg_btn.Location = new System.Drawing.Point(166, 10);
            this.CompressImg_btn.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.CompressImg_btn.Name = "CompressImg_btn";
            this.CompressImg_btn.Size = new System.Drawing.Size(51, 47);
            this.CompressImg_btn.TabIndex = 4;
            this.CompressImg_btn.UseVisualStyleBackColor = false;
            this.CompressImg_btn.MouseHover += new System.EventHandler(this.CompressImg_btn_MouseHover);
            // 
            // SaveFile_btn
            // 
            this.SaveFile_btn.BackColor = System.Drawing.Color.Transparent;
            this.SaveFile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveFile_btn.BackgroundImage")));
            this.SaveFile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveFile_btn.FlatAppearance.BorderSize = 0;
            this.SaveFile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFile_btn.Location = new System.Drawing.Point(94, 10);
            this.SaveFile_btn.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.SaveFile_btn.Name = "SaveFile_btn";
            this.SaveFile_btn.Size = new System.Drawing.Size(51, 47);
            this.SaveFile_btn.TabIndex = 3;
            this.SaveFile_btn.UseVisualStyleBackColor = false;
            this.SaveFile_btn.Click += new System.EventHandler(this.SaveFile_btn_Click);
            this.SaveFile_btn.MouseHover += new System.EventHandler(this.SaveFile_btn_MouseHover);
            // 
            // ImgBox
            // 
            this.ImgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgBox.Location = new System.Drawing.Point(0, 63);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(529, 500);
            this.ImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox.TabIndex = 4;
            this.ImgBox.TabStop = false;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // ChangeImg_panel
            // 
            this.ChangeImg_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeImg_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeImg_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChangeImg_panel.Controls.Add(this.CompressImg_bar);
            this.ChangeImg_panel.Controls.Add(this.FormatImg_panel);
            this.ChangeImg_panel.Location = new System.Drawing.Point(526, 63);
            this.ChangeImg_panel.Name = "ChangeImg_panel";
            this.ChangeImg_panel.Size = new System.Drawing.Size(274, 500);
            this.ChangeImg_panel.TabIndex = 5;
            // 
            // CompressImg_bar
            // 
            this.CompressImg_bar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CompressImg_bar.Controls.Add(this.CompRatio_bar);
            this.CompressImg_bar.Controls.Add(this.SliderValue);
            this.CompressImg_bar.Location = new System.Drawing.Point(37, 238);
            this.CompressImg_bar.Name = "CompressImg_bar";
            this.CompressImg_bar.Size = new System.Drawing.Size(214, 100);
            this.CompressImg_bar.TabIndex = 1;
            // 
            // CompRatio_bar
            // 
            this.CompRatio_bar.LargeChange = 10;
            this.CompRatio_bar.Location = new System.Drawing.Point(13, 41);
            this.CompRatio_bar.Maximum = 100;
            this.CompRatio_bar.Name = "CompRatio_bar";
            this.CompRatio_bar.Size = new System.Drawing.Size(173, 37);
            this.CompRatio_bar.TabIndex = 1;
            this.CompRatio_bar.Scroll += new System.EventHandler(this.CompRatio_bar_Scroll);
            // 
            // SliderValue
            // 
            this.SliderValue.AutoSize = true;
            this.SliderValue.Location = new System.Drawing.Point(59, 12);
            this.SliderValue.Name = "SliderValue";
            this.SliderValue.Size = new System.Drawing.Size(109, 13);
            this.SliderValue.TabIndex = 0;
            this.SliderValue.Text = "Степень сжатия: 0%";
            // 
            // FormatImg_panel
            // 
            this.FormatImg_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormatImg_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FormatImg_panel.Controls.Add(this.ResolutionChoice_panel);
            this.FormatImg_panel.Controls.Add(this.panel1);
            this.FormatImg_panel.Location = new System.Drawing.Point(37, 385);
            this.FormatImg_panel.Name = "FormatImg_panel";
            this.FormatImg_panel.Size = new System.Drawing.Size(214, 100);
            this.FormatImg_panel.TabIndex = 0;
            // 
            // ResolutionChoice_panel
            // 
            this.ResolutionChoice_panel.Controls.Add(this.label2);
            this.ResolutionChoice_panel.Controls.Add(this.ResolutionY);
            this.ResolutionChoice_panel.Controls.Add(this.ResolutionX);
            this.ResolutionChoice_panel.Controls.Add(this.Resolution_lbl);
            this.ResolutionChoice_panel.Location = new System.Drawing.Point(2, 3);
            this.ResolutionChoice_panel.Name = "ResolutionChoice_panel";
            this.ResolutionChoice_panel.Size = new System.Drawing.Size(204, 36);
            this.ResolutionChoice_panel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // ResolutionY
            // 
            this.ResolutionY.FormattingEnabled = true;
            this.ResolutionY.Location = new System.Drawing.Point(153, 9);
            this.ResolutionY.Name = "ResolutionY";
            this.ResolutionY.Size = new System.Drawing.Size(48, 21);
            this.ResolutionY.TabIndex = 2;
            // 
            // ResolutionX
            // 
            this.ResolutionX.FormattingEnabled = true;
            this.ResolutionX.Location = new System.Drawing.Point(82, 9);
            this.ResolutionX.Name = "ResolutionX";
            this.ResolutionX.Size = new System.Drawing.Size(48, 21);
            this.ResolutionX.TabIndex = 1;
            // 
            // Resolution_lbl
            // 
            this.Resolution_lbl.AutoSize = true;
            this.Resolution_lbl.Location = new System.Drawing.Point(3, 12);
            this.Resolution_lbl.Name = "Resolution_lbl";
            this.Resolution_lbl.Size = new System.Drawing.Size(73, 13);
            this.Resolution_lbl.TabIndex = 0;
            this.Resolution_lbl.Text = "Разрешение:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FileExtension);
            this.panel1.Controls.Add(this.ConvertTo_lbl);
            this.panel1.Location = new System.Drawing.Point(3, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 36);
            this.panel1.TabIndex = 1;
            // 
            // FileExtension
            // 
            this.FileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileExtension.FormattingEnabled = true;
            this.FileExtension.Location = new System.Drawing.Point(131, 9);
            this.FileExtension.Name = "FileExtension";
            this.FileExtension.Size = new System.Drawing.Size(64, 21);
            this.FileExtension.TabIndex = 2;
            this.FileExtension.SelectedIndexChanged += new System.EventHandler(this.FileExtension_SelectedIndexChanged);
            // 
            // ConvertTo_lbl
            // 
            this.ConvertTo_lbl.AutoSize = true;
            this.ConvertTo_lbl.Location = new System.Drawing.Point(7, 12);
            this.ConvertTo_lbl.Name = "ConvertTo_lbl";
            this.ConvertTo_lbl.Size = new System.Drawing.Size(102, 13);
            this.ConvertTo_lbl.TabIndex = 0;
            this.ConvertTo_lbl.Text = "Конвертировать в:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.ChangeImg_panel);
            this.Controls.Add(this.ImgBox);
            this.Controls.Add(this.NavBar);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.NavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            this.ChangeImg_panel.ResumeLayout(false);
            this.CompressImg_bar.ResumeLayout(false);
            this.CompressImg_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompRatio_bar)).EndInit();
            this.FormatImg_panel.ResumeLayout(false);
            this.ResolutionChoice_panel.ResumeLayout(false);
            this.ResolutionChoice_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenFile_btn;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Button SaveFile_btn;
        private System.Windows.Forms.Button ChangeResolution_btn;
        private System.Windows.Forms.Button CompressImg_btn;
        private System.Windows.Forms.PictureBox ImgBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Panel ChangeImg_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox FileExtension;
        private System.Windows.Forms.Label ConvertTo_lbl;
        private System.Windows.Forms.Panel FormatImg_panel;
        private System.Windows.Forms.Panel ResolutionChoice_panel;
        private System.Windows.Forms.Label Resolution_lbl;
        private System.Windows.Forms.Panel CompressImg_bar;
        private System.Windows.Forms.TrackBar CompRatio_bar;
        private System.Windows.Forms.Label SliderValue;
        private System.Windows.Forms.ComboBox ResolutionY;
        private System.Windows.Forms.ComboBox ResolutionX;
        private System.Windows.Forms.Label label2;
    }
}

