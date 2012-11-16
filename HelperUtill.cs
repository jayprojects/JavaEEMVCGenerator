using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JavaEEMVCGenerator
{
    public class HelperUtill
    {
        public static string getSettersParm(List<TColumn> tcs, string indent)
        {

            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (TColumn tc in tcs)
            {
//                sb.AppendLine(indent + "" + global.classNameLow + ".set" + tc.ColumnNameTitleCase + "(row[" + i.ToString() + "].toString());");
                sb.AppendLine("");
                switch (tc.csType)
                {
                    case "int":
                        sb.AppendLine(indent + "" + global.classNameLow + ".set" + tc.ColumnNameTitleCase + "(" + global.className + "DbUtill.formatInt(row[" + i.ToString() + "].toString()));");
                        break;

                    case "String":
                        sb.AppendLine(indent + "" + global.classNameLow + ".set" + tc.ColumnNameTitleCase + "(row[" + i.ToString() + "].toString());");
                        break;

                    default:
                        sb.AppendLine(indent + "" + global.classNameLow + ".set" + tc.ColumnNameTitleCase + "(row[" + i.ToString() + "].toString());");
                        break;
                }

                i++;
            }
            return sb.ToString();
        }
        public static string getDeclarParm(List<TColumn> tcs)
        {
            //returns "(type parm1, type parm2, type parm3)
            //returns "(parm1, parm2, parm3)"
            StringBuilder sb = new StringBuilder();
            sb.Append(" (");
            foreach (TColumn tc in tcs)
            {
                sb.Append(tc.csType+" "+tc.ColumnName);
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append(")");
            return sb.ToString();
        }

        public static string getExecPram(List<TColumn> tcs)
        {
            //returns "(parm1, parm2, parm3)"
            StringBuilder sb = new StringBuilder();
            
            foreach (TColumn tc in tcs)
            {
                sb.Append(tc.ColumnName);
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            
            return sb.ToString();
        }
        
        public static string getRequestPram(List<TColumn> tcs, string indent)
        {
            //returns "(parm1, parm2, parm3)"
            StringBuilder sb = new StringBuilder();
            foreach (TColumn tc in tcs)
            {

                sb.AppendLine("");
                switch (tc.csType)
                {
                    case "int":
                        
                        sb.Append(indent + "int " + tc.ColumnName + " = "+global.className+"DbUtill.formatInt(request.getParameter(\"" + tc.ColumnName + "\"));");
                        break;

                    case "String":
                        sb.Append(indent + "String " + tc.ColumnName + " =request.getParameter(\"" + tc.ColumnName + "\");");
                        break;

                    default:
                        sb.Append(indent + "String " + tc.ColumnName + " =request.getParameter(\"" + tc.ColumnName + "\");");
                        break;
                }

                
            }
            sb.AppendLine("");
            return sb.ToString();
        }
    }
}
