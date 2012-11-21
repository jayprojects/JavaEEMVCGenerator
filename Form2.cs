/**
 * @author Jay Das <jay11421@gmail.com>
 * @copyright 2012 Jay Das
 * @namespace JavaEEMVCGenerator
 */

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
using JavaEEMVCGenerator.CodeGen;
using System.IO;
namespace JavaEEMVCGenerator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
 
      
        
        void saveFile(string folderPath, string fileName, string text)
        {
            string filePath = Path.Combine(folderPath, fileName);
            richTextBox1.AppendText("Saving File " + filePath + Environment.NewLine);
            if (!File.Exists(filePath))
            {
                using (StreamWriter outfile = new StreamWriter(filePath, true))
                {
                    outfile.Write(text);
                }
            }
        }

        string makeFolder(string folderPath, string folderName)
        {
            string newPath = Path.Combine(folderPath, folderName);
            richTextBox1.AppendText("Creating Folder " + newPath + Environment.NewLine);
            Directory.CreateDirectory(newPath);
            return newPath;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBoxOutputDir.Text = folderBrowserDialog1.SelectedPath;
        }
       

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            //string global.classNameLow = global.tblName.Substring(0, global.tblName.Length - 1);
            //string global.className = myTI.ToTitleCase(global.classNameLow);
            global.packageName = textBoxPackage.Text;
            string outputPath = textBoxOutputDir.Text;
            
            //Folder src
            string newPath =  makeFolder(outputPath, "crud");
            newPath = makeFolder(newPath, "src");
            newPath = makeFolder(newPath, global.packageName);
            //create javafileher
            saveFile(newPath, global.className + ".java", ModelGen.generate());
            saveFile(newPath, "DBConnection.java", DBConGen.generate());
            saveFile(newPath, global.className + "Controll.java", ControllerGen.generate());
            saveFile(newPath, global.className + "DbUtill.java", DBUtillGen.generate());

            //Folder WebContent
            newPath = Path.Combine(outputPath, "crud");
            newPath = makeFolder(newPath, "WebContent");
            //create jsp here
            saveFile(newPath, global.className + "Add.jsp", AddJspGen.generate());
            saveFile(newPath, global.className + "Update.jsp", UpdateJspGen.generate());
            saveFile(newPath, global.className + "View.jsp", ViewJspGen.generate());
            saveFile(newPath, "Index.jsp", IndexJspGen.generate());

            //Folder WEB-INF
            newPath = makeFolder(newPath, "WEB-INF");
            //create web.xml here
            saveFile(newPath, "web.xml", WebXmlGen.generate());

            richTextBox1.AppendText("Project Created!!"+Environment.NewLine);
        }
    }
}
