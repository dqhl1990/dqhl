using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapTest.Models.CustomClass;
using BootstrapTest.Models.SqlServerOperation;

namespace BootstrapTest.Controllers
{
    public class TodayAlertController : Controller
    {
        //
        // GET: /TodayAlert/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult DisplayTA(int UserID)
        {
            SqlFunctionalOperation DisplayTodayAlert = new SqlFunctionalOperation();
            string[][] TodayAlert = DisplayTodayAlert.SearchTA(UserID);
            return Json(TodayAlert);
        }

        public ActionResult UpdateTimeFromTA(int UserID, int PlanID, int TodayAlertID, string NewTimeFromTA)
        {
            SqlFunctionalOperation UpdateTimeFromTodayAlert = new SqlFunctionalOperation();
            int i = UpdateTimeFromTodayAlert.UpdateTimeFromTA(UserID, PlanID, TodayAlertID, NewTimeFromTA);
            return Json(i);
        }

        public ActionResult GoToFinish(int UserID,int PlanID,int Flag,string AlertDate)
        {
            SqlFunctionalOperation GoToFinish = new SqlFunctionalOperation();
            int i = GoToFinish.UpdateCompletion(UserID, PlanID, Flag,AlertDate);

            return Json(i);

        }
    }
}
