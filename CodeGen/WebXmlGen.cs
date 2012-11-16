using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace JavaEEMVCGenerator.codeGen
{
    public class WebXmlGen
    {

        public static string generate()
        {
            List<TColumn> tcs = global.columnNames;
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); 
            sb.AppendLine("<web-app xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns=\"http://java.sun.com/xml/ns/javaee\" xmlns:web=\"http://java.sun.com/xml/ns/javaee/web-app_2_5.xsd\" xsi:schemaLocation=\"http://java.sun.com/xml/ns/javaee http://java.sun.com/xml/ns/javaee/web-app_2_5.xsd\" id=\"WebApp_ID\" version=\"2.5\">"); 
            sb.AppendLine("  <display-name>crud1.0</display-name>"); 
            sb.AppendLine("  <welcome-file-list>");
            sb.AppendLine("    <welcome-file>" +global.className+ ".do</welcome-file>");
            sb.AppendLine("    <welcome-file>index.jsp</welcome-file>");
            sb.AppendLine("  </welcome-file-list>"); 
            sb.AppendLine("  <servlet>"); 
            sb.AppendLine("    <description></description>"); 
            sb.AppendLine("    <display-name>"+global.className+"Controll</display-name>"); 
            sb.AppendLine("    <servlet-name>"+global.className+"Controll</servlet-name>"); 
            sb.AppendLine("    <servlet-class>myproject."+global.className+"Controll</servlet-class>"); 
            sb.AppendLine("  </servlet>"); 
            sb.AppendLine("  <servlet-mapping>"); 
            sb.AppendLine("    <servlet-name>"+global.className+"Controll</servlet-name>"); 
            sb.AppendLine("    <url-pattern>/"+global.className+"Controll</url-pattern>"); 
            sb.AppendLine("  </servlet-mapping>"); 
            sb.AppendLine("  <servlet-mapping>"); 
            sb.AppendLine("    <servlet-name>"+global.className+"Controll</servlet-name>"); 
            sb.AppendLine("    <url-pattern>/"+global.className+".do</url-pattern>"); 
            sb.AppendLine("  </servlet-mapping>"); 
            sb.AppendLine("</web-app>");
            sb.AppendLine("");
            sb.AppendLine("");

            return sb.ToString();
        }
    }
}
