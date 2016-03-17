using System;
using CA.Immigration.Utility;
using System.Windows.Forms;
using CA.Immigration.Data;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using CA.Immigration.LMIA;

namespace CA.Immigration.LMIA
{
    public static class LMIABusinessDetail
    {
        private static int? _q1 { get; set; }
        private static int? _q2 { get; set; }
        private static int? _q3 { get; set; }
        private static int? _q4 { get; set; }
        private static int? _q5 { get; set; }
        private static bool? _q6 { get; set; }
        private static bool? _q61 { get; set; }
        private static bool? _q7 { get; set; }
        private static bool? _q71 { get; set; }
        private static bool? _q8 { get; set; }
        private static bool? _q81 { get; set; }
        private static DateTime? _q81Date { get; set; }
        private static string _q81FileNumber { get; set; }
        private static string _q81Explanation { get; set; }
        private static bool? _q9 { get; set; }
        private static int? _q91 { get; set; }
        private static int? _q92 { get; set; }
        private static string _q9Reason { get; set; }
        private static bool? _q10 { get; set; }
        private static string _q10Explanation { get; set; }

        public static void getInput(LMIAForm lf)
        {
            _q1 = getValue.getIntValue(lf.txtBizDetailQ1.Text);
            _q2 = getValue.getIntValue(lf.txtBizDetailQ2.Text);
            _q3 = getValue.getIntValue(lf.txtBizDetailQ3.Text);
            _q4 = getValue.getIntValue(lf.txtBizDetailQ4.Text);
            _q5 = getValue.getIntValue(lf.txtBizDetailQ5.Text);
            _q6 = lf.chkLMIA1213.Checked == true ? true : false;
            _q61 = lf.chkLMIACompliance1213.Checked == true ? true : false;
            _q7 = lf.chkLMIA1415.Checked == true ? true : false;
            _q71 = lf.chkLMIACompliance1415.Checked == true ? true : false;
            _q8 = lf.chkBizDetailQ8.Checked == true ? true : false;
            _q81 = lf.chkLMIAMisRep.Checked == true ? true : false;
            _q81Date = lf.DTPQ8.Value;
            _q81FileNumber = lf.txtLMIASFN.Text;
            _q81Explanation = lf.txtLMIAPublicPolicy.Text;
            _q9 = lf.chkBizDetailQ9.Checked == true ? true : false;
            _q91 = getValue.getIntValue(lf.txtLayoffCanadians.Text);
            _q92 = getValue.getIntValue(lf.txtTFWs.Text);
            _q9Reason = lf.chkBizDetailQ9Explain.Text;
            _q10 = lf.chkBizDetailQ10.Checked == true ? true : false;
            _q10Explanation = lf.chkBizDetailQ10Explain.Text;
        }

        // load data from database 
        public static void loadFromDB(LMIAForm lf)
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                tblBusinessDetail bd = cdc.tblBusinessDetails.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if (bd != null)
                {
                    //lf.btnInsertBD.Visible = false;  // business details data existed, so no more insert
                    _q1 = bd.TotalEmployeeUnderCRA;
                    _q2 = bd.TotalEmployeeThisLocation;
                    _q3 = bd.TotalCndThisLocation;
                    _q4 = bd.TotalEmployeeThisOccupationLocation;
                    _q5 = bd.TotalTFWAfterPositive;
                    _q6 = bd.Q6;
                    _q61 = bd.Q6_1;
                    _q7 = bd.Q7;
                    _q71 = bd.Q7_1;
                    _q8 = bd.Q8;
                    _q81 = bd.Q8;
                    _q81Date = bd.Q8_2;
                    _q81FileNumber = bd.Q8_3;
                    _q81Explanation = bd.Q8_4;
                    _q9 = bd.Q9;
                    _q91 = bd.Q9_1;
                    _q92 = bd.Q9_2;
                    _q9Reason = bd.Q9_3;
                    _q10 = bd.Q10;
                    _q10Explanation = bd.Q10_1;
                }
                else { clearForm(lf); }
            }

        }
        public static void loadFromDB()
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                tblBusinessDetail bd = cdc.tblBusinessDetails.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if (bd != null)
                {
                    //lf.btnInsertBD.Visible = false;  // business details data existed, so no more insert
                    _q1 = bd.TotalEmployeeUnderCRA;
                    _q2 = bd.TotalEmployeeThisLocation;
                    _q3 = bd.TotalCndThisLocation;
                    _q4 = bd.TotalEmployeeThisOccupationLocation;
                    _q5 = bd.TotalTFWAfterPositive;
                    _q6 = bd.Q6;
                    _q61 = bd.Q6_1;
                    _q7 = bd.Q7;
                    _q71 = bd.Q7_1;
                    _q8 = bd.Q8;
                    _q81 = bd.Q8;
                    _q81Date = bd.Q8_2;
                    _q81FileNumber = bd.Q8_3;
                    _q81Explanation = bd.Q8_4;
                    _q9 = bd.Q9;
                    _q91 = bd.Q9_1;
                    _q92 = bd.Q9_2;
                    _q9Reason = bd.Q9_3;
                    _q10 = bd.Q10;
                    _q10Explanation = bd.Q10_1;
                }
               
            }

        }

        //fill current form with data
        public static void fillForm(LMIAForm lf)
        {
            lf.txtBizDetailQ1.Text = _q1.ToString();
            lf.txtBizDetailQ2.Text = _q2.ToString();
            lf.txtBizDetailQ3.Text = _q3.ToString();
            lf.txtBizDetailQ4.Text = _q4.ToString();
            lf.txtBizDetailQ5.Text = _q5.ToString();
            lf.chkLMIA1213.Checked = _q6 == true ? true : false;
            lf.chkLMIACompliance1213.Checked = _q61 == true ? true : false;
            lf.chkLMIA1415.Checked = _q7 == true ? true : false;
            lf.chkLMIACompliance1415.Checked = _q71 == true ? true : false;
            lf.chkBizDetailQ8.Checked = _q8 == true ? true : false;
            lf.chkLMIAMisRep.Checked = _q81 == true ? true : false;
            lf.txtLMIASFN.Text = _q81FileNumber;
            lf.txtLMIAPublicPolicy.Text = _q81Explanation;
            lf.chkBizDetailQ9.Checked = _q9 == true ? true : false;
            lf.txtLayoffCanadians.Text = _q91 != null ? _q91.ToString() : null;
            lf.txtTFWs.Text = _q92 != null ? _q92.ToString() : null;
            lf.chkBizDetailQ9Explain.Text = _q9Reason;
            lf.chkBizDetailQ10.Checked = _q10 == true ? true : false;
            lf.chkBizDetailQ10Explain.Text = _q10Explanation;

        }
        //Clear form
        public static void clearForm(LMIAForm lf)
        {
            _q1 = null;
            _q2 = null;
            _q3 = null;
            _q4 = null;
            _q5 = null;
            _q6 = null;
            _q61 = null;
            _q7 = null;
            _q71 = null;
            _q8 = null;
            _q81 = null;
            _q81Date = null;
            _q81FileNumber = null;
            _q81Explanation = null;
            _q9 = null;
            _q91 = null;
            _q92 = null;
            _q9Reason = null;
            _q10 = null;
            _q10Explanation = null;
            fillForm(lf);

        }
        public static void Insert2DB(LMIAForm lf)
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                tblBusinessDetail bd = new tblBusinessDetail
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    TotalEmployeeUnderCRA = _q1,
                    TotalEmployeeThisLocation = _q2,
                    TotalCndThisLocation = _q3,
                    TotalEmployeeThisOccupationLocation = _q4,
                    TotalTFWAfterPositive = _q5,
                    Q6 = _q6,
                    Q6_1 = _q61,
                    Q7 = _q7,
                    Q7_1 = _q71,
                    Q8 = _q8,
                    Q8_1 = _q81,
                    Q8_2 = _q81Date,
                    Q8_3 = _q81FileNumber,
                    Q8_4 = _q81Explanation,
                    Q9 = _q9,
                    Q9_1 = _q91,
                    Q9_2 = _q92,
                    Q9_3 = _q9Reason,
                    Q10 = _q10,
                    Q10_1 = _q10Explanation
                };
                try
                {
                    cdc.tblBusinessDetails.InsertOnSubmit(bd);
                    cdc.SubmitChanges();
                    GlobalData.CurrentBusinessDetailId = bd.Id;  // set up global data
                    lf.btnInsertBD.Visible = false;
                    MessageBox.Show("Data has been inserted to database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
            }
        }
        public static void deleteRecord(LMIAForm lf)
        {
            if (MessageBox.Show("Are you sure to delete the record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (CommonDataContext cdc = new CommonDataContext())
                {
                    List<tblBusinessDetail> bd = cdc.tblBusinessDetails.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).ToList();
                    if (bd.Count != 0)
                    {
                        foreach (tblBusinessDetail b in bd)
                        {
                            cdc.tblBusinessDetails.DeleteOnSubmit(b);
                        }
                        try

                        {
                            cdc.SubmitChanges();
                            LMIABusinessDetail.clearForm(lf);
                            MessageBox.Show("Business details record has been deleted from database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        catch (Exception exc)
                        {

                            MessageBox.Show(exc.Message);
                        }
                    }
                    else MessageBox.Show("There is no record to delete!", "Null operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public static void updateRecord(int applicationid)
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                tblBusinessDetail bd = cdc.tblBusinessDetails.Where(x => x.ApplicationId == applicationid).Select(x => x).FirstOrDefault();

                if (bd != null)
                {
                    bd.ApplicationId = applicationid;
                    bd.TotalEmployeeUnderCRA = _q1;
                    bd.TotalEmployeeThisLocation = _q2;
                    bd.TotalCndThisLocation = _q3;
                    bd.TotalEmployeeThisOccupationLocation = _q4;
                    bd.TotalTFWAfterPositive = _q5;
                    bd.Q6 = _q6;
                    bd.Q6_1 = _q61;
                    bd.Q7 = _q7;
                    bd.Q7_1 = _q71;
                    bd.Q8 = _q8;
                    bd.Q8_1 = _q81;
                    bd.Q8_2 = _q81Date;
                    bd.Q8_3 = _q81FileNumber;
                    bd.Q8_4 = _q81Explanation;
                    bd.Q9 = _q9;
                    bd.Q9_1 = _q91;
                    bd.Q9_2 = _q92;
                    bd.Q9_3 = _q9Reason;
                    bd.Q10 = _q10;
                    bd.Q10_1 = _q10Explanation;

                    try
                    {
                        cdc.SubmitChanges();
                        GlobalData.CurrentBusinessDetailId = bd.Id;  // set up global data
                        MessageBox.Show("Business details data has been updated to database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception exc)
                    {

                        MessageBox.Show(exc.Message);
                    }
                }
                else MessageBox.Show("There is no business detail record. You should insert one first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public static void buildupDict5602(ref Dictionary<string, string> dict)
        {
            loadFromDB();
            dict.Add("EMP5602_E[0].Page2[0].txtF_number_employess_CRA[0]",_q1==null?"":_q1.ToString());
            dict.Add("EMP5602_E[0].Page2[0].txtF_total_number[0]", _q2 == null ? "" : _q2.ToString());
            dict.Add("EMP5602_E[0].Page2[0].txtF_total_number_location[0]",_q3 == null ? "" : _q3.ToString());
            dict.Add("EMP5602_E[0].Page2[0].txtF_total_number_lmo[0]", _q4 == null ? "" : _q4.ToString());
            dict.Add("EMP5602_E[0].Page2[0].txtF_total_number_Emp[0]", _q4 == null ? "" : _q4.ToString());

            //dict.Add();
            //dict.Add();
            //dict.Add();
            //dict.Add();
            //dict.Add();
            //dict.Add();
            //dict.Add();
            //dict.Add();
            //dict.Add();
            //dict.Add();
            //dict.Add();
            //dict.Add();
            //dict.Add();
            //dict.Add();
            if (_q81==true)
            {
                dict.Add("EMP5602_E[0].Page2[0].txtF_Date_E[0]", String.Format("{0:yyyy-MM-dd}", _q81Date.ToString()));
                dict.Add("EMP5602_E[0].Page2[0].txtF_File_Number[0]", _q81FileNumber);
                dict.Add("EMP5602_E[0].Page2[0].txtF_Reasons_for_Layoffs[0]", _q81Explanation); 
            }
            






        }
    }
}


