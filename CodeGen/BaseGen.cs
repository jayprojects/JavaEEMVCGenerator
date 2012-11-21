/**
 * @author Jay Das <jay11421@gmail.com>
 * @copyright 2012 Jay Das
 * @namespace JavaEEMVCGenerator
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace JavaEEMVCGenerator.CodeGen
{
    public class BaseGen
    {
        protected static string indent = "";

        protected static void indentInc()
        {
            indent = indent + "\t";
        }
        protected static void indentDec()
        {
            var rgx = new Regex("\t");
            indent = rgx.Replace(indent, "", 1);
        }
    }
}
