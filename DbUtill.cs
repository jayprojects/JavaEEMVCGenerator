using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace JavaEEMVCGenerator
{

    public class DbUtill
    {
        public DbUtill()
        {
        }

        public static DataTable executeQuery(string query)
        {
            SqlConnection myConnection = new SqlConnection(global.connectionString);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader dr = myCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                myConnection.Close();
                return dt;
            }
            catch (Exception e2)
            {
                Console.Write(e2.ToString());
            }
            return null;
        }

        public static string executeScalar(string query)
        {
            SqlConnection myConnection = new SqlConnection(global.connectionString);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                string st = myCommand.ExecuteScalar().ToString();
                myConnection.Close();
                return st;
            }
            catch (Exception e2)
            {
                Console.Write(e2.ToString());
            }
            return null;

        }

        public static int executeUpdate(string query)
        {



            SqlConnection myConnection = new SqlConnection(global.connectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);



            try
            {
                return myCommand.ExecuteNonQuery();
            }

            catch (SqlException sqlexception)
            {
                Console.Write(sqlexception.Message + "\n" + query);
            }

            catch (Exception ex)
            {
                Console.Write(ex.Message + "\n" + query);
            }

            finally
            {
                myConnection.Close();
            }
            return 0;
        }

        static int formatInt(object obj)
        {

            if (null == obj || obj.Equals("") ||obj.Equals(DBNull.Value))
                return 0;
            else
                return (int)obj;
        }
        static string formatStr(object obj)
        {
            if (null == obj || obj.Equals("") || obj.Equals(DBNull.Value))
                return "";
            else
                return (string)obj;
        }

        static bool formatBool(object obj)
        {
            if (null == obj || obj.Equals("") || obj.Equals(DBNull.Value))
                return false;
            else if(obj.Equals("NO"))
            {
                return false;
            }
            else if (obj.Equals("YES"))
            {
                return true;
            } else
                return (bool)obj;
        }
        
        public static List<TColumn> getColumnNames(string database, string tbl)
        {
            string query = "USE " + database + "; \n" +
                          "SELECT ORDINAL_POSITION, COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE, COLUMN_DEFAULT \n" +
                          "FROM information_schema.columns WHERE table_name = '"+tbl+"';";
            Console.WriteLine(query);
            SqlConnection myConnection = new SqlConnection(global.connectionString);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();


                List<TColumn> columnNames = new List<TColumn>();
                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {

                        int position = formatInt(reader["ORDINAL_POSITION"]);
                        String columnName = formatStr(reader["COLUMN_NAME"]);
                        String columnType =formatStr(reader["DATA_TYPE"]);
                        Int32 maxLengh = formatInt(reader["CHARACTER_MAXIMUM_LENGTH"]);
                        Boolean isNullable = formatBool(reader["IS_NULLABLE"]);
                        String defaultValue = formatStr(reader["COLUMN_DEFAULT"]);
                        columnNames.Add(new TColumn(
                            formatInt(reader["ORDINAL_POSITION"]),
                            formatStr(reader["COLUMN_NAME"]),
                            formatStr(reader["DATA_TYPE"]),
                            formatInt(reader["CHARACTER_MAXIMUM_LENGTH"]),
                            formatBool(reader["IS_NULLABLE"]),
                            formatStr(reader["COLUMN_DEFAULT"])));
                    }
                    
                }
                myConnection.Close();
                return columnNames;
            }
            catch (Exception e2)
            {
                Console.Write(e2.ToString());
            }
            return null;
        }
    }
}