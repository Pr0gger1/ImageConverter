
namespace ImageEditor
{
    partial class ProgramForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramForm));
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Convert_Img_Page = new System.Windows.Forms.TabPage();
            this.DropZone = new System.Windows.Forms.Panel();
            this.TitleDrop = new System.Windows.Forms.Label();
            this.txtPathFile = new System.Windows.Forms.TextBox();
            this.ConvertTo_Panel = new System.Windows.Forms.Panel();
            this.ImgExtension = new System.Windows.Forms.ComboBox();
            this.ConvertTo_lbl = new System.Windows.Forms.Label();
            this.ChangeResolutionIcon_Panel = new System.Windows.Forms.Panel();
            this.Resolution_lbl = new System.Windows.Forms.Label();
            this.sizeX = new System.Windows.Forms.ComboBox();
            this.ConvertSettings_Panel = new System.Windows.Forms.Panel();
            this.Edit_Img_Page = new System.Windows.Forms.TabPage();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.DropZone2 = new System.Windows.Forms.Panel();
            this.TitleDrop2 = new System.Windows.Forms.Label();
            this.Quality_Panel = new System.Windows.Forms.Panel();
            this.SliderValue = new System.Windows.Forms.Label();
            this.Compression_ratio_bar = new System.Windows.Forms.TrackBar();
            this.Main_Buttons_Panel = new System.Windows.Forms.Panel();
            this.Access_compress_lbl = new System.Windows.Forms.Label();
            this.ClearDropZone_btn = new System.Windows.Forms.Button();
            this.SaveImg_btn = new System.Windows.Forms.Button();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.TabControl.SuspendLayout();
            this.Convert_Img_Page.SuspendLayout();
            this.DropZone.SuspendLayout();
            this.ConvertTo_Panel.SuspendLayout();
            this.ChangeResolutionIcon_Panel.SuspendLayout();
            this.Edit_Img_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.DropZone2.SuspendLayout();
            this.Quality_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Compression_ratio_bar)).BeginInit();
            this.Main_Buttons_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.Convert_Img_Page);
            this.TabControl.Controls.Add(this.Edit_Img_Page);
            this.TabControl.HotTrack = true;
            this.TabControl.Location = new System.Drawing.Point(0, -1);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(784, 486);
            this.TabControl.TabIndex = 10;
            // 
            // Convert_Img_Page
            // 
            this.Convert_Img_Page.AllowDrop = true;
            this.Convert_Img_Page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Convert_Img_Page.Controls.Add(this.DropZone);
            this.Convert_Img_Page.Controls.Add(this.txtPathFile);
            this.Convert_Img_Page.Controls.Add(this.ConvertTo_Panel);
            this.Convert_Img_Page.Controls.Add(this.ChangeResolutionIcon_Panel);
            this.Convert_Img_Page.Controls.Add(this.ConvertSettings_Panel);
            this.Convert_Img_Page.Location = new System.Drawing.Point(4, 22);
            this.Convert_Img_Page.Name = "Convert_Img_Page";
            this.Convert_Img_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Convert_Img_Page.Size = new System.Drawing.Size(776, 460);
            this.Convert_Img_Page.TabIndex = 0;
            this.Convert_Img_Page.Text = "Конвертация изображения";
            this.Convert_Img_Page.UseVisualStyleBackColor = true;
            // 
            // DropZone
            // 
            this.DropZone.AllowDrop = true;
            this.DropZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DropZone.AutoSize = true;
            this.DropZone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DropZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DropZone.Controls.Add(this.TitleDrop);
            this.DropZone.Location = new System.Drawing.Point(7, 113);
            this.DropZone.Name = "DropZone";
            this.DropZone.Size = new System.Drawing.Size(759, 252);
            this.DropZone.TabIndex = 6;
            this.DropZone.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropZone_DragDrop);
            this.DropZone.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropZone_DragEnter);
            this.DropZone.DragLeave += new System.EventHandler(this.DropZone_DragLeave);
            // 
            // TitleDrop
            // 
            this.TitleDrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleDrop.Location = new System.Drawing.Point(0, 0);
            this.TitleDrop.Name = "TitleDrop";
            this.TitleDrop.Size = new System.Drawing.Size(757, 250);
            this.TitleDrop.TabIndex = 0;
            this.TitleDrop.Text = "Перетащите файл(ы) в эту область...";
            this.TitleDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPathFile
            // 
            this.txtPathFile.AcceptsTab = true;
            this.txtPathFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathFile.Location = new System.Drawing.Point(7, 6);
            this.txtPathFile.Multiline = true;
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Size = new System.Drawing.Size(758, 101);
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
            this.ConvertTo_Panel.Location = new System.Drawing.Point(1, 419);
            this.ConvertTo_Panel.Name = "ConvertTo_Panel";
            this.ConvertTo_Panel.Size = new System.Drawing.Size(770, 32);
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
            "TIFF",
            "SVG"});
            this.ImgExtension.Location = new System.Drawing.Point(677, 3);
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
            this.ChangeResolutionIcon_Panel.Controls.Add(this.Resolution_lbl);
            this.ChangeResolutionIcon_Panel.Controls.Add(this.sizeX);
            this.ChangeResolutionIcon_Panel.Location = new System.Drawing.Point(1, 371);
            this.ChangeResolutionIcon_Panel.Name = "ChangeResolutionIcon_Panel";
            this.ChangeResolutionIcon_Panel.Size = new System.Drawing.Size(770, 42);
            this.ChangeResolutionIcon_Panel.TabIndex = 5;
            this.ChangeResolutionIcon_Panel.Visible = false;
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
            "16",
            "32",
            "64",
            "128",
            "256"});
            this.sizeX.Location = new System.Drawing.Point(703, 10);
            this.sizeX.Name = "sizeX";
            this.sizeX.Size = new System.Drawing.Size(60, 21);
            this.sizeX.TabIndex = 7;
            // 
            // ConvertSettings_Panel
            // 
            this.ConvertSettings_Panel.AutoSize = true;
            this.ConvertSettings_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConvertSettings_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConvertSettings_Panel.Location = new System.Drawing.Point(3, 453);
            this.ConvertSettings_Panel.Name = "ConvertSettings_Panel";
            this.ConvertSettings_Panel.Size = new System.Drawing.Size(768, 2);
            this.ConvertSettings_Panel.TabIndex = 4;
            // 
            // Edit_Img_Page
            // 
            this.Edit_Img_Page.Controls.Add(this.PictureBox);
            this.Edit_Img_Page.Controls.Add(this.DropZone2);
            this.Edit_Img_Page.Controls.Add(this.Quality_Panel);
            this.Edit_Img_Page.Location = new System.Drawing.Point(4, 22);
            this.Edit_Img_Page.Name = "Edit_Img_Page";
            this.Edit_Img_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Edit_Img_Page.Size = new System.Drawing.Size(776, 460);
            this.Edit_Img_Page.TabIndex = 1;
            this.Edit_Img_Page.Text = "Изменение изображения";
            this.Edit_Img_Page.UseVisualStyleBackColor = true;
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.Location = new System.Drawing.Point(6, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(705, 391);
            this.PictureBox.TabIndex = 8;
            this.PictureBox.TabStop = false;
            // 
            // DropZone2
            // 
            this.DropZone2.AllowDrop = true;
            this.DropZone2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DropZone2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DropZone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DropZone2.Controls.Add(this.TitleDrop2);
            this.DropZone2.Location = new System.Drawing.Point(6, 400);
            this.DropZone2.Name = "DropZone2";
            this.DropZone2.Size = new System.Drawing.Size(706, 54);
            this.DropZone2.TabIndex = 7;
            this.DropZone2.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropZone_DragDrop);
            this.DropZone2.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropZone_DragEnter);
            this.DropZone2.DragLeave += new System.EventHandler(this.DropZone_DragLeave);
            // 
            // TitleDrop2
            // 
            this.TitleDrop2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleDrop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleDrop2.Location = new System.Drawing.Point(0, 0);
            this.TitleDrop2.Name = "TitleDrop2";
            this.TitleDrop2.Size = new System.Drawing.Size(704, 52);
            this.TitleDrop2.TabIndex = 0;
            this.TitleDrop2.Text = "Перетащите файл(ы) в эту область...";
            this.TitleDrop2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quality_Panel
            // 
            this.Quality_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Quality_Panel.Controls.Add(this.SliderValue);
            this.Quality_Panel.Controls.Add(this.Compression_ratio_bar);
            this.Quality_Panel.Location = new System.Drawing.Point(718, 6);
            this.Quality_Panel.Name = "Quality_Panel";
            this.Quality_Panel.Size = new System.Drawing.Size(55, 451);
            this.Quality_Panel.TabIndex = 5;
            // 
            // SliderValue
            // 
            this.SliderValue.AutoSize = true;
            this.SliderValue.Location = new System.Drawing.Point(3, 0);
            this.SliderValue.Name = "SliderValue";
            this.SliderValue.Size = new System.Drawing.Size(54, 26);
            this.SliderValue.TabIndex = 4;
            this.SliderValue.Text = "Качество\r\n 100%";
            this.SliderValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Compression_ratio_bar
            // 
            this.Compression_ratio_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Compression_ratio_bar.Location = new System.Drawing.Point(11, 29);
            this.Compression_ratio_bar.Maximum = 100;
            this.Compression_ratio_bar.Name = "Compression_ratio_bar";
            this.Compression_ratio_bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Compression_ratio_bar.Size = new System.Drawing.Size(45, 419);
            this.Compression_ratio_bar.TabIndex = 1;
            this.Compression_ratio_bar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Compression_ratio_bar.Value = 100;
            this.Compression_ratio_bar.Scroll += new System.EventHandler(this.Compression_ratio_bar_Scroll);
            // 
            // Main_Buttons_Panel
            // 
            this.Main_Buttons_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Buttons_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_Buttons_Panel.Controls.Add(this.Access_compress_lbl);
            this.Main_Buttons_Panel.Controls.Add(this.ClearDropZone_btn);
            this.Main_Buttons_Panel.Controls.Add(this.SaveImg_btn);
            this.Main_Buttons_Panel.Location = new System.Drawing.Point(4, 484);
            this.Main_Buttons_Panel.Name = "Main_Buttons_Panel";
            this.Main_Buttons_Panel.Size = new System.Drawing.Size(776, 41);
            this.Main_Buttons_Panel.TabIndex = 11;
            // 
            // Access_compress_lbl
            // 
            this.Access_compress_lbl.AutoSize = true;
            this.Access_compress_lbl.Location = new System.Drawing.Point(345, 14);
            this.Access_compress_lbl.Name = "Access_compress_lbl";
            this.Access_compress_lbl.Size = new System.Drawing.Size(0, 13);
            this.Access_compress_lbl.TabIndex = 7;
            // 
            // ClearDropZone_btn
            // 
            this.ClearDropZone_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearDropZone_btn.Enabled = false;
            this.ClearDropZone_btn.Location = new System.Drawing.Point(654, 6);
            this.ClearDropZone_btn.Name = "ClearDropZone_btn";
            this.ClearDropZone_btn.Size = new System.Drawing.Size(117, 28);
            this.ClearDropZone_btn.TabIndex = 6;
            this.ClearDropZone_btn.Text = "Очистить дропзону";
            this.ClearDropZone_btn.UseVisualStyleBackColor = true;
            this.ClearDropZone_btn.Click += new System.EventHandler(this.ClearDropZone_btn_Click);
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
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(256, 256);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 528);
            this.Controls.Add(this.Main_Buttons_Panel);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "ProgramForm";
            this.Text = "Image Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgramForm_FormClosing);
            this.Load += new System.EventHandler(this.ProgramForm_Load);
            this.TabControl.ResumeLayout(false);
            this.Convert_Img_Page.ResumeLayout(false);
            this.Convert_Img_Page.PerformLayout();
            this.DropZone.ResumeLayout(false);
            this.ConvertTo_Panel.ResumeLayout(false);
            this.ConvertTo_Panel.PerformLayout();
            this.ChangeResolutionIcon_Panel.ResumeLayout(false);
            this.ChangeResolutionIcon_Panel.PerformLayout();
            this.Edit_Img_Page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.DropZone2.ResumeLayout(false);
            this.Quality_Panel.ResumeLayout(false);
            this.Quality_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Compression_ratio_bar)).EndInit();
            this.Main_Buttons_Panel.ResumeLayout(false);
            this.Main_Buttons_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Convert_Img_Page;
        private System.Windows.Forms.TabPage Edit_Img_Page;
        private System.Windows.Forms.TextBox txtPathFile;
        private System.Windows.Forms.Panel ConvertSettings_Panel;
        private System.Windows.Forms.Panel ConvertTo_Panel;
        private System.Windows.Forms.ComboBox ImgExtension;
        private System.Windows.Forms.Label ConvertTo_lbl;
        private System.Windows.Forms.Panel ChangeResolutionIcon_Panel;
        private System.Windows.Forms.Label Resolution_lbl;
        private System.Windows.Forms.ComboBox sizeX;
        private System.Windows.Forms.TrackBar Compression_ratio_bar;
        private System.Windows.Forms.Panel Main_Buttons_Panel;
        private System.Windows.Forms.Button SaveImg_btn;
        private System.Windows.Forms.Label SliderValue;
        private System.Windows.Forms.Panel Quality_Panel;
        private System.Windows.Forms.Panel DropZone;
        private System.Windows.Forms.Label TitleDrop;
        private System.Windows.Forms.Panel DropZone2;
        private System.Windows.Forms.Label TitleDrop2;
        private System.Windows.Forms.Button ClearDropZone_btn;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Label Access_compress_lbl;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}

