namespace JavaEEMVCGenerator
{
    partial class Form2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOutputDir = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPackage = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-3, 145);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(467, 115);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output Dir";
            // 
            // textBoxOutputDir
            // 
            this.textBoxOutputDir.Location = new System.Drawing.Point(108, 18);
            this.textBoxOutputDir.Name = "textBoxOutputDir";
            this.textBoxOutputDir.Size = new System.Drawing.Size(140, 20);
            this.textBoxOutputDir.TabIndex = 3;
            this.textBoxOutputDir.Text = "c:\\";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(254, 16);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(59, 22);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Package Name:";
            // 
            // textBoxPackage
            // 
            this.textBoxPackage.Location = new System.Drawing.Point(108, 56);
            this.textBoxPackage.Name = "textBoxPackage";
            this.textBoxPackage.Size = new System.Drawing.Size(140, 20);
            this.textBoxPackage.TabIndex = 6;
            this.textBoxPackage.Text = "myproject";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(17, 95);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(124, 35);
            this.buttonGenerate.TabIndex = 7;
            this.buttonGenerate.Text = "Generate Code Files";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 263);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxPackage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxOutputDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form2";
            this.Text = "Generate Code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOutputDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPackage;
        private System.Windows.Forms.Button buttonGenerate;
    }
}