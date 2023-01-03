using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinPreinst
{
    class StringUtils
    {
        public static String GetFullSql(String sqlText, String parText)
        {
            String exportSql = sqlText.Trim(); //导出sql
            String[] parameters = parText.Split(',');
            Regex regex = new Regex("\\?");
            foreach (String parameter in parameters)
            {
                if (parameter.Contains("String"))
                {
                    exportSql = regex.Replace(exportSql, "'" + parameter.Replace("(String)", "").Trim() + "'", 1);
                }
                else if (parameter.Contains("Date"))
                {
                    exportSql = regex.Replace(exportSql, "to_date('"+ parameter.Replace("(Date)", "").Trim() + "','yyyy-MM-dd')", 1);
                }
                else if (parameter.Contains("Long"))
                {
                    exportSql = regex.Replace(exportSql, parameter.Replace("(Long)", "").Trim(), 1);
                }
                else if (parameter.Contains("Integer"))
                {
                    exportSql = regex.Replace(exportSql, parameter.Replace("(Integer)", "").Trim(), 1);
                }
                else if (parameter.Contains("Number"))
                {
                    exportSql = regex.Replace(exportSql, parameter.Replace("(Number)", "").Trim(), 1);
                }
                else if (parameter.Contains("BigDecimal"))
                {
                    exportSql = regex.Replace(exportSql, parameter.Replace("(BigDecimal)", "").Trim(), 1);
                }
                else if (parameter.Contains("Timestamp"))
                {
                    exportSql = regex.Replace(exportSql, "to_date('" + parameter.Replace("(Timestamp)", "").Substring(0, 11).Trim() + "','yyyy-MM-dd')", 1);
                }
                else if (parameter.Contains("null"))
                {
                    exportSql = regex.Replace(exportSql, parameter.Trim(), 1);
                }
            }
            return exportSql;
        }
    }
}
