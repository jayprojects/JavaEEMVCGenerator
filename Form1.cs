using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using JavaEEMVCGenerator.codeGen;
using System.Globalization;
using System.Text.RegularExpressions;
namespace JavaEEMVCGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        List<TColumn> local_columnNames;
        private void buttonConnect_Click(object sender, EventArgs e)
        {

            global.packageName = "mypackage";
            global.serverName = textBoxServer.Text;
            global.user = textBoxUser.Text;
            global.password = textBoxPasswrod.Text;
            global.port = textBoxPort.Text;

            global.dbName = textBoxDatabase.Text;
            global.tblName = textBoxTable.Text;
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            global.classNameLow = global.tblName.Substring(0, global.tblName.Length - 1);
            global.className = myTI.ToTitleCase(global.classNameLow);
            global.connectionString = "Server=" + textBoxServer.Text + "; " +
                                "Database=" + textBoxDatabase.Text + "; " +
                                "User ID=" + textBoxUser.Text + "; " +
                                "Password=" + textBoxPasswrod.Text + "; ";

            DataTable dt = DbUtill.executeQuery("select * from "+global.dbName+".dbo."+global.tblName);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            panelColumns.BackColor = Color.Gray;
            local_columnNames = DbUtill.getColumnNames(textBoxDatabase.Text, textBoxTable.Text);
            int x = 10;
            int y = 10;
            foreach (TColumn columnName in local_columnNames)
            {
                x = 10;
                CreateCheckBox(columnName.ColumnName,columnName.SerialNo+". "+ columnName.ColumnName, x, y);
                x = x + 150;
                CreateComboBox(columnName.ColumnName, columnName.csType, x, y);
                y = y + 25;
            }
            buttonCreate.Enabled = true;
        }

        private void check_click(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            int n = int.Parse(b.Text.Substring(0,1))-1;
            local_columnNames.RemoveAt(n);

            
        }
        private void combo_click(object sender, EventArgs e)
        {
            ComboBox b = (ComboBox)sender;
            //int n = int.Parse(b.Text.Substring(0, 1)) - 1;
            //local_columnNames.RemoveAt(n);


        }
        public void CreateCheckBox(string name, string text, int x, int y)
        {
            
            CheckBox checkbox = new CheckBox();
            checkbox.Location = new Point(x, y);
            checkbox.Name = "chkBox_" + text;
            checkbox.Height = 20;
            checkbox.Width = 150;
            checkbox.Text = text;
            
            checkbox.Checked = true;
            checkbox.Click += new System.EventHandler(check_click);
            panelColumns.Controls.Add(checkbox);
        }

        public void CreateComboBox(string name, string text, int x, int y)
        {
        
            ComboBox comboBox = new ComboBox();
            comboBox.Location = new Point(x, y);
            comboBox.Name = "comBox_" + text;
            comboBox.Text = text;
            comboBox.Height = 20;
            comboBox.Width = 80;
            comboBox.Items.Add("int");
            comboBox.Items.Add("string");
            comboBox.Items.Add("bool");
            comboBox.Items.Add("date");
            comboBox.Click += new System.EventHandler(combo_click);
            panelColumns.Controls.Add(comboBox);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            global.columnNames = local_columnNames;
            
            Form2 f2 = new Form2();

            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            local_columnNames = new List<TColumn>();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
