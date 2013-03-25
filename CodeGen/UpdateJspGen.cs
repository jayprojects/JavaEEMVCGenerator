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
    public class UpdateJspGen:BaseGen
    {

        public static string generate()
        {
            List<TColumn> tcs = global.columnNames;
            StringBuilder sb = new StringBuilder();

            
            sb.AppendLine("<%@page import=\"" + global.packageName + ".*\"%>");
            sb.AppendLine("<%@ taglib uri=\"http://java.sun.com/jsp/jstl/core\" prefix=\"c\" %> ");
            sb.AppendLine("<%@ taglib uri=\"http://java.sun.com/jsp/jstl/xml\" prefix=\"x\" %>"); 
            sb.AppendLine(""); 
            sb.AppendLine("<html>"); 
            sb.AppendLine("<head>"); 
            sb.AppendLine("  <title>Update "+global.className+"</title>"); 
            sb.AppendLine("</head>"); 
            sb.AppendLine("<body>"); 
            sb.AppendLine("<h2>Update "+global.className+"</h2>"); 
            sb.AppendLine("<c:choose>");
		    sb.AppendLine("<c:when test='${empty requestScope.bcmajor}'>");
		    sb.AppendLine("    <c:redirect url='Bcmajor.do' />");
		    sb.AppendLine("</c:when>");
            sb.AppendLine("<c:otherwise>");

            sb.AppendLine("<form action=\"" + global.className + ".do\" method=\"post\">");
            sb.AppendLine("  <input type=\"hidden\" name=\"current_page\" value=\"" + global.className + "Update.jsp\">");
            sb.AppendLine("  <input type=\"hidden\" name=\"current_action\" value=\"Update\">");
            sb.AppendLine("  <input type=\"hidden\" name=\"record_id\" value=\"${" + global.classNameLow + "." + tcs.ElementAt(0).ColumnName + "}\">");
            sb.AppendLine("  <table>");



            foreach (TColumn tc in tcs)
            {
                sb.AppendLine("    <tr>");
                sb.AppendLine("      <td align=left valign=top>");
                sb.AppendLine("        <b>" + tc.ColumnNameTitleCase + ":</b>");
                sb.AppendLine("      </td>");
                sb.AppendLine("      <td align=left valign=top>");
                
                sb.AppendLine("        <input type=\"text\" name=\"" + tc.ColumnName
                    + "\" value=\"${" + global.classNameLow + "." + tc.ColumnName + "}\">");
                sb.AppendLine("      </td>");
                sb.AppendLine("    </tr>");
            
            }



            sb.AppendLine("    <tr>");
            sb.AppendLine("      <td align=left valign=top>");
            sb.AppendLine("         ");
            sb.AppendLine("      </td>");
            sb.AppendLine("      <td align=left valign=top>");
            sb.AppendLine("      <input type=submit name=\"update\" value=\" Save \">&nbsp;");
            sb.AppendLine("      <input type=\"button\" value=\" Cancel \" onClick=\"window.location.href='" + global.className + ".do'\">");
            sb.AppendLine("      </td>");
            sb.AppendLine("    </tr>");
            sb.AppendLine("  </table>");
            sb.AppendLine("</form>"); 
            sb.AppendLine("</c:otherwise>");
            sb.AppendLine("</c:choose>");

            sb.AppendLine("</body>"); 
            sb.AppendLine("</html>");
            sb.AppendLine("");
            sb.AppendLine("");


            return sb.ToString();
        }
    }
}
