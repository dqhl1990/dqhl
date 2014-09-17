using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using BootstrapTest.Models.CustomClass;
using BootstrapTest.Models.SqlServerOperation;

namespace BootstrapTest.Models.SqlServerOperation
{
    public class SqlFunctionalOperation
    {
        //控制目标在建立用户时应为其自动设置默认值
        //查找控制目标
        public ControlGoals SearchControlGoals(int UserID)
        {
            string sqlorder = string.Format("SELECT * FROM ControlGoals WHERE UserID={0}", UserID);
            SqlBasicOperation searchgoals = new SqlBasicOperation();
            DataSet dataset = new DataSet();
            dataset = searchgoals.Search(sqlorder);
            ControlGoals goals = new ControlGoals();
            //ControlGoalsResults controlgoalsresults = new ControlGoalsResults();
            if (dataset.Tables[0].Rows.Count != 0)
            {
                goals.UserID = Convert.ToInt32(dataset.Tables[0].Rows[0][0]);
                goals.ControlGoalID = Convert.ToInt32(dataset.Tables[0].Rows[0][1]);
                goals.HbA1c = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][2]);
                goals.FPGmmolL = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][3]);
                goals.FPGmgdl = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][4]);
                goals.FPGflag = (bool)dataset.Tables[0].Rows[0][5];
                goals.PPGmmolL = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][6]);
                goals.PPGmgdl = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][7]);
                goals.PPGflag = (bool)dataset.Tables[0].Rows[0][8];
                goals.BPH = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][9]);
                goals.BPL = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][10]);
                goals.TchmmolL = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][11]);
                goals.Tchmgdl = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][12]);
                goals.Tchflag = (bool)dataset.Tables[0].Rows[0][13];
                goals.LDLchmmolL = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][14]);
                goals.LDLchmgdl = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][15]);
                goals.LDLchflag = (bool)dataset.Tables[0].Rows[0][16];
                goals.HDLchmmolL = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][17]);
                goals.HDLchmgdl = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][18]);
                goals.HDLchflag = (bool)dataset.Tables[0].Rows[0][19];
                goals.TGmmolL = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][20]);
                goals.TGmgdl = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][21]);
                goals.TGflag = (bool)dataset.Tables[0].Rows[0][22];
                goals.UaumolL = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][23]);
                goals.Uamgdl = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][24]);
                goals.Uaflag = (bool)dataset.Tables[0].Rows[0][25];
                goals.AlbCrmgmmol = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][26]);
                goals.AlbCrmgg = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][27]);
                goals.AlbCrflag = (bool)dataset.Tables[0].Rows[0][28];
                goals.Athlete = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][29]);
                goals.Weight = (float)Convert.ToDouble(dataset.Tables[0].Rows[0][30]);

                
            //    controlgoalsresults.UserID = goals.UserID;

            //    controlgoalsresults.HbA1c = goals.HbA1c;

            //    if (goals.FPGflag == true)
            //    {
            //        controlgoalsresults.FPG = goals.FPGmmolL;
            //    }
            //    else
            //    {
            //        controlgoalsresults.FPG = goals.FPGmgdl;
            //    }
            //    controlgoalsresults.FPGflag = goals.FPGflag;

            //    if (goals.PPGflag == true)
            //    {
            //        controlgoalsresults.PPG = goals.PPGmmolL;
            //    }
            //    else
            //    {
            //        controlgoalsresults.PPG = goals.PPGmgdl;
            //    }
            //    controlgoalsresults.PPGflag = goals.PPGflag;

            //    controlgoalsresults.BPH = goals.BPH;

            //    controlgoalsresults.BPL = goals.BPL;

            //    if (goals.Tchflag == true)
            //    {
            //        controlgoalsresults.Tch = goals.TchmmolL;
            //    }
            //    else
            //    {
            //        controlgoalsresults.Tch = goals.Tchmgdl;
            //    }
            //    controlgoalsresults.Tchflag = goals.Tchflag;

            //    if (goals.LDLchflag == true)
            //    {
            //        controlgoalsresults.LDLch = goals.LDLchmmolL;
            //    }
            //    else
            //    {
            //        controlgoalsresults.LDLch = goals.LDLchmgdl;
            //    }
            //    controlgoalsresults.LDLchflag = goals.LDLchflag;

            //    if (goals.TGflag == true)
            //    {
            //        controlgoalsresults.TG = goals.TGmmolL;
            //    }
            //    else
            //    {
            //        controlgoalsresults.TG = goals.TGmgdl;
            //    }
            //    controlgoalsresults.TGflag = goals.TGflag;

            //    if (goals.Uaflag == true)
            //    {
            //        controlgoalsresults.Ua = goals.UaumolL;
            //    }
            //    else
            //    {
            //        controlgoalsresults.Ua = goals.Uamgdl;
            //    }
            //    controlgoalsresults.Uaflag = goals.Uaflag;

            //    controlgoalsresults.Athlete = goals.Athlete;

            //    controlgoalsresults.Weight = goals.Weight;

                
            //    if (goals.HDLchflag == true)
            //    {
            //        controlgoalsresults.HDLch = goals.HDLchmmolL;
            //    }
            //    else
            //    {
            //        controlgoalsresults.HDLch = goals.HDLchmgdl;
            //    }
            //    controlgoalsresults.HDLchflag = goals.HDLchflag;
            //    if (goals.AlbCrflag == true)
            //    {
            //        controlgoalsresults.AlbCr = goals.AlbCrmgmmol;
            //    }
            //    else
            //    {
            //        controlgoalsresults.AlbCr = goals.AlbCrmgg;
            //    }
            //    controlgoalsresults.AlbCrflag = goals.AlbCrflag;
            }
                
            else
            {
                //goals.UserID = 0;
                //controlgoalsresults.UserID = 0;
                goals.UserID = 0;
            }


            return goals;

        }

        //更新控制目标
        public int UpdateControlGoals(ControlGoalsResults newcontrolgoals)
        {
            
            string sqlorder1 = string.Format("UPDATE ControlGoals SET HbA1c={0},BPH={1},BPL={2},Athlete={3},Weight={4},",newcontrolgoals.HbA1c,newcontrolgoals.BPH,newcontrolgoals.BPL,newcontrolgoals.Athlete,newcontrolgoals.Weight);
            if (newcontrolgoals.FPGflag == true)
            {
                string sqlorder = string.Format("FPGmmolL={0},FPGflag={1},", newcontrolgoals.FPG,1);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);               
            }
            else
            {
                string sqlorder = string.Format("FPGmgdl={0},FPGflag={1},", newcontrolgoals.FPG,0);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            if (newcontrolgoals.PPGflag == true)
            {
                string sqlorder = string.Format("PPGmmolL={0},PPGflag={1},", newcontrolgoals.PPG,1);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            else
            {
                string sqlorder = string.Format("PPGmgdl={0},PPGflag={1},", newcontrolgoals.PPG,0);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            if (newcontrolgoals.Tchflag == true)
            {
                string sqlorder = string.Format("TchmmolL={0},Tchflag={1},", newcontrolgoals.Tch, 1);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            else
            {
                string sqlorder = string.Format("Tchmgdl={0},Tchflag={1},", newcontrolgoals.Tch, 0);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            if (newcontrolgoals.LDLchflag == true)
            {
                string sqlorder = string.Format("LDLchmmolL={0},LDLchflag={1},", newcontrolgoals.LDLch, 1);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            else
            {
                string sqlorder = string.Format("LDLchmgdl={0},LDLchflag={1},", newcontrolgoals.LDLch, 0);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            if (newcontrolgoals.HDLchflag == true)
            {
                string sqlorder = string.Format("HDLchmmolL={0},HDLchflag={1},", newcontrolgoals.HDLch, 1);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            else
            {
                string sqlorder = string.Format("HDLchmgdl={0},HDLchflag={1},", newcontrolgoals.HDLch, 0);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            if (newcontrolgoals.TGflag == true)
            {
                string sqlorder = string.Format("TGmmolL={0},TGflag={1},", newcontrolgoals.TG, 1);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            else
            {
                string sqlorder = string.Format("TGmgdl={0},TGflag={1},", newcontrolgoals.TG, 0);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            if (newcontrolgoals.Uaflag == true)
            {
                string sqlorder = string.Format("UaumolL={0},Uaflag={1},", newcontrolgoals.Ua, 1);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            else
            {
                string sqlorder = string.Format("Uamgdl={0},Uaflag={1},", newcontrolgoals.Ua,0);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            if (newcontrolgoals.AlbCrflag == true)
            {
                string sqlorder = string.Format("AlbCrmgmmol={0},AlbCrflag={1}", newcontrolgoals.AlbCr, 1);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            else
            {
                string sqlorder = string.Format("AlbCrmgg={0},AlbCrflag={1}", newcontrolgoals.AlbCr, 0);
                sqlorder1 = string.Concat(sqlorder1, sqlorder);
            }
            string sqlorder2 = string.Format(" WHERE UserID={0}", newcontrolgoals.UserID);
            sqlorder1 = string.Concat(sqlorder1, sqlorder2);

            SqlBasicOperation updategoals = new SqlBasicOperation();
            int i = updategoals.Update(sqlorder1);

            return i;
        }

        //插入血糖计划并同时触发更新今日提醒
        public string[][] InsertBSPlan(int UserID,string Project,string Frequency,string Time,string Date,int Type)
        {
            string sqlorder = string.Format("INSERT INTO BSPlan (UserID,Project,Frequency,Time,OriginDate,Type) VALUES ({0},'{1}','{2}','{3}','{4}',{5})", UserID, Project, Frequency, Time, Date,Type);
            SqlBasicOperation insertBSplan = new SqlBasicOperation();
            int i = insertBSplan.Insert(sqlorder);
            InitializeTA(UserID);
            string[][] Plan = SearchBSPlan(UserID);

            return Plan;
        }

        //查找血糖计划用于表格显示
        public string[][] SearchBSPlan(int UserID)
        {
            string sqlorder = string.Format("SELECT * FROM BSPlan WHERE UserID={0}",UserID);
            SqlBasicOperation searchBSplan = new SqlBasicOperation();
            DataSet dataset = searchBSplan.Search(sqlorder);
            if (dataset.Tables[0].Rows.Count != 0)
            {
                
                string[][] BSPlan = new string[dataset.Tables[0].Rows.Count][];
                int i = 0;
                foreach (DataRow datarow in dataset.Tables[0].Rows)
                {
                    DateTime dt = Convert.ToDateTime(datarow[5]);
                    string a = dt.ToString("yyyy-MM-dd");
                    string b = datarow[4].ToString();
                    DateTime dt1 = Convert.ToDateTime(b);
                    string c = dt1.ToString("HH:mm");
                    BSPlan[i] = new string[] { datarow[0].ToString(), datarow[1].ToString(), datarow[2].ToString(), datarow[3].ToString(), c, a,datarow[6].ToString() };
                    i++;
                    
                }
                dataset.Dispose();
                return BSPlan;

            }
            else
            {
                string[][] i = new string[1][];
                
                i[0] =new string[]{ "空"};
                return i;
            }

        }

        //更新血糖计划并同时触发更新今日提醒
        public int UpdatePlan(int UserID,int PlanID,string Project,string NewValue)
        {
            string sqlorder = null;
            switch (Project)
            {
                case "监测项目":
                    sqlorder = string.Format("UPDATE BSPlan SET Project = '{0}' WHERE UserID = {1} AND PlanID = {2}", NewValue, UserID, PlanID);
                    break;
                case "频率":
                    sqlorder = string.Format("UPDATE BSPlan SET Frequency = '{0}' WHERE UserID = {1} AND PlanID = {2}", NewValue, UserID, PlanID);
                    break;
                case "闹钟":
                    sqlorder = string.Format("UPDATE BSPlan SET Time = '{0}' WHERE UserID = {1} AND PlanID = {2}", NewValue, UserID, PlanID);
                    break;
                case "起效日期":
                    sqlorder = string.Format("UPDATE BSPlan SET OriginDate = '{0}' WHERE UserID = {1} AND PlanID = {2}", NewValue, UserID, PlanID);
                    break;
                case "删除":
                    sqlorder = string.Format("DELETE FROM BSPlan WHERE UserID = {0} AND PlanID = {1}", UserID, PlanID);
                    break;

            }
            SqlBasicOperation updateplan = new SqlBasicOperation();
            if (Project != "删除")
            {
                DateTime now = DateTime.Now;
                string a = now.ToString("yyyy-MM-dd");
                int i = updateplan.Update(sqlorder);
                UpdateTA(UserID,PlanID, a);
                return i;
            }
            else
            {
                DateTime now = DateTime.Now;
                string a = now.ToString("yyyy-MM-dd");
                int i = updateplan.Delete(sqlorder);
                DeleteTA(UserID,PlanID,a);
                return i;
            }
            
            
        }

        //初始化今日提醒
        private void InitializeTA(int UserID)
        {
            string sqlorder = string.Format("SELECT * FROM BSPlan WHERE UserID={0}", UserID);
            SqlBasicOperation searchallplan = new SqlBasicOperation();
            DataSet dataset = new DataSet();
            dataset = searchallplan.Search(sqlorder);
            if (dataset.Tables[0].Rows.Count != 0)
            {
                foreach (DataRow datarow in dataset.Tables[0].Rows)
                {
                    string a = null;
                    string b = null;
                    
                    switch (datarow[3].ToString())
                    {
                        case "仅一次":
                            DateTime origin = Convert.ToDateTime(datarow[5]);
                            a = origin.ToString("yyyy-MM-dd");
                            DateTime now = DateTime.Now;
                            b = now.ToString("yyyy-MM-dd");
                            if (a == b)
                            {
                                SearchMaybeInsertTA(datarow,b);                              
                            }
                            break;
                        case "1次/天":
                            DateTime now1 = DateTime.Now;
                            DateTime origin1 = Convert.ToDateTime(datarow[5]);
                            string b1 = now1.ToString("yyyy-MM-dd");
                            
                            if(DateTime.Compare(origin1,now1)<=0)
                            {
                               SearchMaybeInsertTA(datarow, b1);
                            }
                            
                            break;
                        case "1次/周":
                            DateTime origin2 = Convert.ToDateTime(datarow[5]);
                            a = origin2.DayOfWeek.ToString();
                            DateTime now2 = DateTime.Now;                            
                            b = now2.DayOfWeek.ToString();
                            string b2 = now2.ToString("yyyy-MM-dd");
                            if (a == b && DateTime.Compare(origin2,now2)<=0)
                            {
                                SearchMaybeInsertTA(datarow, b2);
                            }
                            break;
                        case "1次/月":
                            DateTime origin3 = Convert.ToDateTime(datarow[5]);
                            a = origin3.Day.ToString();
                            DateTime now3 = DateTime.Now;
                            b = now3.Day.ToString();
                            string b3 = now3.ToString("yyyy-MM-dd");
                            if (a == b && DateTime.Compare(origin3,now3)<=0)
                            {
                                SearchMaybeInsertTA(datarow, b3);
                            }
                            break;
                        case "1次/季度":
                            DateTime origin4 = Convert.ToDateTime(datarow[5]);
                            a = origin4.Day.ToString();
                            float x = origin4.Month;
                            DateTime now4 = DateTime.Now;
                            float y = now4.Month;
                            b = now4.Day.ToString();
                            string b4 = now4.ToString("yyyy-MM-dd");
                            string z = Convert.ToString((x - y)/3);
                            int ss;
                            bool aa = int.TryParse(z, out ss);
                            //z = Math.Abs(z);
                            if(a == b && aa && DateTime.Compare(origin4,now4)<=0)
                            {                                          
                                  SearchMaybeInsertTA(datarow, b4);                                                            
                            }
                            break; 
                         case "1次/每年":
                            DateTime origin5 = Convert.ToDateTime(datarow[5]);
                            a = origin5.Day.ToString();
                            string a5 = origin5.Month.ToString();
                            DateTime now5 = DateTime.Now;
                            b = now5.Day.ToString();
                            string b5 = now5.Month.ToString();
                            string b6 = now5.ToString("yyyy-MM-dd");
                            if (a == b && a5 == b5 && DateTime.Compare(origin5,now5)<=0)
                            {
                                SearchMaybeInsertTA(datarow, b6);
                            }
                            break;
                    }               
                }
            }
            dataset.Dispose();
        }

        //初始化今日提醒的子函数
        private void SearchMaybeInsertTA(DataRow datarow ,string b)
        {
            string sqlorderforSTA = string.Format("SELECT * FROM TodayAlert WHERE UserID={0} AND PlanID={1} AND AlertDate='{2}'", datarow[0], datarow[1], b);
            SqlBasicOperation searchTA = new SqlBasicOperation();
            DataSet dataTA = searchTA.Search(sqlorderforSTA);
            if (dataTA.Tables[0].Rows.Count == 0)
            {
                string sqlorderforITA = string.Format("INSERT INTO TodayAlert (UserID,PlanID,Project,Time,Completion,AlertDate,Type) VALUES ({0},{1},'{2}','{3}',{4},'{5}',{6})", datarow[0], datarow[1], datarow[2], datarow[4], 0, b,datarow[6]);
                SqlBasicOperation insertTA = new SqlBasicOperation();
                insertTA.Insert(sqlorderforITA);
            }
            dataTA.Dispose();
        }

        //更新血糖计划时若是删除操作则删除当日相应的今日提醒
        private void DeleteTA(int UserID,int PlanID,string a)
        {
            string sqlorder = string.Format("DELETE FROM TodayAlert WHERE UserID={0} AND PlanID={1} AND AlertDate='{2}'", UserID, PlanID, a);
            SqlBasicOperation deletetodayalert = new SqlBasicOperation();
            deletetodayalert.Delete(sqlorder);            
        }

        //更新血糖计划时若是修改操作则将今日提醒当日相关条目删除并重新初始化
        private void UpdateTA(int UserID,int PlanID, string AlertDate)
        {
            string sqlorder = string.Format("DELETE FROM TodayAlert WHERE UserID={0} AND PlanID = {1} AND AlertDate='{2}'", UserID,PlanID ,AlertDate);
            SqlBasicOperation updatetodayalert = new SqlBasicOperation();
            int i = updatetodayalert.Delete(sqlorder);
            if (i > 0)
            {
               InitializeTA(UserID);
            } 
        }

        //今日提醒显示
        public string[][] SearchTA(int UserID)
        {
            InitializeTA(UserID);
            DateTime now = DateTime.Now;
            string a = now.ToString("yyyy-MM-dd");
            string sqlorder = string.Format("SELECT * FROM TodayAlert WHERE UserID = {0} AND AlertDate ='{1}'", UserID, a);
            SqlBasicOperation searchTA = new SqlBasicOperation();
            DataSet dataset = searchTA.Search(sqlorder);
            if (dataset.Tables[0].Rows.Count != 0)
            {
                string[][] TodayAlert = new string[dataset.Tables[0].Rows.Count][];
                int i = 0;
                foreach (DataRow datarow in dataset.Tables[0].Rows)
                {
                    string b = datarow[4].ToString();
                    DateTime dt = Convert.ToDateTime(b);
                    string c = dt.ToString("HH:mm");
                    DateTime dt1 = Convert.ToDateTime(datarow[6]);
                    string d = dt1.ToString("yyyy-MM-dd");
                    TodayAlert[i] = new string[] { datarow[0].ToString(), datarow[1].ToString(), datarow[2].ToString(), datarow[3].ToString(), c,datarow[5].ToString(), d,datarow[7].ToString() };
                    i++;
                }
                dataset.Dispose();
                return TodayAlert;
            }
            else
            {
                string[][] i = new string[1][];

                i[0] = new string[] { "空" };
                return i;
            }

        }

        //今日提醒中修改闹钟
        public int UpdateTimeFromTA(int UserID,int PlanID,int TodayAlertID,string NewTimeFromTA)
        {
            SqlBasicOperation UpdateTimeOfAll = new SqlBasicOperation();
            string sqlorder = string.Format("UPDATE BSPlan SET Time = '{0}' WHERE UserID = {1} AND PlanID = {2}", NewTimeFromTA, UserID, PlanID);
            UpdateTimeOfAll.Update(sqlorder);
            sqlorder = string.Format("UPDATE TodayAlert SET Time = '{0}',Completion = 0 WHERE UserID = {1} AND PlanID = {2} AND TodayAlertID = {3}", NewTimeFromTA, UserID, PlanID, TodayAlertID);
            int i = UpdateTimeOfAll.Update(sqlorder);
            return i;
        }

        //修改完成标志位
        public int UpdateCompletion(int UserID,int PlanID,int Flag,string AlertDate)
        {
            string sqlorder = string.Format("UPDATE TodayAlert SET Completion = {0} WHERE UserID = {1} AND PlanID = {2} AND AlertDate = '{3}'", Flag, UserID, PlanID, AlertDate);
            SqlBasicOperation UpdateCompletion = new SqlBasicOperation();
            int i = UpdateCompletion.Update(sqlorder);

            return i;
        }
    }
}