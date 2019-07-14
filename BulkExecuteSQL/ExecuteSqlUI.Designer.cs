namespace BulkExecuteSQL
{
    partial class ExecuteSqlUI
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
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.labelFilePathDisplay = new System.Windows.Forms.Label();
            this.textBoxDelimiter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorkerExecuteSQL = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgressDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(12, 12);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(94, 23);
            this.buttonSelectFile.TabIndex = 0;
            this.buttonSelectFile.Text = "Select SQL File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.ButtonSelectFile_Click);
            // 
            // labelFilePathDisplay
            // 
            this.labelFilePathDisplay.AutoSize = true;
            this.labelFilePathDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilePathDisplay.Location = new System.Drawing.Point(12, 38);
            this.labelFilePathDisplay.Name = "labelFilePathDisplay";
            this.labelFilePathDisplay.Size = new System.Drawing.Size(79, 13);
            this.labelFilePathDisplay.TabIndex = 1;
            this.labelFilePathDisplay.Text = "FilePathDisplay";
            // 
            // textBoxDelimiter
            // 
            this.textBoxDelimiter.Location = new System.Drawing.Point(167, 14);
            this.textBoxDelimiter.Name = "textBoxDelimiter";
            this.textBoxDelimiter.Size = new System.Drawing.Size(27, 20);
            this.textBoxDelimiter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delimiter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cnx String";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(117, 54);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(404, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 7;
            // 
            // labelProgressDisplay
            // 
            this.labelProgressDisplay.AutoSize = true;
            this.labelProgressDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressDisplay.Location = new System.Drawing.Point(115, 78);
            this.labelProgressDisplay.Name = "labelProgressDisplay";
            this.labelProgressDisplay.Size = new System.Drawing.Size(54, 13);
            this.labelProgressDisplay.TabIndex = 8;
            this.labelProgressDisplay.Text = "Progress: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 100);
            this.Controls.Add(this.labelProgressDisplay);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDelimiter);
            this.Controls.Add(this.labelFilePathDisplay);
            this.Controls.Add(this.buttonSelectFile);
            this.Name = "Form1";
            this.Text = "Execute SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Label labelFilePathDisplay;
        private System.Windows.Forms.TextBox textBoxDelimiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerExecuteSQL;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgressDisplay;
    }
}

