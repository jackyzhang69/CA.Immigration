using CA.Immigration.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using CA.Immigration.Utility;
using System.Windows.Forms;
using System.Data;

namespace CA.Immigration.Startup
{
    public static class Person
    {
        private static string _FirstName;
        private static string _MiddleName;
        private static string _LastName;
        private static DateTime? _DOB;
        private static int? _Gender;
        private static bool? _IsAliasName;
        private static string _AliasLastName;
        private static string _AliasFirstName;
        private static string _UCI;
        private static string _MarriageStatusId;
        private static string _Phone;
        private static string _Email;
        private static Image _Photo;
        private static Image _theSignature;

        public static void loadFromDB()
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                tblPerson ps = cdc.tblPersons.Where(x => x.Id == GlobalData.CurrentPersonId).Select(x => x).FirstOrDefault();
                if (ps != null)
                {
                    _FirstName = ps.FirstName;
                    _MiddleName = ps.MiddleName;
                    _LastName = ps.LastName;
                    _DOB = ps.DOB != null ? ps.DOB : null;
                    _Gender = ps.Gender != null ? ps.Gender : null;
                    _IsAliasName = ps.IsAliasName == null ? null : ps.IsAliasName;
                    _AliasLastName = ps.AliasLastName;
                    _AliasFirstName = ps.AliasFirstName;
                    _UCI = ps.UCI;
                    _MarriageStatusId = ps.MarriageStatusId;
                    _Phone = ps.Phone;
                    _Email = ps.Email;
                    _Photo = ps.Photo != null ? ImageWork.ByteArrayToImage(ps.Photo.ToArray()) : null;
                    _theSignature = ps.theSignature != null ? ImageWork.ByteArrayToImage(ps.theSignature.ToArray()) : null;
                }

            }

        }
        public static void getInput(StartupForm sf)
        {
            _FirstName = sf.txtPBIfn.Text;
            _MiddleName = sf.txtPBImn.Text;
            _LastName = sf.txtPBIln.Text;
            _DOB = sf.dtpPBIDOB.Value;
            _Gender = (int)sf.cmbPBIGender.SelectedValue;
            _IsAliasName = sf.cbxAlias.Checked ? true : false;
            _AliasLastName = sf.txtPBIAFN.Text;
            _AliasFirstName = sf.txtPBIALN.Text;
            _UCI = sf.txtPBIUCI.Text;
            _MarriageStatusId = (string)sf.cmbPBIMS.SelectedValue;
            _Phone = sf.txtPBIPhone.Text;
            _Email = sf.txtPBIEmail.Text;
            _Photo = sf.pcbPhoto.Image == null ? null : sf.pcbPhoto.Image; 
            _theSignature = sf.pcbSignature.Image == null ? null : sf.pcbSignature.Image;


        }
        public static void personInsert(StartupForm sf)
        {
            getInput(sf);
            using (CommonDataContext cdc=new CommonDataContext())
            {
                tblPerson ps = new tblPerson
                {
                    FirstName = _FirstName,
                    MiddleName = _MiddleName,
                    LastName = _LastName,
                    DOB = _DOB == null ? null : _DOB,
                    Gender = _Gender == null ? null : _Gender,
                    IsAliasName = _IsAliasName == null ? null : _IsAliasName,
                    AliasLastName = _AliasLastName,
                    AliasFirstName = _AliasFirstName,
                    UCI = _UCI,
                    MarriageStatusId = _MarriageStatusId,
                    Phone = _Phone,
                    Email = _Email,
                    Photo = _Photo == null ? null : ImageWork.ImageToByteArray(_Photo),
                    theSignature = _theSignature == null ? null : ImageWork.ImageToByteArray(_theSignature)
                };
                try
                {
                    cdc.tblPersons.InsertOnSubmit(ps);
                    cdc.SubmitChanges();
                    GlobalData.CurrentPersonId = ps.Id;
                    sf.lblPDIPPPersonId.Text = GlobalData.CurrentPersonId.ToString();
                    sf.lblPDIPPPeronName.Text = cdc.tblPersons.Where(x => x.Id == GlobalData.CurrentPersonId).Select(x => (x.FirstName + " " + x.LastName)).FirstOrDefault();
                    sf.btnInsertPassport.Visible = true;
                    MessageBox.Show(_FirstName+" "+_LastName+" has been inserted into database","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
        }
        }
        public static void personDelete(StartupForm sf)
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {

                tblPerson p = cdc.tblPersons.Where(x => x.Id == GlobalData.CurrentPersonId).Select(x => x).FirstOrDefault();

                if (MessageBox.Show("Do you really want to delete the record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        cdc.tblPersons.DeleteOnSubmit(p);
                        cdc.SubmitChanges();
                        MessageBox.Show("The record has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GlobalData.CurrentPersonId = null;
                        Person.clearForm(sf);
                        StartupOps.clearSelectedPerson(sf);
                    }
                    catch (Exception exc)
                    {

                        MessageBox.Show(exc.Message);
                    }

                }

            }
        }
        public static void fillForm(StartupForm sf)
        {
            sf.txtPBIfn.Text= _FirstName;
            sf.txtPBImn.Text= _MiddleName;
            sf.txtPBIln.Text=_LastName;
            sf.dtpPBIDOB.Value=_DOB==null?DateTime.Today:(DateTime)_DOB;
            sf.cmbPBIGender.SelectedValue= _Gender;
            sf.cbxAlias.Checked= _IsAliasName==true? true :false;
            sf.txtPBIAFN.Text = _AliasLastName;
            sf.txtPBIALN.Text= _AliasFirstName;
            sf.txtPBIUCI.Text= _UCI;
            sf.cmbPBIMS.SelectedValue= _MarriageStatusId==null?"":_MarriageStatusId;
            sf.txtPBIPhone.Text= _Phone;
            sf.txtPBIEmail.Text= _Email;
            sf.pcbPhoto.Image = _Photo;
            sf.pcbSignature.Image= _theSignature;
        }
        public static void clearForm(StartupForm sf)
        {
            _FirstName = null;
            _MiddleName = null;
            _LastName = null;
            _DOB = null;
            _Gender = 1;  //default is male
            _IsAliasName = false;
            _AliasLastName = null;
            _AliasFirstName = null;
            _UCI = null;
            _MarriageStatusId = null;
            _Phone = null;
            _Email = null;
            _Photo = null;
            _theSignature = null;
            fillForm(sf);
        }
        public static void personUpdate(StartupForm sf)
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                if (GlobalData.CurrentPersonId != null)
                {
                    getInput(sf); // get data from input 
                    tblPerson p = cdc.tblPersons.Where(x => x.Id == GlobalData.CurrentPersonId).Select(x => x).Single();
                    p.FirstName = _FirstName;
                    p.MiddleName = _MiddleName;
                    p.LastName = _LastName;
                    p.DOB = _DOB;
                    p.Gender = _Gender;
                    p.IsAliasName = _IsAliasName;
                    p.AliasLastName = _AliasLastName;
                    p.AliasFirstName = _AliasFirstName;
                    p.UCI = _UCI;
                    p.MarriageStatusId = _MarriageStatusId;
                    p.Phone = _Phone;
                    p.Email = _Email;
                    p.Photo = _Photo == null ? null : ImageWork.ImageToByteArray(_Photo);
                    p.theSignature = _theSignature == null ? null : ImageWork.ImageToByteArray(_theSignature);

                    try
                    {
                        cdc.SubmitChanges();
                        MessageBox.Show(_FirstName + " " + _LastName + "'s basic information\n has been updated to database");
                    }
                    catch (Exception exc)
                    {

                        MessageBox.Show(exc.Message);
                    } 
                }
                
                else MessageBox.Show("There is no record to be updated");
            }
        }
        public static void passportInsert(StartupForm sf)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("PassportNumber"));
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("GenderId"));
            dt.Columns.Add(new DataColumn("BirthCountryId"));
            dt.Columns.Add(new DataColumn("NationalityId"));
            dt.Columns.Add(new DataColumn("DOB"));
            dt.Columns.Add(new DataColumn("BrithPlace"));
            dt.Columns.Add(new DataColumn("IssueDate"));
            dt.Columns.Add(new DataColumn("IssuePlace"));
            dt.Columns.Add(new DataColumn("ExpiryDate"));
            dt.Columns.Add(new DataColumn("IssueCountryId"));
            dt.Columns.Add(new DataColumn("IsValid"));
            sf.dgvPassport.DataSource = dt;
        }

        //Build up emp5575 dictionary
        public static void buildupDict5575(ref Dictionary<string, string> dict)
        {
            loadFromDB();
            dict.Add("EMP5575_E[0].Page3[0].txtF_foreign_worker[0]", GlobalData.CurrentPersonId != null ?_FirstName + " " + _LastName : "");  // Foreign worker
        }
    }
}

