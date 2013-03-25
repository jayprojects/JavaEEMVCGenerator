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
    public class ViewJspGen:BaseGen
    {
        
        public static string generate()
        {
            List<TColumn> tcs = global.columnNames;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<%@page import=\"" + global.packageName + ".*\"%>");  
            sb.AppendLine("<%@ taglib uri=\"http://java.sun.com/jsp/jstl/core\" prefix=\"c\" %> ");
            sb.AppendLine("<%@ taglib uri=\"http://java.sun.com/jsp/jstl/xml\" prefix=\"x\" %>"); 
            sb.AppendLine("<html>"); 
            sb.AppendLine("<head>"); 
            sb.AppendLine("<title>View "+global.className+"</title>"); 
            sb.AppendLine("<style type=\"text/css\">"); 
            sb.AppendLine("table {"); 
            sb.AppendLine("	margin: 1em;"); 
            sb.AppendLine("	border-collapse: collapse;"); 
            sb.AppendLine("}"); 
            sb.AppendLine(""); 
            sb.AppendLine("td,th {"); 
            sb.AppendLine("	padding: .3em;"); 
            sb.AppendLine("	border: 1px #ccc solid;"); 
            sb.AppendLine("}"); 
            sb.AppendLine("</style>"); 
            sb.AppendLine(""); 
            sb.AppendLine("<script type=\"text/javascript\">"); 
            sb.AppendLine("	function "+global.classNameLow+"_delete(n) {"); 
            sb.AppendLine("		var conf = confirm(\"Are you sure you want to delete recored number: \""); 
            sb.AppendLine("				+ n + \" ?\");"); 
            sb.AppendLine(""); 
            sb.AppendLine("		if (conf == true) {"); 
            sb.AppendLine("			document.getElementById(\"record_id\").value = n;"); 
            sb.AppendLine("			document.getElementById(\"current_action\").value = \"Delete\";"); 
            sb.AppendLine("			document.getElementById(\""+global.classNameLow+"_frm\").submit();"); 
            sb.AppendLine("		}"); 
            sb.AppendLine(""); 
            sb.AppendLine("	}"); 
            sb.AppendLine("</script>"); 
            sb.AppendLine("</head>"); 
            sb.AppendLine(""); 
            sb.AppendLine("<body>"); 
            sb.AppendLine("	<h2>View "+global.className+"</h2>"); 
            sb.AppendLine("	<form id=\""+global.classNameLow+"_frm\" action=\""+global.className+".do\" method=\"post\">"); 
            sb.AppendLine("		<input type=\"hidden\" name=\"current_page\" value=\""+global.className+"View.jsp\">"); 
            sb.AppendLine("		<input type=\"hidden\" name=\"current_action\" id=\"current_action\"value=\"\"> "); 
            sb.AppendLine("		<input type=\"hidden\" name=\"record_id\"id=\"record_id\" value=\"\">"); 
            sb.AppendLine(""); 
            sb.AppendLine("		<table>"); 
            sb.AppendLine("			<tr>");
            
            //sb.AppendLine("				<th align=\"left\" valign=\"top\">"+global.classNameLow+"_date</th>"); 
            //sb.AppendLine("				<th align=\"left\" valign=\"top\">"+global.classNameLow+"_description</th>"); 
            foreach (TColumn tc in tcs)
            {

                sb.AppendLine("				<th align=\"left\" valign=\"top\">" + tc.ColumnName + "</th>");
            }

            sb.AppendLine("				<th align=\"left\" valign=\"top\">&nbsp;</th>"); 
            sb.AppendLine("			</tr>");
 

            sb.AppendLine("			<c:choose>");
			sb.AppendLine("      <c:when test='${empty requestScope.bcmajorList}'>");
			sb.AppendLine("          <c:redirect url='Bcmajor.do' />");
			sb.AppendLine("      </c:when>");
			sb.AppendLine("      <c:otherwise>");
            sb.AppendLine("          <c:forEach items='${requestScope.bcmajorList}' var='" + global.className + "' varStatus='loop'>");
			sb.AppendLine("             <tr>");
            foreach (TColumn tc in tcs)
            {
                sb.AppendLine("  	           <td align='left' valign='top'>${" + global.className + "." + tc.ColumnName + "}</td>");
            }
            sb.AppendLine("					    <td align=\"left\" valign=\"top\">");
            sb.AppendLine("							<a href=\"" + global.className + ".do?current_page=" + global.className + "View.jsp&amp;current_action=Update&amp;record_id=${" + global.className + "." + tcs.ElementAt(0).ColumnName + "}\">Update </a>&nbsp;");
            sb.AppendLine("							<a href=\"#\" onclick=\"" + global.classNameLow + "_delete('${" + global.className + "." + tcs.ElementAt(0).ColumnName + "}');\">Delete </a>");
            sb.AppendLine("					    </td>");
			sb.AppendLine("             </tr>");
		    sb.AppendLine("     		 </c:forEach>");
			sb.AppendLine("      </c:otherwise>");
			sb.AppendLine("      </c:choose>");


            /*
            sb.AppendLine("			<%"); 
            sb.AppendLine("				List<"+global.className+"> "+global.classNameLow+"List = (List<"+global.className+">) request.getAttribute(\""+global.classNameLow+"List\");"); 
            sb.AppendLine("				if ("+global.classNameLow+"List != null) {"); 
            sb.AppendLine("					for ("+global.className+" "+global.classNameLow+" : "+global.classNameLow+"List) {"); 
            sb.AppendLine("					%>"); 
            sb.AppendLine("					<tr>"); 
            //sb.AppendLine("						<td align=\"left\" valign=\"top\"><%="+global.classNameLow+".get"+global.className+"_Date()%></td>"); 
            //sb.AppendLine("						<td align=\"left\" valign=\"top\"><%="+global.classNameLow+".get"+global.className+"_Description()%></td>"); 
            foreach (TColumn tc in tcs)
            {

                sb.AppendLine("						<td align=\"left\" valign=\"top\"><%=" +global.classNameLow+ ".get" + tc.ColumnNameTitleCase + "()%></td>"); 
            }
            sb.AppendLine("					    <td align=\"left\" valign=\"top\">");
            sb.AppendLine("							<a href=\"" +global.className+ ".do?current_page=" +global.className+ "View.jsp&amp;current_action=Update&amp;record_id=<%=" +global.classNameLow+ ".get" + tcs.ElementAt(0).ColumnNameTitleCase + "()%>\">Update </a>&nbsp;");
            sb.AppendLine("							<a href=\"#\" onclick=\"" +global.classNameLow+ "_delete('<%=" +global.classNameLow+ ".get" + tcs.ElementAt(0).ColumnNameTitleCase + "()%>');\">Delete </a>");
            sb.AppendLine("					    </td>"); 
            sb.AppendLine("					</tr>"); 
            sb.AppendLine("					<%"); 
            sb.AppendLine("					}"); 
            sb.AppendLine("				} else {"); 
            sb.AppendLine("					response.sendRedirect(\""+global.className+".do\");"); 
            sb.AppendLine("				}"); 
            sb.AppendLine("			%>"); 
             * 
             */
 
            sb.AppendLine("			<tr>"); 
            sb.AppendLine("				<td align=\"left\" valign=\"top\" colspan=\"6\">"); 
            sb.AppendLine("				<a href=\""+global.className+"Add.jsp\">Add New "+global.className+"</a></td>"); 
            sb.AppendLine("			</tr>"); 
            sb.AppendLine("		</table>"); 
            sb.AppendLine(""); 
            sb.AppendLine("	</form>"); 
            sb.AppendLine("</body>"); 
            sb.AppendLine("</html>"); 
            sb.AppendLine("");


            return sb.ToString();
        }
    }
}
