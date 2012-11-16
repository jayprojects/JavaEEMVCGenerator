using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JavaEEMVCGenerator
{
    public class DBConGen
    {
        public static string generate()
        {
            StringBuilder sb = new StringBuilder();
            string indent = "\t";
            sb.AppendLine("package " + global.packageName + ";");
            sb.AppendLine("import java.sql.*;");
            sb.AppendLine("public class DBConnection {");
            sb.AppendLine(indent+"private static Connection connection;");
            sb.AppendLine(indent+"private static String db_host=\""+global.serverName+"\";");
            sb.AppendLine(indent + "private static String db_port=\"" + global.port + "\";");
            sb.AppendLine(indent + "private static String db_name=\"" + global.dbName + "\";");
            sb.AppendLine(indent + "private static String db_userid=\"" + global.user + "\";");
            sb.AppendLine(indent + "private static String db_password=\"" + global.password + "\";");
            sb.AppendLine(indent + "");


            string conbody = @"
    private static Connection openConnection()
	{
		try {
			Class.forName(""net.sourceforge.jtds.jdbc.Driver"");
        	String db_connect_string=""jdbc:jtds:sqlserver://""+db_host+"":""+db_port+""/""+db_name;
            connection = DriverManager.getConnection(db_connect_string, db_userid, db_password);
        }
		catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
        catch(SQLException e) {
            System.out.println(""Connection Error: "");
            displaySQLErrors(e);
        }
		return connection;
	}
	
    private static void displaySQLErrors(SQLException e) {
        System.out.println(""SQLException: "" + e.getMessage());
        System.out.println(""SQLState:     "" + e.getSQLState());
        System.out.println(""VendorError:  "" + e.getErrorCode());
    }

    public static Object[][] executeSQL(String qry) {

        try {
        	openConnection();
        	Statement statement = connection.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_READ_ONLY);
            ResultSet rs = statement.executeQuery(qry);
            ResultSetMetaData rsmd = rs.getMetaData();
            int numCols = rsmd.getColumnCount(); //Get Number of Fields returned from the Query
            rs.last();
            int numRows = rs.getRow();//Get Number of Records returned from the query
            rs.beforeFirst();
            Object returnArray[][] = new Object[numRows][numCols];
            for(int row=0; row<numRows; row++){
                rs.next();
                for(int col=0; col<numCols;col++){
                    returnArray[row][col] =rs.getObject(col+1);
                }
            }
            rs.close();
            statement.close();
            closeConnection();
            return returnArray;
        }
        catch(SQLException e) {
            System.out.println(""Executing Query Error: "");
            displaySQLErrors(e);
            return null;
        }
    }
    public static Boolean executeNonRsSQL(String qry){
    	try {
    		openConnection();
    		Statement statement = connection.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_READ_ONLY);
            Boolean r = statement.execute(qry);
			statement.close();
			closeConnection();
			return r;
			
		} catch (SQLException e) {
            displaySQLErrors(e);
            return false;
		}
    }    
    public static Boolean executeCallableSQL(String qry){
    	try {
    		openConnection();
			CallableStatement statement = connection.prepareCall(qry);
			statement.execute();
			statement.close();
			closeConnection();
			return true;
			
		} catch (SQLException e) {
            displaySQLErrors(e);
            return false;
		}
    }
    


    private static void closeConnection(){
    	try {
			connection.close();
		} catch (SQLException e) {
			displaySQLErrors(e);
		}
    }
}
";
            sb.Append(conbody);
            return sb.ToString();
        }
    }
}
