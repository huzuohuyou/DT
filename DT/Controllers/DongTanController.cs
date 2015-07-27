using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToolFunction;
using System.Data;

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

        public ActionResult CreateItem(string dongtan)
        {
            SortedDictionary<string, string> _sdict = new SortedDictionary<string, string>();
            _sdict.Add("1", "whl");
            _sdict.Add("2", dongtan);
            _sdict.Add("3", DateTime.Now.ToString());
            string _strSql = "insert into DongTan(userid,message,timepoint,commentCount,agreeCount) values(?,?,?,0,0)";
            CommonFunction.OleExecuteNonQuery(_strSql, _sdict);
            return View("..\\Home\\Index");
        }


        public ActionResult GetNewItems() {
            SortedDictionary<string, string> _sdict = new SortedDictionary<string, string>();
            string _strSql = "select top(10)* from Dongtan order by timepoint desc";
            DataTable _dtDongTan =  CommonFunction.OleExecuteBySQL(_strSql,_sdict,"最新动弹");
            return Json(_dtDongTan);
        }
    }
}
