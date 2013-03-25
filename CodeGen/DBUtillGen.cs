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
    public class DBUtillGen:BaseGen
    {   
        public static string generate()
        {

            List<TColumn> tcs = global.columnNames;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(indent + "package "+global.packageName+";"); 
            sb.AppendLine(""); 
            sb.AppendLine(indent + "import java.util.*;"); 
            sb.AppendLine(""); 
            sb.AppendLine(indent + "public class "+global.className+"DbUtill {"); 
            indentInc();
            sb.AppendLine(""); 
            sb.AppendLine(""); 
            sb.AppendLine(indent + "public static boolean insert"+global.className+"("+global.className+" "+global.classNameLow+")"); 
            sb.AppendLine(indent + "{"); 
            indentInc();
            sb.AppendLine(indent + "String query ="); 
            sb.AppendLine(indent + "\"INSERT INTO "+global.dbName+".dbo."+global.tblName+" \" +"); 
            sb.AppendLine(indent + "\"("+HelperUtill.getExecPram(tcs)+") \"+"); 
            //sb.AppendLine(indent + "\"values('\"+"+global.classNameLow+".get"+global.className+"_Date()+\"','\"+"+global.classNameLow+".get"+global.className+"_Description()+\"');\";"); 
            sb.Append(indent + "\"values(");
            foreach (TColumn tc in tcs)
            {
                sb.Append("'\"+" +global.classNameLow+ ".get" + tc.ColumnNameSentenceCase + "()+\"', ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.AppendLine(");\";");
            sb.AppendLine(indent + "return DBConnection.executeNonRsSQL(query);"); 
            sb.AppendLine(""); 
            indentDec();
            sb.AppendLine(indent + "}"); 
            sb.AppendLine(""); 
            sb.AppendLine(indent + "public static boolean delete"+global.className+"(String record_id)"); 
            sb.AppendLine(indent + "{"); 
            indentInc();
            sb.AppendLine(indent + "String query =\"DELETE FROM "+global.dbName+".dbo."+global.tblName+" \"+"); 
            sb.AppendLine(indent + "\"WHERE "+tcs.ElementAt(0).ColumnName+"='\"+record_id+\"'\";"); 
            sb.AppendLine(indent + "return DBConnection.executeNonRsSQL(query);"); 
            indentDec();
            sb.AppendLine(indent + "}"); 
            sb.AppendLine(indent + "public static boolean update"+global.className+"("+global.className+" "+global.classNameLow+", String record_id)"); 
            sb.AppendLine(indent + "{"); 
            indentInc();
            sb.AppendLine(""); 
            sb.AppendLine(indent + "String query ="); 
            sb.AppendLine(indent + "\"UPDATE "+global.dbName+".dbo."+global.tblName+" \" +"); 
            //sb.AppendLine(indent + "\"SET "+global.classNameLow+"_date='\"+"+global.classNameLow+".get"+global.className+"_Date()+\"', "+global.classNameLow+"_description='\"+"+global.classNameLow+".get"+global.className+"_Description()+\"' \"+"); 
            //sb.AppendLine(indent + "\"where "+global.classNameLow+"_date='\"+record_id+\"'\";");
            sb.Append(indent + "\"SET ");
            foreach (TColumn tc in tcs)
            {
                sb.Append(" " + tc.ColumnName + "='\"+" + global.classNameLow + ".get" + tc.ColumnNameSentenceCase + "()+\"', ");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.AppendLine(" \"+");
            sb.AppendLine(indent + "\"WHERE " + tcs.ElementAt(0).ColumnName + "='\"+record_id+\"'\";"); 
            sb.AppendLine(indent + "System.out.println(query);");
            sb.AppendLine(""); 
            sb.AppendLine(indent + "return DBConnection.executeNonRsSQL(query);"); 
            sb.AppendLine(""); 
            indentDec();
            sb.AppendLine(indent + "}"); 
            sb.AppendLine(""); 
            sb.AppendLine(""); 
            sb.AppendLine(indent + "public static List<"+global.className+"> getAll"+global.className+"s()"); 
            sb.AppendLine(indent + "{"); 
            indentInc();
            sb.AppendLine(indent + "List<"+global.className+"> "+global.classNameLow+"List = new ArrayList<"+global.className+">();"); 
            sb.AppendLine(""); 
            //sb.AppendLine(indent + "String query = \"SELECT "+global.classNameLow+"_date, "+global.classNameLow+"_description FROM "+global.dbName+".dbo."+global.tblName+" ORDER BY "+global.classNameLow+"_date\";"); 
            
            sb.AppendLine(indent + "String query = \"SELECT " + HelperUtill.getExecPram(tcs) + " FROM \"+");
            sb.AppendLine(indent + "\""+global.dbName + ".dbo." + global.tblName + " ORDER BY " + tcs.ElementAt(0).ColumnName + "\";"); 
            sb.AppendLine(indent + "Object[][] rs = DBConnection.executeSQL(query);"); 
            sb.AppendLine(indent + "if(rs!=null)"); 
            sb.AppendLine(indent + "{"); 
            indentInc();
            sb.AppendLine(""); 
            sb.AppendLine(indent + "for(Object[] row: rs)"); 
            sb.AppendLine(indent + "{"); 
            indentInc();
            sb.AppendLine(indent + ""+global.className+" "+global.classNameLow+" = new "+global.className+"();"); 
            //sb.AppendLine(indent + ""+global.classNameLow+".set"+global.className+"_Date(row[0].toString());"); 
            //sb.AppendLine(indent + ""+global.classNameLow+".set"+global.className+"_Description(row[1].toString());"); 
            /*
            int i = 0;
            foreach (TColumn tc in tcs)
            {
                sb.AppendLine(indent + "" +global.classNameLow+ ".set" + tc.ColumnNameTitleCase + "(row["+i.ToString()+"].toString());");
                i++;
            }
             * */
            sb.Append(HelperUtill.getSettersParm(tcs, indent));

            sb.AppendLine(indent + ""+global.classNameLow+"List.add("+global.classNameLow+");"); 
            indentDec();
            sb.AppendLine(indent + "}"); 
            indentDec();
            sb.AppendLine(indent + "}"); 
            sb.AppendLine(indent + "return "+global.classNameLow+"List;"); 
            sb.AppendLine(""); 
            indentDec();
            sb.AppendLine(indent + "}"); 
            sb.AppendLine(""); 
            sb.AppendLine(indent + "public static "+global.className+" get"+global.className+"(String record_id)"); 
            sb.AppendLine(indent + "{"); 
            indentInc();
            //sb.AppendLine(indent + "String query = \"SELECT "+global.classNameLow+"_date, "+global.classNameLow+"_description FROM "+global.dbName+".dbo."+global.tblName+" \" +"); 
            //sb.AppendLine(indent + "\"where "+global.classNameLow+"_date='\"+record_id+\"'\";"); 
            sb.AppendLine("");
            sb.AppendLine(indent + "String query = \"SELECT " + HelperUtill.getExecPram(tcs) + " FROM \"+");
            sb.AppendLine(indent + "\"" + global.dbName + ".dbo." + global.tblName + " \"+");
            sb.AppendLine(indent + "\"WHERE " + tcs.ElementAt(0).ColumnName + "='\"+record_id+\"'\";"); 
            
            sb.AppendLine(indent + "System.out.println(query);"); 
            sb.AppendLine(indent + "Object[][] rs = DBConnection.executeSQL(query);"); 
            sb.AppendLine(indent + "if(rs!=null)"); 
            sb.AppendLine(indent + "{"); 
            indentInc();
            sb.AppendLine(indent + "for(Object[] row: rs)"); 
            sb.AppendLine(indent + "{"); 
            indentInc();
            sb.AppendLine(indent + ""+global.className+" "+global.classNameLow+" = new "+global.className+"();"); 
            //sb.AppendLine(indent + ""+global.classNameLow+".set"+global.className+"_Date(row[0].toString());"); 
            //sb.AppendLine(indent + ""+global.classNameLow+".set"+global.className+"_Description(row[1].toString());"); 
            /*
            i = 0;
            foreach (TColumn tc in tcs)
            {
                sb.AppendLine(indent + "" +global.classNameLow+ ".set" + tc.ColumnNameTitleCase + "(row[" + i.ToString() + "].toString());");
                i++;
            }
             * */
            sb.Append(HelperUtill.getSettersParm(tcs, indent));
            sb.AppendLine(indent + "return "+global.classNameLow+";");
            indentDec();
            sb.AppendLine(indent + "}"); 
            indentDec();
            sb.AppendLine(indent + "}"); 
            sb.AppendLine(indent + "return null;"); 
            sb.AppendLine(""); 
            indentDec();
            sb.AppendLine(indent + "}"); 
            sb.AppendLine("");

            string temStr1 = @"
            public static int formatInt(String str)
	        {
		        if(str!=null)
		        {
			        str=str.replaceAll(""\\D"", """");
			        if(str.isEmpty()) return 0;
			        else return Integer.parseInt(str);
		        }
		         return 0;
	        }";
            sb.Append(temStr1);

            temStr1 = @"
            public static String formatStr(Object str)
	        {
		        if(str!=null)
		        {
			       return str.toString();
		        }
		         return """";
	        }";
            sb.Append(temStr1);


            indentDec();
            sb.AppendLine(indent + "}");
            sb.AppendLine("");
            return sb.ToString();
            
         

        }
       
    }
}
