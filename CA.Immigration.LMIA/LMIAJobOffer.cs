using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CA.Immigration.Data;
using CA.Immigration.Utility;

namespace CA.Immigration.LMIA
{
    public class LMIAJobOffer
    {
        private static int? _numOfTFWs;
        private static int? _duration;
        private static int? _durationUnit;
        private static string _durationRationale;
        private static DateTime _startDate=DateTime.Today;
        private static bool _languageRequired;
        private static bool _speakingEnglishFrenchRequied;
        private static bool _speakingEnglishRequired;
        private static bool _speakingFrenchRequired;
        private static bool _speakingEnglishOrFrenchRequired;
        private static bool _speakingEnglishAndFrenchRequired;
        private static bool _writingEnglishFrenchRequired;
        private static bool _writingEnglishRequired;
        private static bool _writingFrenchRequired;
        private static bool _writingEnglishOrFrenchRequired;
        private static bool _writingEnglishAndFrenchRequired;
        private static bool _otherLanguageRequired;
        private static string _otherLanguageExplanation;
        private static int? _vacationDays;
        private static int? _remuneration;
        private static string _otherBenefit;
        private static bool _isSeasonal;
        private static bool _isFullyCoveredLMIA;
        private static string _notFullyCoveredReason;
        private static bool _isJobLicensed;
        private static string _licenseAuthority;
        private static bool _licenseReady;
        private static int? _licenseReadyTime;
        private static string _licenseReadyUnit;
        private static bool _isJobUnion;
        private static string _unionNameLocation;
        private static bool _isUnionConsulted;
        private static string _unionNotExplanation;
        private static string _unionOpinion;
        private static bool _attemptedRecruitCanadian;
        private static string _notAttemptedReason;
        private static string _OfficialAdNumber;
        private static string _briefBenefit;
        public  static string _detailedBenefit;
        private static string _briefRationaleOfferingJob;
        private static string _detailedRationaleOfferingJob;
        private static bool _trainCanadian;
        private static string _noTrainReason;
        private static string _trainPlanBrief;
        private static string _trainPlanDetails;
        private static bool _willProvideAccomadation;
        private static string _notProvideButOffer;
        private static int? _provideRent;
        private static string _provideUnit;
        private static string _accommodationDescription;
        private static bool _accomadationNotApplicalbe;
        private static string _whoIsFillingBrief;
        private static string _whoIsFillingDetail;
        private static string _howDidYouFindBrief;
        private static string _howDidYouFindDetail;
        private static string _howDidYouDetermineBrief;
        private static string _howDidYouDetermineDetail;
        private static string _howAndWhenOfferBrief;
        private static string _howAndWhenOfferDetail;

        public static Dictionary<string, string> detailDict = new Dictionary<string, string>();
        public static void getInput(LMIAForm lf)
        {
            _numOfTFWs = getValue.getIntValue(lf.txtJobOfferNumberofTFW.Text);
            _duration = getValue.getIntValue(lf.txtJobOfferExpectedDuration.Text);
            _durationUnit = lf.cmbDurationUnit.SelectedIndex;
            _durationRationale = lf.txtJobOfferDurationRationale.Text;
            _startDate = lf.dtpJobOfferStartDate.Value;
            _languageRequired = lf.chkLanguageRequired.Checked == true ? true : false;
            _speakingEnglishFrenchRequied = lf.chkLIMAOralEnglish.Checked == true ? true : false;
            _speakingEnglishRequired = lf.chkLMIAoralEnglish.Checked == true ? true : false;
            _speakingFrenchRequired = lf.chkLMIAOralFrench.Checked == true ? true : false;
            _speakingEnglishOrFrenchRequired = lf.chkLMIAoralEnglish.Checked == true ? true : false;
            _speakingEnglishAndFrenchRequired = lf.chkLMIAOralEnglisAndFrench.Checked == true ? true : false;

            _writingEnglishFrenchRequired = lf.chkLMIAWritingEnglish.Checked == true ? true : false;
            _writingEnglishRequired = lf.chkLMIAWritingFrench.Checked == true ? true : false;
            _writingFrenchRequired = lf.chkLMIAWritingFrench.Checked == true ? true : false;
            _writingEnglishOrFrenchRequired = lf.chkLMIAWritingEnglisOrFrench.Checked == true ? true : false;
            _writingEnglishAndFrenchRequired = lf.chkLMIAWritingEnglisAndFrench.Checked == true ? true : false;

            _otherLanguageRequired = lf.chkLMIAOtherLanguage.Checked == true ? true : false;
            _otherLanguageExplanation = lf.txtLMIAOtherLanguage.Text;
            if(lf.rdbJobOfferVacationDays.Checked) _vacationDays = getValue.getIntValue(lf.txtJobOfferVacationDays.Text);
            else _vacationDays = null;
            if(lf.rdbJobOfferRemuneration.Checked) _remuneration = getValue.getIntValue(lf.txtJobOfferRemuneraton.Text);
            else _remuneration = null;
            _otherBenefit = lf.txtJobOfferOtherBenifits.Text;
            _isSeasonal = lf.chkJobOfferSeasonal.Checked == true ? true : false;
            _isFullyCoveredLMIA = lf.chkJobOfferFullDuration.Checked == true ? true : false;
            _notFullyCoveredReason = lf.txtJobOfferRemuneration.Text;
            _isJobLicensed = lf.chkJobOfferLicenseNeeded.Checked == true ? true : false;
            _licenseAuthority = lf.txtJobOfferLicenseAuthority.Text;
            _licenseReady = lf.chkJobOfferLicenseReady.Checked == true ? true : false;
            _licenseReadyTime = getValue.getIntValue(lf.txtJobOfferHowlongLicense.Text);
            _licenseReadyUnit = lf.cmbJobOfferDWM.Text;
            _isJobUnion = lf.chkJobOfferIsUnion.Checked == true ? true : false;
            _unionNameLocation = lf.txtJobOfferUnionName.Text;
            _isUnionConsulted = lf.chkJobOfferUnionConsulted.Checked == true ? true : false;
            if(_isUnionConsulted == false) _unionNotExplanation = lf.txtJobOfferUnionExpOrOpinion.Text;
            if(_isUnionConsulted == true) _unionOpinion = lf.txtJobOfferUnionExpOrOpinion.Text;
            _attemptedRecruitCanadian = lf.chkJobOfferRecruitCanadian.Checked == true ? true : false;
            if(_attemptedRecruitCanadian == false) _notAttemptedReason = lf.txtJobOfferRecruitCanadian.Text;
            if(_attemptedRecruitCanadian == true) _OfficialAdNumber = lf.txtJobOfferRecruitCanadian.Text;
            _briefBenefit = lf.txtJobOfferBenefitBrief.Text;
            _detailedBenefit =(detailDict!=null && detailDict.ContainsKey("_detailedBenefit")) ? detailDict["_detailedBenefit"] : string.Empty;
            _briefRationaleOfferingJob = lf.txtJobOfferOfferRationale.Text;
            _detailedRationaleOfferingJob = (detailDict != null && detailDict.ContainsKey("_detailedRationaleOfferingJob")) ? detailDict["_detailedRationaleOfferingJob"] : string.Empty;
            _trainCanadian = lf.chkJobOfferTrainCanadian.Checked == true ? true : false;
            if(_trainCanadian == false) _noTrainReason = lf.txtJobOfferTrainCanadian.Text;
            if(_trainCanadian == true) _trainPlanBrief = lf.txtJobOfferTrainCanadian.Text;
            _trainPlanDetails = (detailDict != null && detailDict.ContainsKey("_trainPlanDetails") )? detailDict["_trainPlanDetails"] : string.Empty;
            _willProvideAccomadation = lf.chkJobOfferProvideAccomadation.Checked = true ? true : false;
            if(_willProvideAccomadation == false) _notProvideButOffer = lf.txtJobOfferProvideAssistant.Text;
            _provideRent = getValue.getIntValue(lf.txtJobOfferProvideRent.Text);
            _provideUnit = lf.cmbJobOfferProvideRent.SelectedText;
            _accommodationDescription = lf.txtJobOfferAccomadationDescription.Text;
            _accomadationNotApplicalbe = lf.chkJobOfferProvideRentNA.Checked == true ? true : false;
            if(lf.lblJobOfferWhoCurrentInThePosition.Visible == true)
            {  //Below are EMP5593 Questions
                _whoIsFillingBrief = lf.txtJobOfferWhoFillInThisJob.Text;
                _whoIsFillingDetail = (detailDict != null && detailDict.ContainsKey("_whoIsFillingDetail")) ? detailDict["_whoIsFillingDetail"] : string.Empty;
            }
            if(lf.lblJobOfferHowDidYouFind.Visible == true)
            {
                _howDidYouFindBrief = lf.txtJobOfferHowDidYouFind.Text;
                _howDidYouFindDetail = (detailDict != null && detailDict.ContainsKey("_howDidYouFindDetail")) ? detailDict["_howDidYouFindDetail"] : string.Empty;
            }
            if(lf.lblJobOfferHowtoQualify.Visible == true)
            {
                _howDidYouDetermineBrief = lf.txtJobOfferHowtoDetermine.Text;
                _howDidYouDetermineDetail = (detailDict != null && detailDict.ContainsKey("_howDidYouDetermineDetail")) ? detailDict["_howDidYouDetermineDetail"] : string.Empty;
            }
            if(lf.lblJobOfferWhentoOffer.Visible == true)
            {
                _howAndWhenOfferBrief = lf.txtJobOfferWhentoOffer.Text;
                _howAndWhenOfferDetail = (detailDict != null && detailDict.ContainsKey("_howAndWhenOfferDetail")) ? detailDict["_howAndWhenOfferDetail"] : string.Empty;
            }

        }
        public static void loadFromDB(LMIAForm lf)
        {
            if(GlobalData.CurrentApplicationId != null)
            {
                using(CommonDataContext cdc = new CommonDataContext())
                {

                    tblJobOffer jo = cdc.tblJobOffers.Where(x => x.applicationID == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                    if(jo != null)
                    {
                        _numOfTFWs = jo.numOfTFWs;
                        _duration = jo.duration;
                        _durationUnit = jo.durationUnit;
                        _durationRationale = jo.durationRationale;
                        _startDate = (jo.startDate==null || (DateTime)jo.startDate<DateTime.MinValue || (DateTime)jo.startDate>DateTime.MaxValue) ?DateTime.Today : (DateTime)jo.startDate;
                        _languageRequired = jo.languageRequired == true ? true : false;
                        _speakingEnglishFrenchRequied = jo.readingEnglishFrenchRequied == true ? true : false;
                        _speakingEnglishRequired = jo.readingEnglishRequired == true ? true : false;
                        _speakingFrenchRequired = jo.readingFrenchRequired == true ? true : false;
                        _speakingEnglishOrFrenchRequired = jo.readingEnglishOrFrenchRequired == true ? true : false;
                        _speakingEnglishAndFrenchRequired = jo.readingEnglishAndFrenchRequired == true ? true : false;
                        _writingEnglishFrenchRequired = jo.writingEnglishFrenchRequired == true ? true : false;
                        _writingEnglishRequired = jo.writingEnglishRequired == true ? true : false;
                        _writingFrenchRequired = jo.writingFrenchRequired == true ? true : false;
                        _writingEnglishOrFrenchRequired = jo.writingEnglishOrFrenchRequired == true ? true : false;
                        _writingEnglishAndFrenchRequired = jo.writingEnglishAndFrenchRequired == true ? true : false;
                        _otherLanguageRequired = jo.otherLanguageRequired == true ? true : false;
                        _otherLanguageExplanation = jo.otherLanguageExplanation;
                        _vacationDays = jo.vacationDays;
                        _remuneration = jo.remuneration;
                        _otherBenefit = jo.otherBenefit;
                        _isSeasonal = jo.isSeasonal == true ? true : false;
                        _isFullyCoveredLMIA = jo.isFullyCoveredLMIA == true ? true : false;
                        _notFullyCoveredReason = jo.notFullyCoveredReason;
                        _isJobLicensed = jo.isJobLicensed == true ? true : false;
                        _licenseAuthority = jo.licenseAuthority;
                        _licenseReady = jo.licenseReady == true ? true : false;
                        _licenseReadyTime = jo.licenseReadyTime;
                        _licenseReadyUnit = jo.licenseReadyUnit;
                        _isJobUnion = jo.isJobUnion == true ? true : false;
                        _unionNameLocation = jo.unionNameLocation;
                        _isUnionConsulted = jo.isUnionConsulted == true ? true : false;
                        _unionNotExplanation = jo.unionNotExplanation;
                        _unionOpinion = jo.unionOpinion;
                        _attemptedRecruitCanadian = jo.attemptedRecruitCanadian == true ? true : false;
                        _notAttemptedReason = jo.notAttemptedReason;
                        _OfficialAdNumber = jo.OfficialAdNumber;
                        _briefBenefit = jo.briefBenefit;
                        _detailedBenefit = jo.detailedBenefit;
                        _briefRationaleOfferingJob = jo.briefRationaleOfferingJob;
                        _detailedRationaleOfferingJob = jo.detailedRationaleOfferingJob;
                        _trainCanadian = jo.trainCanadian == true ? true : false;
                        _noTrainReason = jo.noTrainReason;
                        _trainPlanBrief = jo.trainPlanBrief;
                        _trainPlanDetails = jo.trainPlanDetails;
                        _willProvideAccomadation = jo.willProvideAccomadation == true ? true : false;
                        _notProvideButOffer = jo.notProvideButOffer;
                        _provideRent = jo.provideRent;
                        _provideUnit = jo.provideUnit;
                        _accommodationDescription = jo.accommodationDescription;
                        _accomadationNotApplicalbe = jo.accomadationNotApplicalbe == true ? true : false;
                        _whoIsFillingBrief = jo.whoIsFillingBrief;
                        _whoIsFillingDetail = jo.whoIsFillingDetail;
                        _howDidYouFindBrief = jo.howDidYouFindBrief;
                        _howDidYouFindDetail = jo.howDidYouFindDetail;
                        _howDidYouDetermineBrief = jo.howDidYouDetermineBrief;
                        _howDidYouDetermineDetail = jo.howDidYouDetermineDetail;
                        _howAndWhenOfferBrief = jo.howAndWhenOfferBrief;
                        _howAndWhenOfferDetail = jo.howAndWhenOfferDetail;
                    }
                    else MessageBox.Show("There is no record of job offer in this application!");
                }  // end of using

            }
            else MessageBox.Show("There is no active application existing!");
        }
        public static void fillForm(LMIAForm lf)
        {
            lf.txtJobOfferNumberofTFW.Text = _numOfTFWs.ToString();
            lf.txtJobOfferExpectedDuration.Text = _duration.ToString();
            lf.cmbDurationUnit.SelectedIndex = _durationUnit==null? -1 :(int)_durationUnit;
            lf.txtJobOfferDurationRationale.Text = _durationRationale;
            lf.dtpJobOfferStartDate.Value = (_startDate<DateTime.MinValue || _startDate >DateTime.MaxValue)?DateTime.Today:_startDate;
            lf.chkLanguageRequired.Checked = _languageRequired;
            lf.chkLIMAOralEnglish.Checked = _speakingEnglishFrenchRequied;
            lf.chkLMIAoralEnglish.Checked = _speakingEnglishRequired;
            lf.chkLMIAOralFrench.Checked = _speakingFrenchRequired;
            lf.chkLMIAoralEnglish.Checked = _speakingEnglishOrFrenchRequired;
            lf.chkLMIAOralEnglisAndFrench.Checked = _speakingEnglishAndFrenchRequired;

            lf.chkLMIAWritingEnglish.Checked = _writingEnglishFrenchRequired;
            lf.chkLMIAWritingFrench.Checked = _writingEnglishRequired;
            lf.chkLMIAWritingFrench.Checked = _writingFrenchRequired;
            lf.chkLMIAWritingEnglisOrFrench.Checked = _writingEnglishOrFrenchRequired;
            lf.chkLMIAWritingEnglisAndFrench.Checked = _writingEnglishAndFrenchRequired;

            lf.chkLMIAOtherLanguage.Checked = _otherLanguageRequired;
            lf.txtLMIAOtherLanguage.Text = _otherLanguageExplanation;
            if(_vacationDays != null)
            {
                lf.txtJobOfferVacationDays.Text = _vacationDays.ToString();
                lf.rdbJobOfferVacationDays.Checked = true;
            }
            else {
                lf.rdbJobOfferVacationDays.Checked = false;
                lf.txtJobOfferVacationDays.Text = null;
            }
            if(_remuneration != null)
            {
                lf.txtJobOfferRemuneraton.Text = _remuneration.ToString();
                lf.rdbJobOfferRemuneration.Checked = true;
            }
            else {
                lf.txtJobOfferRemuneraton.Text = null;
                lf.rdbJobOfferRemuneration.Checked = false;
            };
            lf.txtJobOfferOtherBenifits.Text = _otherBenefit;
            lf.chkJobOfferSeasonal.Checked = _isSeasonal;
            lf.chkJobOfferFullDuration.Checked = _isFullyCoveredLMIA;
            lf.txtJobOfferRemuneration.Text = _notFullyCoveredReason;
            lf.chkJobOfferLicenseNeeded.Checked = _isJobLicensed;
            lf.txtJobOfferLicenseAuthority.Text = _licenseAuthority;
            lf.chkJobOfferLicenseReady.Checked = _licenseReady;
            lf.txtJobOfferHowlongLicense.Text = _licenseReadyTime.ToString();
            lf.cmbJobOfferDWM.Text = _licenseReadyUnit;
            lf.chkJobOfferIsUnion.Checked = _isJobUnion;
            lf.txtJobOfferUnionName.Text = _unionNameLocation;
            lf.chkJobOfferUnionConsulted.Checked = _isUnionConsulted;
            if(_isUnionConsulted == false) lf.txtJobOfferUnionExpOrOpinion.Text = _unionNotExplanation;
            if(_isUnionConsulted == true) lf.txtJobOfferUnionExpOrOpinion.Text = _unionOpinion;
            lf.chkJobOfferRecruitCanadian.Checked = _attemptedRecruitCanadian;
            if(_attemptedRecruitCanadian == false) lf.txtJobOfferRecruitCanadian.Text = _notAttemptedReason;
            if(_attemptedRecruitCanadian == true) lf.txtJobOfferRecruitCanadian.Text = _OfficialAdNumber;
            lf.txtJobOfferBenefitBrief.Text = _briefBenefit;
             _detailedBenefit = (detailDict != null && detailDict.ContainsKey("_detailedBenefit"))?detailDict["_detailedBenefit"]:string.Empty;
            lf.txtJobOfferOfferRationale.Text = _briefRationaleOfferingJob;
            _detailedRationaleOfferingJob = (detailDict != null && detailDict.ContainsKey("_detailedRationaleOfferingJob")) ? detailDict["_detailedRationaleOfferingJob"] : string.Empty;
            lf.chkJobOfferTrainCanadian.Checked = _trainCanadian;
            if(_trainCanadian == false) lf.txtJobOfferTrainCanadian.Text = _noTrainReason;
            if(_trainCanadian == true) lf.txtJobOfferTrainCanadian.Text = _trainPlanBrief;
            _trainPlanDetails = (detailDict != null && detailDict.ContainsKey("_trainPlanDetails")) ? detailDict["_trainPlanDetails"] : string.Empty ;
            lf.chkJobOfferProvideAccomadation.Checked = _willProvideAccomadation;
            if(_willProvideAccomadation == false) lf.txtJobOfferProvideAssistant.Text = _notProvideButOffer;
            lf.txtJobOfferProvideRent.Text = _provideRent.ToString();
            lf.cmbJobOfferProvideRent.SelectedText = _provideUnit;
            lf.txtJobOfferAccomadationDescription.Text = _accommodationDescription;
            lf.chkJobOfferProvideRentNA.Checked = _accomadationNotApplicalbe;
            if(lf.lblJobOfferWhoCurrentInThePosition.Visible == true)
            {  //Below are EMP5593 Questions
                lf.txtJobOfferWhoFillInThisJob.Text = _whoIsFillingBrief;
                _whoIsFillingDetail = (detailDict != null && detailDict.ContainsKey("_whoIsFillingDetail")) ? detailDict["_whoIsFillingDetail"] : string.Empty ; 
            }
            if (lf.lblJobOfferHowDidYouFind.Visible == true)
            {
                lf.txtJobOfferHowDidYouFind.Text = _howDidYouFindBrief;
                _howDidYouFindDetail = (detailDict != null && detailDict.ContainsKey("_howDidYouFindDetail")) ? detailDict["_howDidYouFindDetail"] : string.Empty ;
            }
            if (lf.lblJobOfferHowtoQualify.Visible == true)
            {
                lf.txtJobOfferHowtoDetermine.Text = _howDidYouDetermineBrief;
                _howDidYouDetermineDetail = (detailDict != null && detailDict.ContainsKey("_howDidYouDetermineDetail")) ? detailDict["_howDidYouDetermineDetail"] : string.Empty ;
            }
            if (lf.lblJobOfferWhentoOffer.Visible == true)
            {
                lf.txtJobOfferWhentoOffer.Text = _howAndWhenOfferBrief;
                _howAndWhenOfferDetail = (detailDict != null && detailDict.ContainsKey("_howAndWhenOfferDetail")) ? detailDict["_howAndWhenOfferDetail"] : string.Empty;
            }
        }
        public static void clearForm(LMIAForm lf)
        {
            detailDict.Clear();
            lf.txtJobOfferNumberofTFW.Text = null;
            lf.txtJobOfferExpectedDuration.Text = null;
            lf.cmbDurationUnit.SelectedText = null;
            lf.txtJobOfferDurationRationale.Text = null;
            lf.dtpJobOfferStartDate.Value = DateTime.Today;
            lf.chkLanguageRequired.Checked = true;

            lf.chkLIMAOralEnglish.Checked = true;
            lf.chkLMIAoralEnglish.Checked = true;
            lf.chkLMIAOralFrench.Checked = false;
            lf.chkLMIAOralEnglisAndFrench.Checked = false;

            lf.chkLMIAWritingEnglish.Checked = true;
            lf.chkLMIAWritingFrench.Checked = false;
            lf.chkLMIAWritingEnglisOrFrench.Checked = false;
            lf.chkLMIAWritingEnglisAndFrench.Checked = false;

            lf.chkLMIAOtherLanguage.Checked = false;
            lf.txtLMIAOtherLanguage.Text = null;

            lf.txtJobOfferVacationDays.Text = null;
            lf.rdbJobOfferVacationDays.Checked = false;


            lf.txtJobOfferRemuneraton.Text = null;
            lf.rdbJobOfferRemuneration.Checked = false;
            lf.txtJobOfferOtherBenifits.Text = null;
            lf.chkJobOfferSeasonal.Checked = false;
            lf.chkJobOfferFullDuration.Checked = true;
            lf.txtJobOfferRemuneration.Text = null;
            lf.chkJobOfferLicenseNeeded.Checked = false;
            lf.txtJobOfferLicenseAuthority.Text = null;
            lf.chkJobOfferLicenseReady.Checked = false;
            lf.txtJobOfferHowlongLicense.Text = null;
            lf.cmbJobOfferDWM.Text = null;
            lf.chkJobOfferIsUnion.Checked = false;
            lf.txtJobOfferUnionName.Text = null;
            lf.chkJobOfferUnionConsulted.Checked = false;
            lf.txtJobOfferUnionExpOrOpinion.Text = null;
            lf.chkJobOfferRecruitCanadian.Checked = true;
            lf.txtJobOfferRecruitCanadian.Text = null;
            lf.txtJobOfferBenefitBrief.Text = null;
             _detailedBenefit = string.Empty ;
            lf.txtJobOfferOfferRationale.Text = null;
            _detailedRationaleOfferingJob = string.Empty;
            lf.chkJobOfferTrainCanadian.Checked = false;
            lf.txtJobOfferTrainCanadian.Text = null;
            _trainPlanDetails = string.Empty;
            lf.chkJobOfferProvideAccomadation.Checked = false;
            lf.txtJobOfferProvideAssistant.Text = null;
            lf.txtJobOfferProvideRent.Text = null;
            lf.cmbJobOfferProvideRent.SelectedText = null;
            lf.txtJobOfferAccomadationDescription.Text = null;
            lf.chkJobOfferProvideRentNA.Checked = false;
            lf.txtJobOfferWhoFillInThisJob.Text = null;
             _whoIsFillingDetail = string.Empty; 
            lf.txtJobOfferHowDidYouFind.Text = null;

            lf.txtJobOfferHowtoDetermine.Text = null;
            _howDidYouDetermineDetail = string.Empty;
            lf.txtJobOfferWhentoOffer.Text = null;
            _howAndWhenOfferDetail = string.Empty;
            getInput(lf);
            fillForm(lf);
        }
        public static void deleteRecord(LMIAForm lf)
        {
            if(MessageBox.Show("Do you really want to delete the job offer record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(GlobalData.CurrentApplicationId != null)
                {
                    using(CommonDataContext cdc = new CommonDataContext())
                    {
                        tblJobOffer jo = cdc.tblJobOffers.Where(x => x.applicationID == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                        if(jo != null)
                        {
                            try
                            {
                                cdc.tblJobOffers.DeleteOnSubmit(jo);
                                cdc.SubmitChanges();
                                clearForm(lf);
                                MessageBox.Show("Record has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch(Exception)
                            {

                                throw;
                            }
                        }
                        else { MessageBox.Show("There is no Job offer record to delete!"); }
                    }
                }
                else {
                    MessageBox.Show("There is no active application");
                }
            }
        }
        public static void SaveRecord(LMIAForm lf) {

            if(GlobalData.CurrentApplicationId != null)
            {
                using(CommonDataContext cdc = new CommonDataContext())
                {
                    tblJobOffer jo = cdc.tblJobOffers.Where(x => x.applicationID == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                    if(jo != null)
                    {
                        getInput(lf);
                        jo.numOfTFWs= _numOfTFWs;
                        jo.duration= _duration;
                        jo.durationUnit= _durationUnit;
                        jo.durationRationale= _durationRationale;
                        jo.startDate= _startDate;
                        jo.languageRequired = _languageRequired;
                        jo.readingEnglishFrenchRequied = _speakingEnglishFrenchRequied;
                        jo.readingEnglishRequired= _speakingEnglishRequired;
                        jo.readingFrenchRequired = _speakingFrenchRequired;
                        jo.readingEnglishOrFrenchRequired = _speakingEnglishOrFrenchRequired;
                        jo.readingEnglishAndFrenchRequired = _speakingEnglishAndFrenchRequired;
                        jo.writingEnglishFrenchRequired = _writingEnglishFrenchRequired;
                        jo.writingEnglishRequired = _writingEnglishRequired;
                        jo.writingFrenchRequired = _writingFrenchRequired;
                        jo.writingEnglishOrFrenchRequired = _writingEnglishOrFrenchRequired;
                        jo.writingEnglishAndFrenchRequired = _writingEnglishAndFrenchRequired;
                        jo.otherLanguageRequired = _otherLanguageRequired;
                        jo.otherLanguageExplanation= _otherLanguageExplanation;
                        jo.vacationDays= _vacationDays;
                        jo.remuneration= _remuneration;
                        jo.otherBenefit = _otherBenefit;
                        jo.isSeasonal = _isSeasonal;
                        jo.isFullyCoveredLMIA = _isFullyCoveredLMIA;
                        jo.notFullyCoveredReason= _notFullyCoveredReason;
                        jo.isJobLicensed = _isJobLicensed;
                        jo.licenseAuthority= _licenseAuthority;
                        jo.licenseReady = _licenseReady;
                        jo.licenseReadyTime= _licenseReadyTime;
                        jo.licenseReadyUnit= _licenseReadyUnit;
                        jo.isJobUnion = _isJobUnion;
                        jo.unionNameLocation= _unionNameLocation;
                        jo.isUnionConsulted = _isUnionConsulted;
                        jo.unionNotExplanation= _unionNotExplanation;
                        jo.unionOpinion= _unionOpinion;
                        jo.attemptedRecruitCanadian = _attemptedRecruitCanadian;
                        jo.notAttemptedReason= _notAttemptedReason;
                        jo.OfficialAdNumber= _OfficialAdNumber;
                        jo.briefBenefit= _briefBenefit;
                        jo.detailedBenefit= _detailedBenefit;
                        jo.briefRationaleOfferingJob= _briefRationaleOfferingJob;
                        jo.detailedRationaleOfferingJob= _detailedRationaleOfferingJob;
                        jo.trainCanadian = _trainCanadian;
                        jo.noTrainReason= _noTrainReason;
                        jo.trainPlanBrief= _trainPlanBrief;
                        jo.trainPlanDetails= _trainPlanDetails;
                        jo.willProvideAccomadation = _willProvideAccomadation;
                        jo.notProvideButOffer= _notProvideButOffer;
                        jo.provideRent= _provideRent;
                        jo.provideUnit= _provideUnit;
                        jo.accommodationDescription = _accommodationDescription;
                        jo.accomadationNotApplicalbe = _accomadationNotApplicalbe;
                        jo.whoIsFillingBrief= _whoIsFillingBrief;
                        jo.whoIsFillingDetail= _whoIsFillingDetail;
                        jo.howDidYouFindBrief= _howDidYouFindBrief;
                        jo.howDidYouFindDetail= _howDidYouFindDetail;
                        jo.howDidYouDetermineBrief= _howDidYouDetermineBrief;
                        jo.howDidYouDetermineDetail= _howDidYouDetermineDetail;
                        jo.howAndWhenOfferBrief= _howAndWhenOfferBrief;
                        jo.howAndWhenOfferDetail= _howAndWhenOfferDetail;
                        try
                        {
                            cdc.SubmitChanges();
                            MessageBox.Show("Data has been saved.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        catch(Exception exc)
                        {

                            MessageBox.Show(exc.Message);;
                        }
                    }
                    else MessageBox.Show("There is no job offer record to delete.");

                }
            }
            else MessageBox.Show("There is no active application");
            lf.textChanged = false;

        }
        public static void buildupDict5602(ref Dictionary<string, string> dict) {

            dict.Add("EMP5602_E[0].Page3[0].txtF_Number_of_foreign_workers[0]", _numOfTFWs.ToString());
            dict.Add("EMP5602_E[0].Page3[0].txtF_Date_E[0]",String.Format("{0:yyyy-MM-dd}",_startDate.ToString()));
            dict.Add("EMP5602_E[0].Page3[0].txtF_Employment_Rational[0]",_durationRationale);
            switch(_durationUnit) {
                case 0:
                    dict.Add("EMP5602_E[0].Page3[0].txtF_Days[0]", _duration.ToString());
                    break;
                case 1:
                    dict.Add("EMP5602_E[0].Page3[0].txtF_Weeks[0]",_duration.ToString());
                    break;
                case 2:
                    dict.Add("EMP5602_E[0].Page3[0].txtF_Months[0]",_duration.ToString());
                    break;
                case 3:
                    dict.Add("EMP5602_E[0].Page3[0].txtF_Years[0]",_duration.ToString());
                    break;
            }
            dict.Add("EMP5602_E[0].Page3[0].chkB_NoLanguage[0]", _languageRequired == true ? "0" : "1");
            dict.Add("EMP5602_E[0].Page3[0].chkB_OrallyIn[0]", _speakingEnglishFrenchRequied == true ? "1" : "0");
            dict.Add("EMP5602_E[0].Page3[0].chkB_English1[0]", _speakingEnglishRequired == true ? "1" : "0");
            dict.Add("EMP5602_E[0].Page3[0].chkB_French1[0]", _speakingFrenchRequired == true ? "1" : "0");
            dict.Add("EMP5602_E[0].Page3[0].chkB_EnglishOrFrench1[0]", _speakingEnglishOrFrenchRequired == true ? "1" : "0");
            dict.Add("EMP5602_E[0].Page3[0].chkB_EnglishAndFrench1[0]", _speakingEnglishAndFrenchRequired == true ? "1" : "0");
            dict.Add("EMP5602_E[0].Page3[0].chkB_TheOffer[0]", _writingEnglishFrenchRequired == true ? "1" : "0");
            dict.Add("EMP5602_E[0].Page3[0].chkB_English2[0]", _writingEnglishRequired == true ? "1" : "0");
            dict.Add("EMP5602_E[0].Page3[0].chkB_French2[0]", _writingFrenchRequired == true ? "1" : "0");
            dict.Add("EMP5602_E[0].Page3[0].chkB_EnglishOrFrench2[0]", _writingEnglishOrFrenchRequired == true ? "1" : "0");
            dict.Add("EMP5602_E[0].Page3[0].chkB_EnglishAndFrench2[0]", _writingEnglishAndFrenchRequired == true ? "1" : "0");
            //P4 Q16
            dict.Add("EMP5602_E[0].Page4[0].txtF_Days[0]",_vacationDays.ToString());
            dict.Add("EMP5602_E[0].Page4[0].txtF_Remuneration[0]",_remuneration.ToString());
            //P4 Q20
            dict.Add("EMP5602_E[0].Page4[0].txtF_OtherBenefits[0]",_otherBenefit==string.Empty?"N/A":_otherBenefit);
            //P4 Q24 Provide Details
            dict.Add("EMP5602_E[0].Page5[0].txtF_ProvideDetails[0]", _briefBenefit);
            //P4 Q25
            dict.Add("EMP5602_E[0].Page5[0].txtF_ProvideARationale[0]", _briefRationaleOfferingJob);
            //P5 Q26
            dict.Add("EMP5602_E[0].Page5[0].No_E[0]", _trainCanadian==false?"1":"0");
            dict.Add("EMP5602_E[0].Page5[0].Yes_E[0]", _trainCanadian==true?"1":"0");
            dict.Add("EMP5602_E[0].Page5[0].txtF_IfNo19[0]",_noTrainReason);
            dict.Add("EMP5602_E[0].Page5[0].txtF_IfYes19[0]",_trainPlanBrief);
            //P5 Q27
            //dict.Add("",);
            //dict.Add("",);
            dict.Add("EMP5602_E[0].Page5[0].txtF_no[0]", _notProvideButOffer);
            dict.Add("EMP5602_E[0].Page5[0].txtF_yes[0]", _provideRent.ToString());
            dict.Add("EMP5602_E[0].Page5[0].CheckBox1[0]", _provideUnit=="Weeks"?"1":"0");
            dict.Add("EMP5602_E[0].Page5[0].CheckBox1[1]", _provideUnit == "Months" ? "1" : "0");
            dict.Add("EMP5602_E[0].Page5[0].txtF_accomodation[0]",_accommodationDescription);



        }
    }
}
