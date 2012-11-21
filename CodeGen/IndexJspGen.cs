/**
 * @author Jay Das <jay11421@gmail.com>
 * @copyright 2012 Jay Das
 * @namespace JavaEEMVCGenerator.CodeGen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JavaEEMVCGenerator.CodeGen
{
    public class IndexJspGen:BaseGen
    {
        
        public static string generate()
        {
            List<TColumn> tcs = global.columnNames;
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");
            sb.AppendLine("<title>Student CRUD</title>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");
            sb.AppendLine("<h2>Students CRUD</h2>");
            sb.AppendLine("<a href=\"" + global.className + ".do\">Manage Students</a>");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");
            
            return sb.ToString();
            
        }
    }
}


