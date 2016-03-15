using System;
using System.Windows.Forms;
using CA.Immigration.LMIA;
using CA.Immigration.SP;
using CA.Immigration.PDF;
using CA.Immigration.Utility;
using System.Linq;
using CA.Immigration.Data;
using System.Data;
using System.Drawing;
using CA.Immigration.App;
using System.Drawing.Imaging;
using System.Collections.Generic;


namespace CA.Immigration.Startup
{
    public partial class StartupForm : Form
    {
        public int CurrentPersonId { get; set; }
        public int CurrentEmployerId { get; set; }

        public StartupForm()
        {
            InitializeComponent();
            dtpPBIDOB.Format = DateTimePickerFormat.Custom;
            dtpPBIDOB.CustomFormat = "yyyy-MM-dd";
            dtpBusinessStartDate.Format = DateTimePickerFormat.Custom;
            dtpBusinessStartDate.CustomFormat = "yyyy-MM-dd";


        }

        private void lMIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //LMIAForm lmiaForm=new LMIAForm(1,2,3);
            //lmiaForm.Show();
        }

        private void qIIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationId = 1;
            FormOPs.fillForm(@"c:\vba\EMP5593.pdf", LMIADict.EMP5593(ApplicationId));
        }

        private void getValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDFTools.getXFAValue(LMIADict.EMP5593(1));

            // to get value from pdf

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int[] ids = new int[] { 4, 17 };
            FormOPs.IMM5476Sign i5476 = new FormOPs.IMM5476Sign(ids);
            FormOPs.fillForm(@"c:\vba\imm5476.pdf", RepDict.IMM5476(3, 4));
            FormOPs.signForm(@"c:\vba\imm5476.pdf", i5476.getFormData());
        }



        private void Startup_Load(object sender, EventArgs e)
        {



            // turn label things invisible
            lblSelectPerson.Visible = false;
            lblSelectedPersonId.Visible = false;
            lblSelectedEmployer.Visible = false;
            lblSelectedEmployerId.Visible = false;

            using (CommonDataContext cdc = new CommonDataContext())
            {
                cmbCategory.DataSource = cdc.tblCategories.Select(x => new { x.Name, x.Id });
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";
                cmbProgram.DataSource = cdc.tblPrograms.Select(x => new { x.Name, x.Id });
                cmbProgram.DisplayMember = "Name";
                cmbProgram.ValueMember = "Id";
                cmbPBIMS.DataSource = cdc.tblMarriageStatusTypes.Select(x => new { x.MarriageStatusType, x.TypeCode });
                cmbPBIMS.DisplayMember = "MarriageStatusType";
                cmbPBIMS.ValueMember = "TypeCode";
                cmbPBIGender.DataSource = cdc.tblGenders.Select(x => new { x.Gender, x.GenderCode });
                cmbPBIGender.DisplayMember = "Gender";
                cmbPBIGender.ValueMember = "GenderCode";
            }
            dtpPBIDOB.Format = DateTimePickerFormat.Custom;
            dtpPBIDOB.CustomFormat = "yyyy-MM-dd";
            getAllApplications();
        }

        private void getAllApplications()
        {
            // if no person or/and employer selected, display all applications
            // Get LMIA application 
            using (CommonDataContext cdc=new CommonDataContext())
            {
                if (GlobalData.CurrentPersonId!=null)
                {
                    dgvLMIAApplication.DataSource = cdc.tblLMIAApplications.Select(x => new { ID = x.Id, Employer = ((int)x.EmployerId).getEmployerFromId(), Employee = ((int)x.EmployeeId).getEmployeeFromId(), CreateDate = x.CreatedDate }); 
                }
                else dgvLMIAApplication.DataSource = cdc.tblLMIAApplications.Select(x => new { ID = x.Id, Employer = ((int)x.EmployerId).getEmployerFromId(), CreateDate = x.CreatedDate });

            }

            // Get ... application
            




        }




        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            Form ps = new PersonSelector(this);
            ps.Show();
        }

        private void btnPBIInsert_Click(object sender, EventArgs e)
        {

            using (CommonDataContext cdc = new CommonDataContext())
            {
                tblPerson p = new tblPerson
                {
                    FirstName = txtPBIfn.Text,
                    MiddleName = txtPBImn.Text,
                    LastName = txtPBIln.Text,
                    DOB = dtpPBIDOB.Value,
                    Gender = (int)cmbPBIGender.SelectedValue,
                    IsAliasName = cbxAlias.Checked ? true : false,
                    AliasLastName = txtPBIAFN.Text,
                    AliasFirstName = txtPBIALN.Text,
                    UCI = txtPBIUCI.Text,
                    MarriageStatusId = cmbPBIMS.SelectedValue.ToString(),
                    Phone = txtPBIPhone.Text,
                    Email = txtPBIEmail.Text,
                    Photo = pcbPhoto.Image == null ? null : ImageWork.ImageToByteArray(pcbPhoto.Image),
                    theSignature = pcbSignature.Image == null ? null : ImageWork.ImageToByteArray(pcbSignature.Image)

                };
                try
                {
                    cdc.tblPersons.InsertOnSubmit(p);
                    cdc.SubmitChanges();
                    int Id = p.Id; // get new Id of inserted person
                    GlobalData.CurrentPersonId = Id;
                    lblPDIPPPersonId.Text = GlobalData.CurrentPersonId.ToString();
                    lblPDIPPPeronName.Text = cdc.tblPersons.Where(x => x.Id == Id).Select(x => (x.FirstName + " " + x.LastName)).FirstOrDefault();
                    btnInsertPassport.Visible = true;
                }
                catch (Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void btnInsertPassport_Click(object sender, EventArgs e)
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
            dgvPassport.DataSource = dt;



        }

        private void getPersonInfo(int personId)
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                tblPerson p = cdc.tblPersons.Where(x => x.Id == personId).Select(x => x).Single();

                txtPBIfn.Text = p.FirstName;
                txtPBIln.Text = p.LastName;
                txtPBImn.Text = p.MiddleName;
                dtpPBIDOB.Text = p.DOB != null ? p.DOB.ToString() : null;
                cmbPBIGender.SelectedIndex = p.Gender != null ? p.Gender.Value - 1 : -1;  // here is some problem. Id actually is assume as 1 male 2 female 3 unknown. if Id changed, problem comes.
                cbxAlias.Checked = p.IsAliasName == true ? true : false;
                txtPBIAFN.Text = p.AliasFirstName;
                txtPBIALN.Text = p.AliasLastName;
                txtPBIUCI.Text = p.UCI;
                cmbPBIMS.SelectedIndex = (p.MarriageStatusId != null) ? (cdc.tblMarriageStatusTypes.Where(x => x.TypeCode == p.MarriageStatusId).Select(x => x.Id).Single() - 1) : -1;
                txtPBIPhone.Text = p.Phone;
                txtPBIEmail.Text = p.Email;
                if (p.Photo != null && !p.Photo.Equals(DBNull.Value) && p.Photo.Length > 0)
                {
                    pcbPhoto.Image = ImageWork.ByteArrayToImage(p.Photo.ToArray());
                    pcbPhoto.SizeMode = PictureBoxSizeMode.Zoom;

                }
                else pcbPhoto.Image = null;
                if (p.theSignature != null && !p.theSignature.Equals(DBNull.Value) && p.theSignature.Length > 0)
                {
                    pcbSignature.Image = ImageWork.ByteArrayToImage(p.theSignature.ToArray());
                    pcbSignature.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else pcbSignature.Image = null;
                btnPBIInsert.Visible = false; // disable insert 
            }

        }

        public void RefreshMainForm()
        {
            if (GlobalData.CurrentPersonId != null)
            {
                lblSelectedPersonId.Text = GlobalData.CurrentPersonId.ToString();
                using (CommonDataContext cdc = new CommonDataContext())
                {
                    tblPerson p = cdc.tblPersons.Where(x => x.Id == GlobalData.CurrentPersonId).Select(x => x).FirstOrDefault();
                    lblSelectPerson.Text = p.FirstName + " " + p.LastName;

                }
                lblSelectedPersonId.Visible = true;
                lblSelectPerson.Visible = true;
                lblSelectedPersonId.ForeColor = Color.FromArgb(50, 70, 190);
                lblSelectPerson.ForeColor = Color.FromArgb(50, 70, 190);
                getPersonInfo((int)GlobalData.CurrentPersonId);
            }
            else {
                cleanPBI();
                cleanSelector();
                cleanPassport();

            }

            if (GlobalData.CurrentEmployerId != null)
            {
                lblSelectedEmployerId.Text = GlobalData.CurrentEmployerId.ToString();
                using (CommonDataContext cdc = new CommonDataContext())
                {
                    tblEmployer e = cdc.tblEmployers.Where(x => x.Id == GlobalData.CurrentEmployerId).Select(x => x).FirstOrDefault();
                    lblSelectedEmployer.Text = e.LegalName;
                }
                lblSelectedEmployer.Visible = true;
                lblSelectedEmployerId.Visible = true;
                lblSelectedEmployer.ForeColor = Color.FromArgb(50, 70, 190);
                lblSelectedEmployerId.ForeColor = Color.FromArgb(50, 70, 190);
            }



        }

        private void btnSelectEmployer_Click(object sender, EventArgs e)
        {
            EmployerSelector es = new EmployerSelector(this);
            es.Show();
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GlobalData.CurrentCategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            using (CommonDataContext cdc = new CommonDataContext())
            {
                int id = int.Parse(cmbCategory.SelectedValue.ToString());
                if (cdc.tblPrograms.Where(x => x.CategoryId == id).Select(x => x.Name) != null)
                    cmbProgram.DataSource = cdc.tblPrograms.Where(x => x.CategoryId == id).Select(x => x.Name);
                else
                {
                    cmbProgram.SelectedIndex = -1;
                    cmbProgram.Text = "";
                }

            }
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            // call functions based on program selected 
            GlobalData.CurrentProgramIdReadOnly = true;  // disable changing application id
            switch (GlobalData.CurrentProgramId)
            {
                case (int)GlobalData.AppStream.LMIAPRandWP:
                   
                    break;
                case (int)GlobalData.AppStream.LMIAWPOnly:
                    if (GlobalData.CurrentEmployerId != null)
                    {
                        LMIAForm lf = new LMIAForm();
                        lf.Show();
                    }

                    else MessageBox.Show("You have to select an employer first");
                    break;
                default:
                    break;
            }

        }

        private void cmbProgram_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GlobalData.CurrentProgramId = (int)cmbProgram.SelectedIndex;
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcbPhoto.Image = Image.FromFile(ofd.FileName);
                pcbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnSignature_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcbSignature.Image = Image.FromFile(ofd.FileName);
                pcbSignature.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }


        private void btnFindaPerson_Click(object sender, EventArgs e)
        {
            PersonSelector ps = new PersonSelector(this);
            ps.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                tblPerson p = cdc.tblPersons.Where(x => x.Id == GlobalData.CurrentPersonId).Select(x => x).Single();
                p.FirstName = txtPBIfn.Text;
                p.MiddleName = txtPBImn.Text;
                p.LastName = txtPBIln.Text;
                p.DOB = dtpPBIDOB.Value;
                p.Gender = (int)cmbPBIGender.SelectedValue;
                p.IsAliasName = cbxAlias.Checked ? true : false;
                p.AliasLastName = txtPBIAFN.Text;
                p.AliasFirstName = txtPBIALN.Text;
                p.UCI = txtPBIUCI.Text;
                p.MarriageStatusId = (string)cmbPBIMS.SelectedValue;
                p.Phone = txtPBIPhone.Text;
                p.Email = txtPBIEmail.Text;
                p.Photo = pcbPhoto.Image == null ? null : ImageWork.ImageToByteArray(pcbPhoto.Image); //ImageFormat contentType = ImageHelper.GetContentType(this.imageBytes);
                p.theSignature = pcbSignature.Image == null ? null : ImageWork.ImageToByteArray(pcbSignature.Image);

                try
                {
                    cdc.SubmitChanges();
                    MessageBox.Show(p.FirstName + " " + p.LastName + "'s basic information has been updated to database");
                }
                catch (Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void btnMakeImm5476_Click(object sender, EventArgs e)
        {
            int[] ids = new int[] { 4, (int)GlobalData.CurrentPersonId };
            FormOPs.IMM5476Sign i5476 = new FormOPs.IMM5476Sign(ids);
            FormOPs.fillForm(@"c:\vba\imm5476.pdf", RepDict.IMM5476((int)GlobalData.CurrentPersonId, 1));
            FormOPs.signForm(@"c:\vba\imm5476.pdf", i5476.getFormData());
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {

                tblPerson p = cdc.tblPersons.Where(x => x.Id == GlobalData.CurrentPersonId).Select(x => x).FirstOrDefault();

                if (MessageBox.Show("Do you really want to delete the record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cdc.tblPersons.DeleteOnSubmit(p);
                    cdc.SubmitChanges();
                    GlobalData.CurrentPersonId = null;
                    cleanPBI();
                    cleanSelector();
                    cleanPassport();

                }

            }

        }

        private void cleanSelector()
        {
            lblSelectPerson.Text = null;
            lblSelectedPersonId.Text = null;

        }

        private void cleanPassport()
        {
            lblPDIPPPersonId.Text = null;
            lblPDIPPPeronName.Text = null;
        }
        private void cleanPBI()
        {
            txtPBIfn.Text = null;
            txtPBIln.Text = null;
            txtPBImn.Text = null;
            dtpPBIDOB.Text = null;
            cmbPBIGender.SelectedIndex = 0;  // here is some problem. Id actually is assume as 1 male 2 female 3 unknown. if Id changed, problem comes.
            cbxAlias.Checked = false;
            txtPBIAFN.Text = null;
            txtPBIALN.Text = null;
            txtPBIUCI.Text = null;
            cmbPBIMS.SelectedIndex = 0;
            txtPBIPhone.Text = null;
            txtPBIEmail.Text = null;
            pcbPhoto.Image = null;
            pcbSignature = null;
        }

        private void btnAnalysisInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnEBIInsert_Click(object sender, EventArgs e)
        {

            // check validation

            // insert a row
            using (CommonDataContext cdc = new CommonDataContext())
            {

                tblEmployer emp = new tblEmployer
                {
                    ESDCId = txtESDCId.Text,
                    CRA_BN = txtCRABN.Text,
                    LegalName = txtLegalName.Text,
                    OperatingName = txtOperatingName.Text,
                    FranchiseName = txtFranchise.Text,
                    CompanyType = BEIcompanyType.cmbCompanyType.SelectedIndex != -1 ? BEIcompanyType.cmbCompanyType.SelectedIndex + 1 : -1, //index 0 is corporate
                    MailingAddress = txtMailAddress.Text,
                    MailingCity = txtMailCity.Text,
                    MailingProvince = canadaProvincesMail.cmbProvince.SelectedIndex != -1 ? canadaProvincesMail.cmbProvince.SelectedIndex : -1,
                    MailingCountry = txtCountryMail.Text,
                    MailingPostalCode = txtPostalMail.Text,
                    BizAddress = txtBusinessAddress.Text,
                    BizProvince = canadaProvincesBusiness.cmbProvince.SelectedIndex != -1 ? canadaProvincesBusiness.cmbProvince.SelectedIndex : -1,
                    BizCountry = txtBusinessCountry.Text,
                    BizPostalCode = txtPostalBusiness.Text,
                    BizTelephone = txtEBIPhone.Text,
                    Website = txtEBIWebsite.Text,
                    BizStartDate= dtpBusinessStartDate.Value,
                    BizActivity = txtEBIBusinessActivities.Text,
                    ContactFirstName = txtEBIFirstName.Text,
                    ContactMiddleName = txtEBIMiddleName.Text,
                    ContactLastName = txtEBILastName.Text,
                    ContactJobTitle = txtEBIJobTitle.Text,
                    ContactPhone = txtEBIPrimaryContactPhone.Text,
                    ContactEmail = txtEBIPrimaryContactEmail.Text,
                    ContactFax = txteBIPrimaryContactFax.Text
                };
                try
                {
                    cdc.tblEmployers.InsertOnSubmit(emp);
                    cdc.SubmitChanges();
                    MessageBox.Show("Record has been saved into Database!");
                    btnEBIInsert.Visible = false;

                }
                catch (Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }

                // set up global data
                GlobalData.CurrentEmployerId = emp.Id;
            }
        }

        private void tabEmployer_Paint(object sender, PaintEventArgs e)
        {
            if(GlobalData.CurrentEmployerId!=null)
            {
                btnEBIInsert.Visible = false;  // disable insert 
                using(CommonDataContext cdc=new CommonDataContext())
                {

                    tblEmployer emp = cdc.tblEmployers.Where(x => x.Id == GlobalData.CurrentEmployerId).Select(x => x).Single();
                    txtESDCId.Text = emp.ESDCId.ToString();
                    txtCRABN.Text = emp.CRA_BN.ToString();
                    txtLegalName.Text = emp.LegalName;
                    txtOperatingName.Text = emp.OperatingName;
                    txtFranchise.Text = emp.FranchiseName;
                    BEIcompanyType.cmbCompanyType.SelectedIndex = (int)emp.CompanyType; //
                    txtMailAddress.Text = emp.MailingAddress;
                    txtMailCity.Text = emp.MailingCity;
                    canadaProvincesMail.cmbProvince.SelectedIndex =(int)emp.MailingProvince;
                    txtCountryMail.Text = emp.MailingCountry;
                    txtPostalMail.Text = emp.MailingPostalCode;
                    txtBusinessAddress.Text = emp.BizAddress;
                    canadaProvincesBusiness.cmbProvince.SelectedIndex = (int)emp.BizProvince;
                    txtBusinessCountry.Text = emp.BizCountry;
                    txtPostalBusiness.Text = emp.BizPostalCode;
                    txtEBIPhone.Text = emp.BizTelephone;
                    txtEBIWebsite.Text = emp.Website;
                    dtpBusinessStartDate.Value = (DateTime)emp.BizStartDate;
                    txtEBIBusinessActivities.Text = emp.BizActivity;
                    txtEBIFirstName.Text = emp.ContactFirstName;
                    txtEBIMiddleName.Text = emp.ContactMiddleName;
                    txtEBILastName.Text = emp.ContactLastName;
                    txtEBIJobTitle.Text = emp.ContactJobTitle;
                    txtEBIPrimaryContactPhone.Text = emp.ContactPhone;
                    txtEBIPrimaryContactEmail.Text = emp.ContactEmail;
                    txteBIPrimaryContactFax.Text = emp.ContactFax;
                }

            }
        }

        private void btnEMP5575_Click(object sender, EventArgs e)
        {
           Dictionary<string,string> emp5575= RepDict.EMP5575((int)GlobalData.CurrentApplicationId);
           FormOPs.fillForm(@"c:\data\emp5575.pdf",emp5575);
        }

        private void dgvLMIAApplication_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvLMIAApplication.SelectedRows != null) {
                GlobalData.CurrentApplicationId = (int)dgvLMIAApplication.SelectedRows[0].Cells[0].Value;
                LMIAForm lf = new LMIAForm((int)GlobalData.CurrentApplicationId);
                lf.Show();
            }

        }

        private void btnAnalysisUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I haven't coded yet");
        }
    }
}

