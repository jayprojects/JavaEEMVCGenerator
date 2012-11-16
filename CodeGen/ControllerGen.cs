using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace JavaEEMVCGenerator
{
    public class ControllerGen
    {
        static string indent="";
        public static string generate()
        {
            List<TColumn> tcs = global.columnNames;
            StringBuilder sb = new StringBuilder();
            
            
            sb.AppendLine(indent + "package myproject;");
            sb.AppendLine(indent + "");
            sb.AppendLine(indent + "import java.io.IOException;");
            sb.AppendLine(indent + "import java.util.List;");
            sb.AppendLine(indent + "import javax.servlet.ServletException;");
            sb.AppendLine(indent + "import javax.servlet.http.HttpServlet;");
            sb.AppendLine(indent + "import javax.servlet.http.HttpServletRequest;");
            sb.AppendLine(indent + "import javax.servlet.http.HttpServletResponse;");
            sb.AppendLine(indent + "");

            sb.AppendLine(indent + "public class " +global.className+ "Controll extends HttpServlet {");
            indentInc();
            sb.AppendLine(indent + "private static final long serialVersionUID = 1L;");
            sb.AppendLine(indent + "");
            sb.AppendLine(indent + "public " +global.className+ "Controll() {");
            
            indentInc();
            sb.AppendLine(indent + "super();");
            indentDec();
            sb.AppendLine(indent + "}");
            sb.AppendLine(indent + "");

            sb.AppendLine(indent + "protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {");
            indentInc();
            sb.AppendLine(indent + "String current_page =request.getParameter(\"current_page\");");
            sb.AppendLine(indent + "String current_action =request.getParameter(\"current_action\");");
            sb.AppendLine(indent + "if(null!=current_page && null!=current_action)");
            sb.AppendLine(indent + "{");
            indentInc();
            sb.AppendLine(indent + "if((current_page.equals(\"" +global.className+ "View.jsp\")) && current_action.equals(\"Update\"))");
            sb.AppendLine(indent + "{");
            indentInc();
            sb.AppendLine(indent + "String record_id =request.getParameter(\"record_id\");");
            sb.AppendLine(indent + "" +global.className+ " " +global.classNameLow+ " = " +global.className+ "DbUtill.get" +global.className+ "(record_id);");
            sb.AppendLine(indent + "request.setAttribute(\"" +global.classNameLow+ "\", " +global.classNameLow+ ");");
            sb.AppendLine(indent + "request.getRequestDispatcher(\"" +global.className+ "Update.jsp\").forward(request, response);");
            indentDec();
            sb.AppendLine(indent + "}");
            indentDec();
            sb.AppendLine(indent + "}");
            sb.AppendLine(indent + "else");
            sb.AppendLine(indent + "{");
            indentInc();
            sb.AppendLine(indent + "List<" +global.className+ "> " +global.classNameLow+ "List = " +global.className+ "DbUtill.getAll" +global.className+ "s();");
            sb.AppendLine(indent + "request.setAttribute(\"" +global.classNameLow+ "List\", " +global.classNameLow+ "List);");
            sb.AppendLine(indent + "request.getRequestDispatcher(\"" +global.className+ "View.jsp\").forward(request, response);");
            indentDec();
            sb.AppendLine(indent + "}");
            indentDec();
            sb.AppendLine(indent + "}");



            sb.AppendLine(indent + "");
            sb.AppendLine(indent + "");

            sb.AppendLine(indent + "protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {");
            indentInc();
            sb.AppendLine(indent + "String current_page =request.getParameter(\"current_page\");");
            sb.AppendLine(indent + "String current_action =request.getParameter(\"current_action\");");
            sb.AppendLine(indent + "if(null!=current_page && null!=current_action)");
            sb.AppendLine(indent + "{");
            indentInc();
            sb.AppendLine(indent + "if((current_page.equals(\"" +global.className+ "View.jsp\")) && current_action.equals(\"Delete\"))");
            sb.AppendLine(indent + "{");
            indentInc();
            sb.AppendLine(indent + "String record_id =request.getParameter(\"record_id\");");
            sb.AppendLine(indent + "" +global.className+ "DbUtill.delete" +global.className+ "(record_id);");
            
            indentDec();
            sb.AppendLine(indent + "}");
            sb.AppendLine(indent + "else if ((current_page.equals(\"" +global.className+ "Add.jsp\")) && current_action.equals(\"Add\"))");
            sb.AppendLine(indent + "{");
            indentInc();
            
            sb.AppendLine(HelperUtill.getRequestPram(tcs,indent));
            sb.AppendLine(indent + "" +global.className+ " " +global.classNameLow+ "= new " +global.className+ "(" + HelperUtill.getExecPram(tcs)+");");
            
            
            
            sb.AppendLine(indent + "" +global.className+ "DbUtill.insert" +global.className+ "(" +global.classNameLow+ ");");
            indentDec();
            sb.AppendLine(indent + "}");
            sb.AppendLine(indent + "else if((current_page.equals(\"" +global.className+ "Update.jsp\")) && current_action.equals(\"Update\"))");
            sb.AppendLine(indent + "{");
            indentInc();
            sb.AppendLine(indent + "String record_id =request.getParameter(\"record_id\");");
            sb.AppendLine(HelperUtill.getRequestPram(tcs, indent));
            sb.AppendLine("");
            sb.AppendLine(indent + "" +global.className+ " " +global.classNameLow+ "= new " +global.className+ "(" + HelperUtill.getExecPram(tcs) + ");");
            sb.AppendLine(indent + "" +global.className+ "DbUtill.update" +global.className+ "(" +global.classNameLow+ ", record_id);");
            indentDec();
            sb.AppendLine(indent + "}");
            indentDec();
            sb.AppendLine(indent + "}");
            
            sb.AppendLine(indent + "List<" +global.className+ "> " +global.classNameLow+ "List = " +global.className+ "DbUtill.getAll" +global.className+ "s();");
            sb.AppendLine(indent + "request.setAttribute(\"" +global.classNameLow+ "List\", " +global.classNameLow+ "List);");
            sb.AppendLine(indent + "request.getRequestDispatcher(\"" +global.className+ "View.jsp\").forward(request, response);");
            indentDec();
            sb.AppendLine(indent + "}");
            indentDec();
            sb.AppendLine(indent + "}");
            

            return sb.ToString();
        }
        static void indentInc()
        {
            indent = indent + "\t";
        }
        static void indentDec()
        {
            var rgx = new Regex("\t");
            indent = rgx.Replace(indent, "", 1);
        }
    }
}
