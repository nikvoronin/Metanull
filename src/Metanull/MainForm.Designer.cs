namespace Metanull
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nullItButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sourceFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.destFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.waitTimer = new System.Windows.Forms.Timer(this.components);
            this.sourceFolderTreeCheckBox = new System.Windows.Forms.CheckBox();
            this.destFolderButton = new System.Windows.Forms.Button();
            this.destFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recursiveCheckBox = new System.Windows.Forms.CheckBox();
            this.batchFolderBrowseButton = new System.Windows.Forms.Button();
            this.singleFileSelectButton = new System.Windows.Forms.Button();
            this.batchFolderTextBox = new System.Windows.Forms.TextBox();
            this.batchFolderRadio = new System.Windows.Forms.RadioButton();
            this.singleFileRadio = new System.Windows.Forms.RadioButton();
            this.singleFileTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "3";
            // 
            // nullItButton
            // 
            this.nullItButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nullItButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.nullItButton.ForeColor = System.Drawing.Color.Black;
            this.nullItButton.Location = new System.Drawing.Point(405, 194);
            this.nullItButton.Name = "nullItButton";
            this.nullItButton.Size = new System.Drawing.Size(75, 23);
            this.nullItButton.TabIndex = 14;
            this.nullItButton.Text = "Null It!";
            this.nullItButton.UseVisualStyleBackColor = true;
            this.nullItButton.Click += new System.EventHandler(this.nullItButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(55, 194);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(263, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 16;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPG, JPEG (*.jpg, *.jpeg)|*.jp*g";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.BackColor = System.Drawing.Color.Black;
            this.logTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.logTextBox.Location = new System.Drawing.Point(55, 223);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(425, 95);
            this.logTextBox.TabIndex = 17;
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(324, 194);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 18;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // waitTimer
            // 
            this.waitTimer.Interval = 300;
            this.waitTimer.Tick += new System.EventHandler(this.waitTimer_Tick);
            // 
            // sourceFolderTreeCheckBox
            // 
            this.sourceFolderTreeCheckBox.AutoSize = true;
            this.sourceFolderTreeCheckBox.Checked = true;
            this.sourceFolderTreeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sourceFolderTreeCheckBox.Location = new System.Drawing.Point(151, 162);
            this.sourceFolderTreeCheckBox.Name = "sourceFolderTreeCheckBox";
            this.sourceFolderTreeCheckBox.Size = new System.Drawing.Size(159, 17);
            this.sourceFolderTreeCheckBox.TabIndex = 26;
            this.sourceFolderTreeCheckBox.Text = "Recreate source folder tree";
            this.sourceFolderTreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // destFolderButton
            // 
            this.destFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.destFolderButton.Location = new System.Drawing.Point(405, 134);
            this.destFolderButton.Name = "destFolderButton";
            this.destFolderButton.Size = new System.Drawing.Size(75, 23);
            this.destFolderButton.TabIndex = 25;
            this.destFolderButton.Text = "Browse...";
            this.destFolderButton.UseVisualStyleBackColor = true;
            this.destFolderButton.Click += new System.EventHandler(this.destFolderButton_Click);
            // 
            // destFolderTextBox
            // 
            this.destFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.destFolderTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.destFolderTextBox.Location = new System.Drawing.Point(151, 136);
            this.destFolderTextBox.Name = "destFolderTextBox";
            this.destFolderTextBox.ReadOnly = true;
            this.destFolderTextBox.Size = new System.Drawing.Size(248, 20);
            this.destFolderTextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(52, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Copy result image(s) to";
            // 
            // recursiveCheckBox
            // 
            this.recursiveCheckBox.AutoSize = true;
            this.recursiveCheckBox.Checked = true;
            this.recursiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.recursiveCheckBox.Location = new System.Drawing.Point(151, 86);
            this.recursiveCheckBox.Name = "recursiveCheckBox";
            this.recursiveCheckBox.Size = new System.Drawing.Size(124, 17);
            this.recursiveCheckBox.TabIndex = 34;
            this.recursiveCheckBox.Text = "Also scan subfolders";
            this.recursiveCheckBox.UseVisualStyleBackColor = true;
            this.recursiveCheckBox.CheckedChanged += new System.EventHandler(this.recursiveCheckBox_CheckedChanged);
            // 
            // batchFolderBrowseButton
            // 
            this.batchFolderBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.batchFolderBrowseButton.Location = new System.Drawing.Point(405, 58);
            this.batchFolderBrowseButton.Name = "batchFolderBrowseButton";
            this.batchFolderBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.batchFolderBrowseButton.TabIndex = 33;
            this.batchFolderBrowseButton.Text = "Browse...";
            this.batchFolderBrowseButton.UseVisualStyleBackColor = true;
            this.batchFolderBrowseButton.Click += new System.EventHandler(this.batchFolderBrowseButton_Click);
            // 
            // singleFileSelectButton
            // 
            this.singleFileSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.singleFileSelectButton.Location = new System.Drawing.Point(405, 29);
            this.singleFileSelectButton.Name = "singleFileSelectButton";
            this.singleFileSelectButton.Size = new System.Drawing.Size(75, 23);
            this.singleFileSelectButton.TabIndex = 32;
            this.singleFileSelectButton.Text = "Select...";
            this.singleFileSelectButton.UseVisualStyleBackColor = true;
            this.singleFileSelectButton.Click += new System.EventHandler(this.singleFileSelectButton_Click);
            // 
            // batchFolderTextBox
            // 
            this.batchFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.batchFolderTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.batchFolderTextBox.Location = new System.Drawing.Point(151, 60);
            this.batchFolderTextBox.Name = "batchFolderTextBox";
            this.batchFolderTextBox.ReadOnly = true;
            this.batchFolderTextBox.Size = new System.Drawing.Size(248, 20);
            this.batchFolderTextBox.TabIndex = 31;
            this.batchFolderTextBox.TextChanged += new System.EventHandler(this.batchFolderTextBox_TextChanged);
            // 
            // batchFolderRadio
            // 
            this.batchFolderRadio.AutoSize = true;
            this.batchFolderRadio.Location = new System.Drawing.Point(58, 61);
            this.batchFolderRadio.Name = "batchFolderRadio";
            this.batchFolderRadio.Size = new System.Drawing.Size(87, 17);
            this.batchFolderRadio.TabIndex = 30;
            this.batchFolderRadio.TabStop = true;
            this.batchFolderRadio.Text = "Batch folder:";
            this.batchFolderRadio.UseVisualStyleBackColor = true;
            // 
            // singleFileRadio
            // 
            this.singleFileRadio.AutoSize = true;
            this.singleFileRadio.Location = new System.Drawing.Point(58, 35);
            this.singleFileRadio.Name = "singleFileRadio";
            this.singleFileRadio.Size = new System.Drawing.Size(74, 17);
            this.singleFileRadio.TabIndex = 29;
            this.singleFileRadio.TabStop = true;
            this.singleFileRadio.Text = "Single file:";
            this.singleFileRadio.UseVisualStyleBackColor = true;
            this.singleFileRadio.CheckedChanged += new System.EventHandler(this.singleFileRadio_CheckedChanged);
            // 
            // singleFileTextBox
            // 
            this.singleFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.singleFileTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.singleFileTextBox.Location = new System.Drawing.Point(151, 32);
            this.singleFileTextBox.Name = "singleFileTextBox";
            this.singleFileTextBox.ReadOnly = true;
            this.singleFileTextBox.Size = new System.Drawing.Size(248, 20);
            this.singleFileTextBox.TabIndex = 28;
            this.singleFileTextBox.TextChanged += new System.EventHandler(this.singleFileTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(52, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Source image(s)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 330);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recursiveCheckBox);
            this.Controls.Add(this.batchFolderBrowseButton);
            this.Controls.Add(this.singleFileSelectButton);
            this.Controls.Add(this.batchFolderTextBox);
            this.Controls.Add(this.batchFolderRadio);
            this.Controls.Add(this.singleFileRadio);
            this.Controls.Add(this.singleFileTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceFolderTreeCheckBox);
            this.Controls.Add(this.destFolderButton);
            this.Controls.Add(this.destFolderTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.nullItButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(427, 339);
            this.Name = "MainForm";
            this.Text = "Metanull";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button nullItButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog sourceFolderDialog;
        private System.Windows.Forms.FolderBrowserDialog destFolderDialog;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer waitTimer;
        private System.Windows.Forms.CheckBox sourceFolderTreeCheckBox;
        private System.Windows.Forms.Button destFolderButton;
        private System.Windows.Forms.TextBox destFolderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox recursiveCheckBox;
        private System.Windows.Forms.Button batchFolderBrowseButton;
        private System.Windows.Forms.Button singleFileSelectButton;
        private System.Windows.Forms.TextBox batchFolderTextBox;
        private System.Windows.Forms.RadioButton batchFolderRadio;
        private System.Windows.Forms.RadioButton singleFileRadio;
        private System.Windows.Forms.TextBox singleFileTextBox;
        private System.Windows.Forms.Label label4;
    }
}

