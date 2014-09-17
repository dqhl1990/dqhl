using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapTest.Models.SqlServerOperation;
using BootstrapTest.Models.CustomClass;

namespace BootstrapTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchGoals(int UserID)
        {
            SqlFunctionalOperation searchgoals = new SqlFunctionalOperation();
            ControlGoals controlgoalsresults = new ControlGoals();
            controlgoalsresults = searchgoals.SearchControlGoals(UserID);
            return Json(controlgoalsresults);
        }

        public ActionResult UpateGoals(int UserID,float HbA1c, float FPG, bool FPGflag, float PPG, bool PPGflag, float BPH, float BPL, float Tch, bool Tchflag, float LDLch, bool LDLchflag, float HDLch, bool HDLchflag, float TG, bool TGflag, float Ua, bool Uaflag, float AlbCr, bool AlbCrflag, float Athlete, float Weight)
        {
            ControlGoalsResults newcontrolgoals = new ControlGoalsResults();
            newcontrolgoals.UserID = UserID;
            newcontrolgoals.HbA1c = HbA1c;
            newcontrolgoals.FPG = FPG;
            newcontrolgoals.FPGflag = FPGflag;
            newcontrolgoals.PPG = PPG;
            newcontrolgoals.PPGflag = PPGflag;
            newcontrolgoals.BPH = BPH;
            newcontrolgoals.BPL = BPL;
            newcontrolgoals.Tch = Tch;
            newcontrolgoals.Tchflag = Tchflag;
            newcontrolgoals.LDLch = LDLch;
            newcontrolgoals.LDLchflag = LDLchflag;
            newcontrolgoals.HDLch = HDLch;
            newcontrolgoals.HDLchflag = HDLchflag;
            newcontrolgoals.TG = TG;
            newcontrolgoals.TGflag = TGflag;
            newcontrolgoals.Ua = Ua;
            newcontrolgoals.Uaflag = Uaflag;
            newcontrolgoals.AlbCr = AlbCr;
            newcontrolgoals.AlbCrflag = AlbCrflag;
            newcontrolgoals.Athlete = Athlete;
            newcontrolgoals.Weight = Weight;

            SqlFunctionalOperation updategoals = new SqlFunctionalOperation();
            int i = updategoals.UpdateControlGoals(newcontrolgoals);

            SqlFunctionalOperation searchgoals = new SqlFunctionalOperation();
            ControlGoals controlgoalsresults = new ControlGoals();
            controlgoalsresults = searchgoals.SearchControlGoals(UserID);
            return Json(controlgoalsresults);
        }

        public ActionResult InsertBSPlan(int UserID, string Project, string Frequency, string Time, string Date,int Type)
        {
            SqlFunctionalOperation insertBSplan = new SqlFunctionalOperation();
            string[][] i = insertBSplan.InsertBSPlan(UserID, Project, Frequency, Time, Date,Type);

            return Json(i);
        }

        public ActionResult SearchBSPlan(int UserID)
        {
            SqlFunctionalOperation searchBSplan = new SqlFunctionalOperation();
            string[][] BSPlan = searchBSplan.SearchBSPlan(UserID);
            return Json(BSPlan);
        }

        public ActionResult UpdatePlan(int UserID, int PlanID, string Project, string NewValue)
        {
            SqlFunctionalOperation updateplan = new SqlFunctionalOperation();
            int i = updateplan.UpdatePlan(UserID, PlanID, Project, NewValue);
            return Json(i);
        }
    }
}
