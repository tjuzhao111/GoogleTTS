namespace GoogleTTS
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.enRadioButton = new System.Windows.Forms.RadioButton();
            this.zhRadioButton = new System.Windows.Forms.RadioButton();
            this.jpRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chapterTextBox = new System.Windows.Forms.TextBox();
            this.tipsLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.playCheckBox = new System.Windows.Forms.CheckBox();
            this.mThreadCheckBox = new System.Windows.Forms.CheckBox();
            this.saveCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sourceTextBox.Location = new System.Drawing.Point(13, 13);
            this.sourceTextBox.Multiline = true;
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sourceTextBox.Size = new System.Drawing.Size(501, 239);
            this.sourceTextBox.TabIndex = 0;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(425, 259);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(89, 24);
            this.convert.TabIndex = 1;
            this.convert.Text = "Go";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // enRadioButton
            // 
            this.enRadioButton.AutoSize = true;
            this.enRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.enRadioButton.Location = new System.Drawing.Point(295, 262);
            this.enRadioButton.Name = "enRadioButton";
            this.enRadioButton.Size = new System.Drawing.Size(65, 16);
            this.enRadioButton.TabIndex = 2;
            this.enRadioButton.Text = "English";
            this.enRadioButton.UseVisualStyleBackColor = false;
            this.enRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // zhRadioButton
            // 
            this.zhRadioButton.AutoSize = true;
            this.zhRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.zhRadioButton.Checked = true;
            this.zhRadioButton.Location = new System.Drawing.Point(247, 262);
            this.zhRadioButton.Name = "zhRadioButton";
            this.zhRadioButton.Size = new System.Drawing.Size(47, 16);
            this.zhRadioButton.TabIndex = 3;
            this.zhRadioButton.TabStop = true;
            this.zhRadioButton.Text = "中文";
            this.zhRadioButton.UseVisualStyleBackColor = false;
            this.zhRadioButton.CheckedChanged += new System.EventHandler(this.zhRadioButton_CheckedChanged);
            // 
            // jpRadioButton
            // 
            this.jpRadioButton.AutoSize = true;
            this.jpRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.jpRadioButton.Location = new System.Drawing.Point(360, 262);
            this.jpRadioButton.Name = "jpRadioButton";
            this.jpRadioButton.Size = new System.Drawing.Size(59, 16);
            this.jpRadioButton.TabIndex = 4;
            this.jpRadioButton.Text = "日本語";
            this.jpRadioButton.UseVisualStyleBackColor = false;
            this.jpRadioButton.CheckedChanged += new System.EventHandler(this.jpRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "章节序号:";
            // 
            // chapterTextBox
            // 
            this.chapterTextBox.Location = new System.Drawing.Point(86, 259);
            this.chapterTextBox.Name = "chapterTextBox";
            this.chapterTextBox.Size = new System.Drawing.Size(143, 21);
            this.chapterTextBox.TabIndex = 6;
            // 
            // tipsLabel
            // 
            this.tipsLabel.AutoSize = true;
            this.tipsLabel.BackColor = System.Drawing.Color.Transparent;
            this.tipsLabel.Font = new System.Drawing.Font("宋体", 9F);
            this.tipsLabel.Location = new System.Drawing.Point(11, 342);
            this.tipsLabel.Name = "tipsLabel";
            this.tipsLabel.Size = new System.Drawing.Size(173, 12);
            this.tipsLabel.TabIndex = 7;
            this.tipsLabel.Text = "提示: 章节序号默认为当前时间";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Location = new System.Drawing.Point(12, 369);
            this.statusLabel.MaximumSize = new System.Drawing.Size(300, 12);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(77, 12);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "点击Go开始！";
            // 
            // playCheckBox
            // 
            this.playCheckBox.AutoSize = true;
            this.playCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.playCheckBox.Location = new System.Drawing.Point(329, 296);
            this.playCheckBox.Name = "playCheckBox";
            this.playCheckBox.Size = new System.Drawing.Size(84, 16);
            this.playCheckBox.TabIndex = 9;
            this.playCheckBox.Text = "完成后预览";
            this.playCheckBox.UseVisualStyleBackColor = false;
            this.playCheckBox.CheckedChanged += new System.EventHandler(this.playCheckBox_CheckedChanged);
            // 
            // mThreadCheckBox
            // 
            this.mThreadCheckBox.AutoSize = true;
            this.mThreadCheckBox.Location = new System.Drawing.Point(329, 319);
            this.mThreadCheckBox.Name = "mThreadCheckBox";
            this.mThreadCheckBox.Size = new System.Drawing.Size(84, 16);
            this.mThreadCheckBox.TabIndex = 10;
            this.mThreadCheckBox.Text = "启用多线程";
            this.mThreadCheckBox.UseVisualStyleBackColor = true;
            this.mThreadCheckBox.CheckedChanged += new System.EventHandler(this.mThreadCheckBox_CheckedChanged);
            // 
            // saveCheckBox
            // 
            this.saveCheckBox.AutoSize = true;
            this.saveCheckBox.Checked = true;
            this.saveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveCheckBox.Location = new System.Drawing.Point(329, 342);
            this.saveCheckBox.Name = "saveCheckBox";
            this.saveCheckBox.Size = new System.Drawing.Size(96, 16);
            this.saveCheckBox.TabIndex = 11;
            this.saveCheckBox.Text = "保留合并文件";
            this.saveCheckBox.UseVisualStyleBackColor = true;
            this.saveCheckBox.CheckedChanged += new System.EventHandler(this.saveCheckBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "自定义分节符:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 21);
            this.textBox1.TabIndex = 14;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(528, 389);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveCheckBox);
            this.Controls.Add(this.mThreadCheckBox);
            this.Controls.Add(this.playCheckBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.tipsLabel);
            this.Controls.Add(this.chapterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jpRadioButton);
            this.Controls.Add(this.zhRadioButton);
            this.Controls.Add(this.enRadioButton);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.sourceTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "谷歌娘";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.RadioButton enRadioButton;
        private System.Windows.Forms.RadioButton zhRadioButton;
        private System.Windows.Forms.RadioButton jpRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chapterTextBox;
        private System.Windows.Forms.Label tipsLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox playCheckBox;
        private System.Windows.Forms.CheckBox mThreadCheckBox;
        private System.Windows.Forms.CheckBox saveCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

