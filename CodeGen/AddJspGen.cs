using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JavaEEMVCGenerator.codeGen
{
    public class AddJspGen
    {

        public static string generate()
        {
            List<TColumn> tcs = global.columnNames;
            StringBuilder sb = new StringBuilder();
            

            sb.AppendLine("<html>"); 
            sb.AppendLine("<head>"); 
            sb.AppendLine("  <title>Add a new "+global.className+"</title>"); 
            sb.AppendLine("</head>"); 
            sb.AppendLine("<body>"); 
            sb.AppendLine("<h2>Add a new "+global.className+"</h2>"); 
            sb.AppendLine("<form action=\""+global.className+".do\" method=\"post\">"); 
            sb.AppendLine("  <input type=\"hidden\" name=\"current_action\" value=\"Add\">"); 
            sb.AppendLine("  <input type=\"hidden\" name=\"current_page\" value=\""+global.className+"Add.jsp\">"); 
            sb.AppendLine(""); 
            sb.AppendLine("  <table>");

         

            foreach (TColumn tc in tcs)
            {
                sb.AppendLine("    <tr>");
                sb.AppendLine("      <td align=left valign=top>");
                sb.AppendLine("        <b>" + tc.ColumnNameTitleCase + ":</b>");
                sb.AppendLine("      </td>");
                sb.AppendLine("      <td align=left valign=top>");
                sb.AppendLine("        <input type=\"text\" name=\"" + tc.ColumnName + "\">");
                sb.AppendLine("      </td>");
                sb.AppendLine("    </tr>"); 
            }

           
            sb.AppendLine("      <tr>"); 
            sb.AppendLine("      <td align=left valign=top>"); 
            sb.AppendLine("         "); 
            sb.AppendLine("      </td>"); 
            sb.AppendLine("      <td align=left valign=top>"); 
            sb.AppendLine("      <input type=submit name=\"ADD\" value=\"  Add  \">"); 
            sb.AppendLine("      <input type=\"button\" value=\"Cancel\">"); 
            sb.AppendLine("      </td>"); 
            sb.AppendLine("    </tr>"); 
            sb.AppendLine("  </table>"); 
            sb.AppendLine(""); 
            sb.AppendLine("</form>"); 
            sb.AppendLine("</body>"); 
            sb.AppendLine("</html>");
            sb.AppendLine("");


            return sb.ToString();
        }
    }
}
