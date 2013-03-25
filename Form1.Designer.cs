namespace JavaEEMVCGenerator
{
    partial class Form1
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
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPasswrod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelColumns = new System.Windows.Forms.Panel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(98, 23);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(100, 20);
            this.textBoxServer.TabIndex = 0;
            this.textBoxServer.Text = "localhost";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(98, 52);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.Text = "1434";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(98, 81);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.Text = "sa";
            // 
            // textBoxPasswrod
            // 
            this.textBoxPasswrod.Location = new System.Drawing.Point(98, 110);
            this.textBoxPasswrod.Name = "textBoxPasswrod";
            this.textBoxPasswrod.PasswordChar = '*';
            this.textBoxPasswrod.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasswrod.TabIndex = 3;
            this.textBoxPasswrod.Text = "Admin123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Table";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(98, 139);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatabase.TabIndex = 10;
            this.textBoxDatabase.Text = "sims";
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(98, 168);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(100, 20);
            this.textBoxTable.TabIndex = 11;
            this.textBoxTable.Text = "BCMajors";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(213, 21);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 12;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 455);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(621, 55);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // panelColumns
            // 
            this.panelColumns.Location = new System.Drawing.Point(344, 23);
            this.panelColumns.Name = "panelColumns";
            this.panelColumns.Size = new System.Drawing.Size(296, 165);
            this.panelColumns.TabIndex = 14;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Enabled = false;
            this.buttonCreate.Location = new System.Drawing.Point(213, 50);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 15;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 205);
            this.dataGridView1.TabIndex = 16;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(213, 79);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 522);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.panelColumns);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxTable);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPasswrod);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxServer);
            this.Name = "Form1";
            this.Text = "Java EE MVC Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPasswrod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panelColumns;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExit;
    }
}

