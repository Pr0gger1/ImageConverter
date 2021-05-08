
namespace ImageConverter
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
            this.OpenFile = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveTo = new System.Windows.Forms.Button();
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.FileExtension = new System.Windows.Forms.ComboBox();
            this.FormatFilePanel = new System.Windows.Forms.Panel();
            this.ResolutionPanel = new System.Windows.Forms.Panel();
            this.ResolutionBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CompRatioBar = new System.Windows.Forms.TrackBar();
            this.SliderValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SetFolderToSave = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            this.FormatFilePanel.SuspendLayout();
            this.ResolutionPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompRatioBar)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(99, 3);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(90, 30);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Open";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveTo
            // 
            this.SaveTo.Location = new System.Drawing.Point(3, 3);
            this.SaveTo.Name = "SaveTo";
            this.SaveTo.Size = new System.Drawing.Size(90, 30);
            this.SaveTo.TabIndex = 1;
            this.SaveTo.Text = "Save";
            this.SaveTo.UseVisualStyleBackColor = true;
            this.SaveTo.Click += new System.EventHandler(this.SaveTo_Click);
            // 
            // ImgBox
            // 
            this.ImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImgBox.Location = new System.Drawing.Point(12, 10);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(618, 519);
            this.ImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox.TabIndex = 2;
            this.ImgBox.TabStop = false;
            // 
            // FileExtension
            // 
            this.FileExtension.CausesValidation = false;
            this.FileExtension.Cursor = System.Windows.Forms.Cursors.Default;
            this.FileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileExtension.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FileExtension.FormattingEnabled = true;
            this.FileExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FileExtension.Location = new System.Drawing.Point(108, 45);
            this.FileExtension.Name = "FileExtension";
            this.FileExtension.Size = new System.Drawing.Size(60, 21);
            this.FileExtension.TabIndex = 3;
            this.FileExtension.SelectedIndexChanged += new System.EventHandler(this.FileExtension_SelectedIndexChanged);
            // 
            // FormatFilePanel
            // 
            this.FormatFilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormatFilePanel.Controls.Add(this.ResolutionPanel);
            this.FormatFilePanel.Controls.Add(this.label1);
            this.FormatFilePanel.Controls.Add(this.FileExtension);
            this.FormatFilePanel.Location = new System.Drawing.Point(643, 454);
            this.FormatFilePanel.Name = "FormatFilePanel";
            this.FormatFilePanel.Size = new System.Drawing.Size(175, 75);
            this.FormatFilePanel.TabIndex = 5;
            // 
            // ResolutionPanel
            // 
            this.ResolutionPanel.Controls.Add(this.ResolutionBox);
            this.ResolutionPanel.Controls.Add(this.label2);
            this.ResolutionPanel.Location = new System.Drawing.Point(6, 3);
            this.ResolutionPanel.Name = "ResolutionPanel";
            this.ResolutionPanel.Size = new System.Drawing.Size(162, 28);
            this.ResolutionPanel.TabIndex = 10;
            this.ResolutionPanel.Visible = false;
            // 
            // ResolutionBox
            // 
            this.ResolutionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResolutionBox.FormattingEnabled = true;
            this.ResolutionBox.Location = new System.Drawing.Point(91, 3);
            this.ResolutionBox.Name = "ResolutionBox";
            this.ResolutionBox.Size = new System.Drawing.Size(71, 21);
            this.ResolutionBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Разрешение:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Конвертировать в";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 546);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.SaveTo);
            this.flowLayoutPanel2.Controls.Add(this.OpenFile);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(643, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(194, 38);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // CompRatioBar
            // 
            this.CompRatioBar.LargeChange = 10;
            this.CompRatioBar.Location = new System.Drawing.Point(3, 39);
            this.CompRatioBar.Maximum = 100;
            this.CompRatioBar.Name = "CompRatioBar";
            this.CompRatioBar.Size = new System.Drawing.Size(175, 37);
            this.CompRatioBar.TabIndex = 7;
            this.CompRatioBar.Scroll += new System.EventHandler(this.CompRatioBar_Scroll);
            // 
            // SliderValue
            // 
            this.SliderValue.AutoSize = true;
            this.SliderValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.SliderValue.Location = new System.Drawing.Point(40, 10);
            this.SliderValue.Margin = new System.Windows.Forms.Padding(40, 10, 40, 0);
            this.SliderValue.Name = "SliderValue";
            this.SliderValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SliderValue.Size = new System.Drawing.Size(92, 26);
            this.SliderValue.TabIndex = 8;
            this.SliderValue.Text = "Степень сжатия: 0%";
            this.SliderValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.SliderValue);
            this.flowLayoutPanel1.Controls.Add(this.CompRatioBar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(643, 352);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(175, 80);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 603);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FormatFilePanel);
            this.Controls.Add(this.ImgBox);
            this.Name = "Form1";
            this.Text = "Image Converter";
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            this.FormatFilePanel.ResumeLayout(false);
            this.FormatFilePanel.PerformLayout();
            this.ResolutionPanel.ResumeLayout(false);
            this.ResolutionPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompRatioBar)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button SaveTo;
        private System.Windows.Forms.PictureBox ImgBox;
        private System.Windows.Forms.ComboBox FileExtension;
        private System.Windows.Forms.Panel FormatFilePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ResolutionBox;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.TrackBar CompRatioBar;
        private System.Windows.Forms.Label SliderValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel ResolutionPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FolderBrowserDialog SetFolderToSave;
    }
}

