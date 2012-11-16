using System;
using System.Collections.Generic;
using System.Linq;

using System.Text.RegularExpressions;
using System.Text;

namespace JavaEEMVCGenerator.codeGen
{
    public class UpdateJspGen
    {

        public static string generate()
        {
            List<TColumn> tcs = global.columnNames;
            StringBuilder sb = new StringBuilder();
           

            sb.AppendLine("<%@page import=\"myproject.*\"%>"); 
            sb.AppendLine("<%@page import=\"java.util.*\"%>"); 
            sb.AppendLine(""); 
            sb.AppendLine("<html>"); 
            sb.AppendLine("<head>"); 
            sb.AppendLine("  <title>Update "+global.className+"</title>"); 
            sb.AppendLine("</head>"); 
            sb.AppendLine("<body>"); 
            sb.AppendLine("<h2>Update "+global.className+"</h2>"); 
            sb.AppendLine("<%"); 
            sb.AppendLine(""+global.className+" "+global.classNameLow+" = ("+global.className+") request.getAttribute(\""+global.classNameLow+"\");"); 
            sb.AppendLine("if("+global.classNameLow+"!=null){"); 
            sb.AppendLine("%>"); 
            sb.AppendLine("<form action=\""+global.className+".do\" method=\"post\">"); 
            sb.AppendLine("  <input type=\"hidden\" name=\"current_page\" value=\""+global.className+"Update.jsp\">"); 
            sb.AppendLine("  <input type=\"hidden\" name=\"current_action\" value=\"Update\">");
            sb.AppendLine("  <input type=\"hidden\" name=\"record_id\" value=\"<%=" + global.classNameLow + ".get" + tcs.ElementAt(0).ColumnNameTitleCase + "() %>\">"); 
            sb.AppendLine("  <table>");

            foreach (TColumn tc in tcs)
            {
                sb.AppendLine("    <tr>");
                sb.AppendLine("      <td align=left valign=top>");
                sb.AppendLine("        <b>" + tc.ColumnNameTitleCase + ":</b>");
                sb.AppendLine("      </td>");
                sb.AppendLine("      <td align=left valign=top>");
                sb.AppendLine("        <input type=\"text\" name=\"" + tc.ColumnName + "\" value=\"<%=" + global.classNameLow + ".get" + tc.ColumnNameTitleCase + "() %>\">");
                sb.AppendLine("      </td>");
                sb.AppendLine("    </tr>");
                sb.AppendLine("    <tr>");
            }
            sb.AppendLine("      <td align=left valign=top>"); 
            sb.AppendLine("         "); 
            sb.AppendLine("      </td>"); 
            sb.AppendLine("      <td align=left valign=top>"); 
            sb.AppendLine("      <input type=submit name=\"update\" value=\" Save \">"); 
            sb.AppendLine("      <input type=\"button\" value=\" Cancel \" onClick=\"window.location.href='"+global.className+".do'\">"); 
            sb.AppendLine("      </td>"); 
            sb.AppendLine("    </tr>"); 
            sb.AppendLine("  </table>"); 
            sb.AppendLine("</form>"); 
            sb.AppendLine("<%} %>"); 
            sb.AppendLine("</body>"); 
            sb.AppendLine("</html>");
            sb.AppendLine("");
            sb.AppendLine("");


            return sb.ToString();
        }
    }
}
