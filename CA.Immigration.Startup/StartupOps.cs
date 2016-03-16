using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CA.Immigration.Data;
using System.Windows.Forms;
using System.Drawing;
using CA.Immigration.Utility;

namespace CA.Immigration.Startup
{
    public class StartupOps
    {
        public int CurrentPersonId { get; set; }
        public int CurrentEmployerId { get; set; }

        public static void startupInitialize(StartupForm sf)
        {
            // turn label things invisible
            sf.lblSelectedPersonId.Visible = false;
            sf.lblSelectedPersonId.Visible = false;
            sf.lblSelectedEmployer.Visible = false;
            sf.lblSelectedEmployerId.Visible = false;

            using (CommonDataContext cdc = new CommonDataContext())
            {
                sf.cmbCategory.DataSource = cdc.tblCategories.Select(x => new { x.Name, x.Id });
                sf.cmbCategory.DisplayMember = "Name";
                sf.cmbCategory.ValueMember = "Id";
                sf.cmbProgram.DataSource = cdc.tblPrograms.Select(x => new { x.Name, x.Id });
                sf.cmbProgram.DisplayMember = "Name";
                sf.cmbProgram.ValueMember = "Id";
                sf.cmbPBIMS.DataSource = cdc.tblMarriageStatusTypes.Select(x => new { x.MarriageStatusType, x.TypeCode });
                sf.cmbPBIMS.DisplayMember = "MarriageStatusType";
                sf.cmbPBIMS.ValueMember = "TypeCode";
                sf.cmbPBIGender.DataSource = cdc.tblGenders.Select(x => new { x.Gender, x.GenderCode });
                sf.cmbPBIGender.DisplayMember = "Gender";
                sf.cmbPBIGender.ValueMember = "GenderCode";
            }
            sf.dtpPBIDOB.Format = DateTimePickerFormat.Custom;
            sf.dtpPBIDOB.CustomFormat = "yyyy-MM-dd";
            getAllApplications(sf);
        }
        private static void getAllApplications(StartupForm sf)
        {
            // if no person or/and employer selected, display all applications
            // Get LMIA application 
            using (CommonDataContext cdc = new CommonDataContext())
            {
                if (GlobalData.CurrentPersonId != null)
                {
                    sf.dgvLMIAApplication.DataSource = cdc.tblLMIAApplications.Select(x => new { ID = x.Id, Employer = ((int)x.EmployerId).getEmployerFromId(), Employee = ((int)x.EmployeeId).getEmployeeFromId(), CreateDate = x.CreatedDate });
                }
                else sf.dgvLMIAApplication.DataSource = cdc.tblLMIAApplications.Select(x => new { ID = x.Id, Employer = ((int)x.EmployerId).getEmployerFromId(), CreateDate = x.CreatedDate });

            }

            // Get ... application





        }
        public static void RefreshMainForm(StartupForm sf)
        {
            if (GlobalData.CurrentPersonId != null)
            {
                sf.lblSelectedPersonId.Text = GlobalData.CurrentPersonId.ToString();
                using (CommonDataContext cdc = new CommonDataContext())
                {
                    tblPerson p = cdc.tblPersons.Where(x => x.Id == GlobalData.CurrentPersonId).Select(x => x).FirstOrDefault();
                    sf.lblSelectPerson.Text = p.FirstName + " " + p.LastName;

                }
                sf.lblSelectedPersonId.Visible = true;
                sf.lblSelectPerson.Visible = true;
                sf.lblSelectedPersonId.ForeColor = Color.FromArgb(50, 70, 190);
                sf.lblSelectPerson.ForeColor = Color.FromArgb(50, 70, 190);
                getPersonInfo((int)GlobalData.CurrentPersonId,sf);
            }
            else {
                cleanPBI(sf);
                cleanSelector(sf);
                cleanPassport(sf);

            }

            if (GlobalData.CurrentEmployerId != null)
            {
                sf.lblSelectedEmployerId.Text = GlobalData.CurrentEmployerId.ToString();
                using (CommonDataContext cdc = new CommonDataContext())
                {
                    tblEmployer e = cdc.tblEmployers.Where(x => x.Id == GlobalData.CurrentEmployerId).Select(x => x).FirstOrDefault();
                    sf.lblSelectedEmployer.Text = e.LegalName;
                }
                sf.lblSelectedEmployer.Visible = true;
                sf.lblSelectedEmployerId.Visible = true;
                sf.lblSelectedEmployer.ForeColor = Color.FromArgb(50, 70, 190);
                sf.lblSelectedEmployerId.ForeColor = Color.FromArgb(50, 70, 190);
            }



        }
        public  static void getPersonInfo(int personId,StartupForm sf)
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                tblPerson p = cdc.tblPersons.Where(x => x.Id == personId).Select(x => x).Single();

                sf.txtPBIfn.Text = p.FirstName;
                sf.txtPBIln.Text = p.LastName;
                sf.txtPBImn.Text = p.MiddleName;
                sf.dtpPBIDOB.Text = p.DOB != null ? p.DOB.ToString() : null;
                sf.cmbPBIGender.SelectedIndex = p.Gender != null ? p.Gender.Value - 1 : -1;  // here is some problem. Id actually is assume as 1 male 2 female 3 unknown. if Id changed, problem comes.
                sf.cbxAlias.Checked = p.IsAliasName == true ? true : false;
                sf.txtPBIAFN.Text = p.AliasFirstName;
                sf.txtPBIALN.Text = p.AliasLastName;
                sf.txtPBIUCI.Text = p.UCI;
                sf.cmbPBIMS.SelectedIndex = (p.MarriageStatusId != null) ? (cdc.tblMarriageStatusTypes.Where(x => x.TypeCode == p.MarriageStatusId).Select(x => x.Id).Single() - 1) : -1;
                sf.txtPBIPhone.Text = p.Phone;
                sf.txtPBIEmail.Text = p.Email;
                if (p.Photo != null && !p.Photo.Equals(DBNull.Value) && p.Photo.Length > 0)
                {
                    sf.pcbPhoto.Image = ImageWork.ByteArrayToImage(p.Photo.ToArray());
                    sf.pcbPhoto.SizeMode = PictureBoxSizeMode.Zoom;

                }
                else sf.pcbPhoto.Image = null;
                if (p.theSignature != null && !p.theSignature.Equals(DBNull.Value) && p.theSignature.Length > 0)
                {
                    sf.pcbSignature.Image = ImageWork.ByteArrayToImage(p.theSignature.ToArray());
                    sf.pcbSignature.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else sf.pcbSignature.Image = null;
                sf.btnPBIInsert.Visible = false; // disable insert 
            }

        }
        public static void cleanSelector(StartupForm sf)
        {
            sf.lblSelectPerson.Text = null;
            sf.lblSelectedPersonId.Text = null;

        }

        public static void cleanPassport(StartupForm sf)
        {
            sf.lblPDIPPPersonId.Text = null;
            sf.lblPDIPPPeronName.Text = null;
        }
        public static void cleanPBI(StartupForm sf)
        {
            sf.txtPBIfn.Text = null;
            sf.txtPBIln.Text = null;
            sf.txtPBImn.Text = null;
            sf.dtpPBIDOB.Text = null;
            sf.cmbPBIGender.SelectedIndex = 0;  // here is some problem. Id actually is assume as 1 male 2 female 3 unknown. if Id changed, problem comes.
            sf.cbxAlias.Checked = false;
            sf.txtPBIAFN.Text = null;
            sf.txtPBIALN.Text = null;
            sf.txtPBIUCI.Text = null;
            sf.cmbPBIMS.SelectedIndex = 0;
            sf.txtPBIPhone.Text = null;
            sf.txtPBIEmail.Text = null;
            sf.pcbPhoto.Image = null;
            sf.pcbSignature = null;
        }
    }
}
