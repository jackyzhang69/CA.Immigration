using System;
using CA.Immigration.Utility;
using System.Windows.Forms;
using CA.Immigration.Data;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace CA.Immigration.LMIA
{
    public static class LMIABusinessDetail
    {
        private static int? q1 { get; set; }
        private static int? q2 { get; set; }
        private static int? q3 { get; set; }
        private static int? q4 { get; set; }
        private static int? q5 { get; set; }
        private static bool? q6 { get; set; }
        private static bool? q61 { get; set; }
        private static bool? q7 { get; set; }
        private static bool? q71 { get; set; }
        private static bool? q8 { get; set; }
        private static bool? q81 { get; set; }
        private static DateTime? q81Date { get; set; }
        private static string q81FileNumber { get; set; }
        private static string q81Explanation { get; set; }
        private static bool? q9 { get; set; }
        private static int? q91 { get; set; }
        private static int? q92 { get; set; }
        private static string q9Reason { get; set; }
        private static bool? q10 { get; set; }
        private static string q10Explanation { get; set; }

        //private static int? getValue(LMIAForm lf, string input)
        //{
        //    int? value = null;
        //    if(Validation.IsInt(lf.txtBizDetailQ1.Text)) value = int.Parse(lf.txtBizDetailQ1.Text);
        //    if(lf.txtBizDetailQ1.Text == string.Empty) value = null;
        //    return value;
        //}

        public static void getInput(LMIAForm lf)
        {
            q1 = LMIATools.getIntValue(lf.txtBizDetailQ1.Text);
            q2 = LMIATools.getIntValue(lf.txtBizDetailQ2.Text);
            q3 = LMIATools.getIntValue(lf.txtBizDetailQ3.Text);
            q4 = LMIATools.getIntValue(lf.txtBizDetailQ4.Text);
            q5 = LMIATools.getIntValue(lf.txtBizDetailQ5.Text);
            q6 = lf.chkLMIA1213.Checked == true ? true : false;
            q61 = lf.chkLMIACompliance1213.Checked == true ? true : false;
            q7 = lf.chkLMIA1415.Checked == true ? true : false;
            q71 = lf.chkLMIACompliance1415.Checked == true ? true : false;
            q8 = lf.chkBizDetailQ8.Checked == true ? true : false;
            q81 = lf.chkLMIAMisRep.Checked == true ? true : false;
            q81Date = lf.DTPQ8.Value;
            q81FileNumber = lf.txtLMIASFN.Text;
            q81Explanation = lf.txtLMIAPublicPolicy.Text;
            q9 = lf.chkBizDetailQ9.Checked == true ? true : false;
            q91 = LMIATools.getIntValue(lf.txtLayoffCanadians.Text);
            q92 = LMIATools.getIntValue(lf.txtTFWs.Text);
            q9Reason = lf.chkBizDetailQ9Explain.Text;
            q10 = lf.chkBizDetailQ10.Checked == true ? true : false;
            q10Explanation = lf.chkBizDetailQ10Explain.Text;
        }

        // load data from database 
        public static void loadFromDB(int applicationId, LMIAForm lf)
        {
            using(CommonDataContext cdc = new CommonDataContext())
            {
                tblBusinessDetail bd = cdc.tblBusinessDetails.Where(x => x.ApplicationId == applicationId).Select(x => x).FirstOrDefault();
                if(bd != null)
                {
                    lf.btnInsertBD.Visible = false;  // business details data existed, so no more insert
                    q1 = bd.TotalEmployeeUnderCRA;
                    q2 = bd.TotalEmployeeThisLocation;
                    q3 = bd.TotalCndThisLocation;
                    q4 = bd.TotalEmployeeThisOccupationLocation;
                    q5 = bd.TotalTFWAfterPositive;
                    q6 = bd.Q6 == 2 ? true : false;
                    q61 = bd.Q6_1 == 2 ? true : false;
                    q7 = bd.Q7 == 2 ? true : false;
                    q71 = bd.Q7_1 == 2 ? true : false;
                    q8 = bd.Q8 == 2 ? true : false;
                    q81 = bd.Q8_1 == 2 ? true : false;
                    q81Date = bd.Q8_2;
                    q81FileNumber = bd.Q8_3;
                    q81Explanation = bd.Q8_4;
                    q9 = bd.Q9 == 2 ? true : false;
                    q91 = bd.Q9_1;
                    q92 = bd.Q9_2;
                    q9Reason = bd.Q9_3;
                    q10 = bd.Q10 == 2 ? true : false;
                    q10Explanation = bd.Q10_1;
                }
            }

        }

        //fill current form with data
        public static void paintForm(LMIAForm lf)
        {
            lf.txtBizDetailQ1.Text = q1.ToString();
            lf.txtBizDetailQ2.Text = q2.ToString();
            lf.txtBizDetailQ3.Text = q3.ToString();
            lf.txtBizDetailQ4.Text = q4.ToString();
            lf.txtBizDetailQ5.Text = q5.ToString();
            lf.chkLMIA1213.Checked = q6==true?true:false;
            lf.chkLMIACompliance1213.Checked = q61 == true ? true : false; 
            lf.chkLMIA1415.Checked = q7 == true ? true : false; 
            lf.chkLMIACompliance1415.Checked = q71 == true ? true : false; 
            lf.chkBizDetailQ8.Checked = q8 == true ? true : false; 
            lf.chkLMIAMisRep.Checked = q81 == true ? true : false;
            lf.txtLMIASFN.Text = q81FileNumber;
            lf.txtLMIAPublicPolicy.Text = q81Explanation;
            lf.chkBizDetailQ9.Checked = q9 == true ? true : false;
            lf.txtLayoffCanadians.Text = q91!=null?q91.ToString():null;
            lf.txtTFWs.Text = q92!=null?q92.ToString():null;
            lf.chkBizDetailQ9Explain.Text = q9Reason;
            lf.chkBizDetailQ10.Checked = q10 == true ? true : false;
            lf.chkBizDetailQ10Explain.Text = q10Explanation;

        }
        //Clear form
        public static void clearForm(LMIAForm lf)
        {
            lf.txtBizDetailQ1.Text = null;
            lf.txtBizDetailQ2.Text = null;
            lf.txtBizDetailQ3.Text = null;
            lf.txtBizDetailQ4.Text = null;
            lf.txtBizDetailQ5.Text = null;
            lf.chkLMIA1213.Checked = false;
            lf.chkLMIACompliance1213.Checked = false;
            lf.chkLMIA1415.Checked = false;
            lf.chkLMIACompliance1415.Checked = false;
            lf.chkBizDetailQ8.Checked = false;
            lf.chkLMIAMisRep.Checked = false;
            lf.txtLMIASFN.Text = null;
            lf.txtLMIAPublicPolicy.Text = null;
            lf.chkBizDetailQ9.Checked = false;
            lf.txtLayoffCanadians.Text = null;
            lf.txtTFWs.Text = null;
            lf.chkBizDetailQ9Explain.Text = null;
            lf.chkBizDetailQ10.Checked = false;
            lf.chkBizDetailQ10Explain.Text = null;

        }
        public static void Insert2DB(int applicationId, LMIAForm lf)
        {
            using(CommonDataContext cdc = new CommonDataContext())
            {
                tblBusinessDetail bd = new tblBusinessDetail
                {
                    ApplicationId = applicationId,
                    TotalEmployeeUnderCRA = q1,
                    TotalEmployeeThisLocation = q2,
                    TotalCndThisLocation = q3,
                    TotalEmployeeThisOccupationLocation = q4,
                    TotalTFWAfterPositive = q5,
                    Q6 = q6 == true ? 2 : 1,
                    Q6_1 = q61 == true ? 2 : 1,
                    Q7 = q7 == true ? 2 : 1, // need confirm
                    Q7_1 = q71 == true ? 2 : 1,
                    Q8 = q8 == true ? 2 : 1,
                    Q8_1 = q81 == true ? 2 : 1,
                    Q8_2 = q81Date,
                    Q8_3 = q81FileNumber,
                    Q8_4 = q81Explanation,
                    Q9 = q9 == true ? 1 : 0, // need check
                    Q9_1 = q91,
                    Q9_2 = q92,
                    Q9_3 = q9Reason,
                    Q10 = q10 == true ? 2 : 1, // need check
                    Q10_1 = q10Explanation
                };
                try
                {
                    cdc.tblBusinessDetails.InsertOnSubmit(bd);
                    cdc.SubmitChanges();
                    GlobalData.CurrentBusinessDetailId = bd.Id;  // set up global data
                    lf.btnInsertBD.Visible = false;
                    MessageBox.Show("Data has been inserted to database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
            }
        }
        public static void deleteRecord(int applicationdid)
        {
            if(MessageBox.Show("Are you sure to delete the record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using(CommonDataContext cdc = new CommonDataContext())
                {
                    List<tblBusinessDetail> bd = cdc.tblBusinessDetails.Where(x => x.ApplicationId == applicationdid).Select(x => x).ToList();
                    foreach(tblBusinessDetail b in bd)
                    {
                        cdc.tblBusinessDetails.DeleteOnSubmit(b);
                    }
                    cdc.SubmitChanges();
                }
            }
        }
        public static void updateRecord(int applicationid)
        {

        }
    }

}
