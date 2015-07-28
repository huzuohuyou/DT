using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToolFunction;
using System.Data;
using System.Text;

namespace DT.Controllers
{
    public class DongTanController : Controller
    {
        //
        // GET: /DongTan/

        public ActionResult Index()
        {
            return View();
        }

        public void CreateItem(string dongtan,string name)
        {
            SortedDictionary<string, string> _sdict = new SortedDictionary<string, string>();
            _sdict.Add("1", name);
            _sdict.Add("2", dongtan);
            _sdict.Add("3", DateTime.Now.ToString());
            string _strSql = "insert into DongTan(userid,message,timepoint,commentCount,agreeCount) values(?,?,?,0,0)";
            CommonFunction.OleExecuteNonQuery(_strSql, _sdict);
            //return View("..\\Home\\Index");
        }


        public ActionResult GetNewItems() {
            SortedDictionary<string, string> _sdict = new SortedDictionary<string, string>();
            string _strSql = "select top(5)* from Dongtan order by timepoint desc";
            DataTable _dtDongTan =  CommonFunction.OleExecuteBySQL(_strSql,_sdict,"newItems");
            string s = DataTable2Json(_dtDongTan);
            return Json(s);
        }

        #region dataTable转换成Json格式
        /// <summary>  
        /// dataTable转换成Json格式  
        /// </summary>  
        /// <param name="dt"></param>  
        /// <returns></returns>  
        public static string DataTable2Json(DataTable dt)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("{\"");
            jsonBuilder.Append(dt.TableName);
            jsonBuilder.Append("\":[");
            //jsonBuilder.Append("[");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                jsonBuilder.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    jsonBuilder.Append("\"");
                    jsonBuilder.Append(dt.Columns[j].ColumnName);
                    jsonBuilder.Append("\":\"");
                    jsonBuilder.Append(dt.Rows[i][j].ToString());
                    jsonBuilder.Append("\",");
                }
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
                jsonBuilder.Append("},");
            }
            jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            jsonBuilder.Append("]");
            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }

        #endregion dataTable转换成Json格式

    }
}
