using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
namespace JavaEEMVCGenerator
{
    public class TColumn
    {
        private int _ORDINAL_POSITION;
        private string _COLUMN_NAME;
        private string _DATA_TYPE;
        private int _CHARACTER_MAXIMUM_LENGTH;
        private bool _IS_NULLABLE;
        private string _COLUMN_DEFAULT;
        private string cs_type;
        private string cs_init;
        public TColumn() 
          {
            SerialNo = 0;
            ColumnName = "";
            ColumnName = "";
            MaxLengh = 0;
            IsNullable = true;
            DefaultValue = "";
        }
        public TColumn(int position, string columnName, string columnType, int maxLengh, bool isNullable, string defaultValue) 
        {
            SerialNo = position;
            ColumnName = columnName;
            ColumnType = columnType;
            MaxLengh = maxLengh;
            IsNullable = isNullable;
            DefaultValue = defaultValue;
            setCSType(columnType);
        }

        public int SerialNo
        {
            get
            {
                return _ORDINAL_POSITION;
            }
            set
            {
                _ORDINAL_POSITION = value;
            }
        }

        public string ColumnName
        {
            get
            {
                return _COLUMN_NAME;
            }
            set
            {
                _COLUMN_NAME = value;
            }
        }
        public string ColumnNameTitleCase
        {
            get
            {
                TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                return myTI.ToTitleCase(_COLUMN_NAME);
            }
            set
            {
                _COLUMN_NAME = value;
            }
        }

        public string ColumnNameSentenceCase
        {
            get
            {
                string firstchar = _COLUMN_NAME.Substring(0, 1);
                string restchars = _COLUMN_NAME.Substring(1);
                return firstchar.ToUpper() + restchars;
                //TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                //return myTI.to(_COLUMN_NAME);

            }
            set
            {
                _COLUMN_NAME = value;
            }
        }

        public string ColumnType
        {
            get
            {
                return _DATA_TYPE;
            }
            set
            {
                _DATA_TYPE = value;
            }
        }

        public int MaxLengh
        {
            get
            {
                return _CHARACTER_MAXIMUM_LENGTH;
            }
            set
            {
                _CHARACTER_MAXIMUM_LENGTH = value;
            }
        }

        public bool IsNullable
        {
            get
            {
                return _IS_NULLABLE;
            }
            set
            {
                _IS_NULLABLE = value;
            }
        }

        public string DefaultValue
        {
            get
            {
                return _COLUMN_DEFAULT;
            }
            set
            {
                _COLUMN_DEFAULT = value;
            }
        }
        void setCSType(string sqlType)
        {
            if (sqlType.Equals("int"))
                csType = "int";
            else if (sqlType.Equals("char"))
                csType = "String";
            else if (sqlType.Equals("varchar"))
                csType = "String";
            else if (sqlType.Equals("bit"))
                csType = "bool";
            else if (sqlType.Equals("datetime"))
                csType = "String";
            else
                csType = "String";

            setInit();
        }
        void setInit()
        {
            switch (this.cs_type)
            {
                case "int":
                    csInit = "0";
                    return;

                case "String":
                    csInit = "\"\"";
                    return;
                
                default:
                    csInit = "\"\"";
                    return;
            }
        }
        public string csType
        {
            get
            {
                return cs_type;
            }
            set
            {
                cs_type = value;
            }
        }

        public string csInit
        {
            get
            {
                return cs_init;
            }
            set
            {
                cs_init = value;
            }
        }

        
        
    }
}
