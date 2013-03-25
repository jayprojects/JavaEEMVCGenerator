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
    public class ModelGen:BaseGen
    {
        
        public static string generate()
        {
            List<TColumn> tcs = global.columnNames;
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("package "+global.packageName+";");
            sb.AppendLine(indent+"public class " + global.className);
            sb.AppendLine("{");
            indentInc();
            foreach(TColumn tc in tcs)
            {
                sb.AppendLine(indent+"private "+tc.csType+" "+tc.ColumnName+";");
            }

            sb.AppendLine("");
            sb.AppendLine(indent+"// class constructor");
            sb.AppendLine(indent + "public " + global.className + "()");
            sb.AppendLine(indent + "{");
            indentInc();
            sb.Append(indent + "this(");
            foreach (TColumn tc in tcs)
            {
                sb.Append(tc.csInit);
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.AppendLine(indent + ");");
            indentDec();
            sb.AppendLine(indent + "}");
            sb.AppendLine( "");
            sb.Append(indent + "public " + global.className + "(");
            foreach (TColumn tc in tcs)
            {
                sb.Append(tc.csType + " " + tc.ColumnName);
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.AppendLine(")");
            sb.AppendLine(indent+"{");
            indentInc();
            foreach (TColumn tc in tcs)
            {
                sb.Append(indent + "set" + tc.ColumnNameSentenceCase);
                sb.Append("(" + tc.ColumnName + ")");
                sb.AppendLine(";");

            }
            indentDec();
            sb.AppendLine(indent+"}");
            
            sb.AppendLine("");
            sb.AppendLine(indent+"//setter methods");

            foreach (TColumn tc in tcs)
            {
                sb.Append(indent + "public void ");
                sb.Append("set" + tc.ColumnNameSentenceCase);
                sb.AppendLine( "(" + tc.csType + " " + tc.ColumnName + ")");
                sb.AppendLine(indent+"{");
                indentInc();
                sb.AppendLine(indent+"this." + tc.ColumnName + "=" + tc.ColumnName + ";");
                indentDec();
                sb.AppendLine(indent+"}");
                

            }

            sb.AppendLine("");
            sb.AppendLine(indent+"//getter methods");
            sb.AppendLine(indent + "");
            foreach (TColumn tc in tcs)
            {
                sb.Append(indent + "public " + tc.csType + " ");
                sb.AppendLine("get" + tc.ColumnNameSentenceCase + "()");
                
                sb.AppendLine(indent+"{");
                indentInc();
                sb.AppendLine(indent+"return this." + tc.ColumnName + ";");
                indentDec();
                sb.AppendLine(indent+"}");
                

            }

            sb.AppendLine("");
            indentDec();
            sb.AppendLine(indent+"}");
           
            sb.AppendLine("");
           

            return sb.ToString();
        }
       
    }
}
