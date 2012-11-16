using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using JavaEEMVCGenerator.codeGen;
using System.IO;
namespace JavaEEMVCGenerator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
 
      
        void saveFile(string filePath, string text)
        {
            if (!System.IO.File.Exists(filePath))
            {
                using (StreamWriter outfile = new StreamWriter(filePath, true))
                {
                    outfile.Write(text);
                }
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            
            folderBrowserDialog1.ShowDialog();
            textBoxOutputDir.Text = folderBrowserDialog1.SelectedPath;

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            string classNameLow = global.tblName.Substring(0, global.tblName.Length - 1);
            string className = myTI.ToTitleCase(classNameLow);

            
            global.packageName = textBoxPackage.Text;
            string outputPath = textBoxOutputDir.Text;
            string newPath = System.IO.Path.Combine(outputPath, "crud");
            richTextBox1.AppendText("Creating Folder " + newPath+Environment.NewLine);
            System.IO.Directory.CreateDirectory(newPath);

            

            newPath = System.IO.Path.Combine(newPath, "src");
            richTextBox1.AppendText("Creating Folder " + newPath + Environment.NewLine);
            System.IO.Directory.CreateDirectory(newPath);

            newPath = System.IO.Path.Combine(newPath, global.packageName);
            System.IO.Directory.CreateDirectory(newPath);

            //create javafileher
            string filePath = System.IO.Path.Combine(newPath,className+".java");
            richTextBox1.AppendText("Saving File " + filePath + Environment.NewLine);
            saveFile(filePath, ModelGen.generate());
            
            filePath = System.IO.Path.Combine(newPath, "DBConnection.java");
            richTextBox1.AppendText("Saving File " + filePath + Environment.NewLine);
            saveFile(filePath, DBConGen.generate());

            filePath = System.IO.Path.Combine(newPath, className + "Controll.java");
            richTextBox1.AppendText("Saving File " + filePath + Environment.NewLine);
            saveFile(filePath, ControllerGen.generate());

            filePath = System.IO.Path.Combine(newPath, className + "DbUtill.java");
            richTextBox1.AppendText("Saving File " + filePath + Environment.NewLine);
            saveFile(filePath, DBUtillGen.generate());




            newPath = System.IO.Path.Combine(outputPath, "crud");
            newPath = System.IO.Path.Combine(newPath, "WebContent");
            richTextBox1.AppendText("Creating Folder " + newPath + Environment.NewLine);
            System.IO.Directory.CreateDirectory(newPath);
            //create jsp here

            filePath = System.IO.Path.Combine(newPath, className + "Add.jsp");
            richTextBox1.AppendText("Saving File " + filePath + Environment.NewLine);
            saveFile(filePath, AddJspGen.generate());
            filePath = System.IO.Path.Combine(newPath, className + "Update.jsp");
            richTextBox1.AppendText("Saving File " + filePath + Environment.NewLine);
            saveFile(filePath, UpdateJspGen.generate());
            filePath = System.IO.Path.Combine(newPath, className + "View.jsp");
            richTextBox1.AppendText("Saving File " + filePath + Environment.NewLine);
            saveFile(filePath, ViewJspGen.generate());




            

            newPath = System.IO.Path.Combine(newPath, "WEB-INF");
            richTextBox1.AppendText("Creating Folder " + newPath + Environment.NewLine);
            System.IO.Directory.CreateDirectory(newPath);
            //create web.xml here
            filePath = System.IO.Path.Combine(newPath, "web.xml");
            richTextBox1.AppendText("Saving File " + filePath + Environment.NewLine);
            saveFile(filePath, WebXmlGen.generate());


            richTextBox1.AppendText("Project Created!!"+Environment.NewLine);
        }
    }
}
