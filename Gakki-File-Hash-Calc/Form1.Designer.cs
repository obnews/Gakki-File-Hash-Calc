namespace GakkiFileHashCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBoxIsAppend = new System.Windows.Forms.CheckBox();
            this.checkBoxCRC32 = new System.Windows.Forms.CheckBox();
            this.checkBoxSHA512 = new System.Windows.Forms.CheckBox();
            this.checkBoxSHA256 = new System.Windows.Forms.CheckBox();
            this.checkBoxMD5 = new System.Windows.Forms.CheckBox();
            this.checkBoxSHA1 = new System.Windows.Forms.CheckBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxCodeDump = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxIsAppend);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxCRC32);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxSHA512);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxSHA256);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxMD5);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxSHA1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOpenFile);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStart);
            this.splitContainer1.Panel1.Controls.Add(this.buttonClose);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCodeDump);
            this.splitContainer1.Size = new System.Drawing.Size(1060, 450);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.Location = new System.Drawing.Point(13, 415);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkBoxIsAppend
            // 
            this.checkBoxIsAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxIsAppend.AutoSize = true;
            this.checkBoxIsAppend.Checked = true;
            this.checkBoxIsAppend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsAppend.Location = new System.Drawing.Point(13, 356);
            this.checkBoxIsAppend.Name = "checkBoxIsAppend";
            this.checkBoxIsAppend.Size = new System.Drawing.Size(73, 21);
            this.checkBoxIsAppend.TabIndex = 5;
            this.checkBoxIsAppend.Text = "Append";
            this.checkBoxIsAppend.UseVisualStyleBackColor = true;
            // 
            // checkBoxCRC32
            // 
            this.checkBoxCRC32.AutoSize = true;
            this.checkBoxCRC32.Location = new System.Drawing.Point(12, 120);
            this.checkBoxCRC32.Name = "checkBoxCRC32";
            this.checkBoxCRC32.Size = new System.Drawing.Size(65, 21);
            this.checkBoxCRC32.TabIndex = 3;
            this.checkBoxCRC32.Text = "CRC32";
            this.checkBoxCRC32.UseVisualStyleBackColor = true;
            // 
            // checkBoxSHA512
            // 
            this.checkBoxSHA512.AutoSize = true;
            this.checkBoxSHA512.Location = new System.Drawing.Point(12, 93);
            this.checkBoxSHA512.Name = "checkBoxSHA512";
            this.checkBoxSHA512.Size = new System.Drawing.Size(72, 21);
            this.checkBoxSHA512.TabIndex = 3;
            this.checkBoxSHA512.Text = "SHA512";
            this.checkBoxSHA512.UseVisualStyleBackColor = true;
            // 
            // checkBoxSHA256
            // 
            this.checkBoxSHA256.AutoSize = true;
            this.checkBoxSHA256.Location = new System.Drawing.Point(12, 66);
            this.checkBoxSHA256.Name = "checkBoxSHA256";
            this.checkBoxSHA256.Size = new System.Drawing.Size(72, 21);
            this.checkBoxSHA256.TabIndex = 3;
            this.checkBoxSHA256.Text = "SHA256";
            this.checkBoxSHA256.UseVisualStyleBackColor = true;
            // 
            // checkBoxMD5
            // 
            this.checkBoxMD5.AutoSize = true;
            this.checkBoxMD5.Checked = true;
            this.checkBoxMD5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMD5.Location = new System.Drawing.Point(12, 12);
            this.checkBoxMD5.Name = "checkBoxMD5";
            this.checkBoxMD5.Size = new System.Drawing.Size(55, 21);
            this.checkBoxMD5.TabIndex = 4;
            this.checkBoxMD5.Text = "MD5";
            this.checkBoxMD5.UseVisualStyleBackColor = true;
            // 
            // checkBoxSHA1
            // 
            this.checkBoxSHA1.AutoSize = true;
            this.checkBoxSHA1.Checked = true;
            this.checkBoxSHA1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSHA1.Location = new System.Drawing.Point(12, 39);
            this.checkBoxSHA1.Name = "checkBoxSHA1";
            this.checkBoxSHA1.Size = new System.Drawing.Size(58, 21);
            this.checkBoxSHA1.TabIndex = 3;
            this.checkBoxSHA1.Text = "SHA1";
            this.checkBoxSHA1.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 386);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Open";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.Location = new System.Drawing.Point(93, 386);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(93, 415);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCodeDump
            // 
            this.textBoxCodeDump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCodeDump.Font = new System.Drawing.Font("DejaVu Sans Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCodeDump.Location = new System.Drawing.Point(0, 0);
            this.textBoxCodeDump.Multiline = true;
            this.textBoxCodeDump.Name = "textBoxCodeDump";
            this.textBoxCodeDump.ReadOnly = true;
            this.textBoxCodeDump.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCodeDump.Size = new System.Drawing.Size(887, 450);
            this.textBoxCodeDump.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gakki File Hash Calc by Wen Bo <wenbo222@gmail.com>";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxCodeDump;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxMD5;
        private System.Windows.Forms.CheckBox checkBoxSHA1;
        private System.Windows.Forms.CheckBox checkBoxSHA512;
        private System.Windows.Forms.CheckBox checkBoxSHA256;
        private System.Windows.Forms.CheckBox checkBoxCRC32;
        private System.Windows.Forms.CheckBox checkBoxIsAppend;
        private System.Windows.Forms.Button buttonClear;
    }
}

