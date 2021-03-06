﻿using System;
using System.Windows.Forms;
using CA.Immigration.LMIA;
using CA.Immigration.SP;
using CA.Immigration.PDF;
using CA.Immigration.Utility;
using System.Linq;
using CA.Immigration.Data;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using CA.Immigration.CICDict;

namespace CA.Immigration.Startup
{
    public partial class StartupForm : Form
    {


        public StartupForm()
        {
            InitializeComponent();
            dtpPBIDOB.Format = DateTimePickerFormat.Custom;
            dtpPBIDOB.CustomFormat = "yyyy-MM-dd";
            dtpBusinessStartDate.Format = DateTimePickerFormat.Custom;
            dtpBusinessStartDate.CustomFormat = "yyyy-MM-dd";

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
            StartupOps.startupInitialize(this);
        }
        private void cmbSelectRCIC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (GlobalData.CurrentRCICIdReadOnly != true)
            {
                GlobalData.CurrentRCICId = cmbSelectRCIC.SelectedIndex + 1;
                showMainStatus();
            }
            else MessageBox.Show("This RCIC is handling an active application. Please close it before your doing anything else", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void btnInsertPassport_Click(object sender, EventArgs e)
        {
            Person.passportInsert(this);
        }

        private void btnSelectEmployer_Click(object sender, EventArgs e)
        {
            EmployerSelector es = new EmployerSelector(this);
            es.Show();
            showMainStatus();
           

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

            if (GlobalData.CurrentApplicationIdReadOnly != true)
            {
                if (GlobalData.CurrentEmployerId != null)
                {
                    if (GlobalData.CurrentPersonId != null || (GlobalData.CurrentPersonId == null && MessageBox.Show("Are you applying a unnamed LMIA?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        LMIAForm lf = new LMIAForm();
                        lf.Show();
                        showMainStatus();
                    }
                }

                else MessageBox.Show("You have to select an employer first");
            }
            else MessageBox.Show("There is an active application. Please close it before your doing anything else", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);


        }

        private void cmbProgram_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GlobalData.CurrentProgramId = (int)cmbProgram.SelectedIndex + 1;
            showMainStatus();
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
        private void btnMakeImm5476_Click(object sender, EventArgs e)
        {
            int[] ids = new int[] { 4, (int)GlobalData.CurrentPersonId };
            FormOPs.IMM5476Sign i5476 = new FormOPs.IMM5476Sign(ids);
            FormOPs.fillForm(@"c:\vba\imm5476.pdf", RepDict.IMM5476((int)GlobalData.CurrentPersonId, 1));
            FormOPs.signForm(@"c:\vba\imm5476.pdf", i5476.getFormData());
        }


        private void dgvLMIAApplication_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvLMIAApplication.SelectedRows != null)
            {
                GlobalData.CurrentApplicationId = (int)dgvLMIAApplication.SelectedRows[0].Cells[0].Value;
                using (CommonDataContext cdc = new CommonDataContext())
                {
                    GlobalData.CurrentEmployerId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.EmployerId).FirstOrDefault();
                    GlobalData.CurrentRCICId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.RCICId).FirstOrDefault();
                    GlobalData.CurrentPersonId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.EmployeeId).FirstOrDefault();
                    GlobalData.CurrentProgramId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.ProgramType).FirstOrDefault();
                }
                showMainStatus();
                LMIAForm lf = new LMIAForm();
                lf.Show();
            }

        }
        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            Form ps = new PersonSelector(this);
            ps.Show();
        }
        private void btnEBIUpdate_Click(object sender, EventArgs e)
        {
            Employer.employerUpdate(this);
        }
        private void btnEBIDelete_Click(object sender, EventArgs e)
        {
            Employer.employerDelete(this);
        }
        private void btnEBIInsert_Click(object sender, EventArgs e)
        {
            Employer.employerInsert(this);
        }
        private void btnEBIClear_Click(object sender, EventArgs e)
        {
            Employer.clearForm(this);
            Employer.fillForm(this);
            btnEBIInsert.Visible = true;
        }
        private void btnPBIInsert_Click(object sender, EventArgs e)
        {
            Person.personInsert(this);
        }
        private void btnPBIClear_Click(object sender, EventArgs e)
        {
            Person.clearForm(this);
        }
        private void btnPBIDelete_Click(object sender, EventArgs e)
        {
            Person.personDelete(this);
        }
        private void btnPBIUpdate_Click(object sender, EventArgs e)
        {
            Person.personUpdate(this);
        }
        private void cbxAlias_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAlias.Checked == true)
            {
                lblPBIAliasFN.Visible = true;
                txtPBIAFN.Visible = true;
                lblPBIAliasLN.Visible = true;
                txtPBIALN.Visible = true;
            }
            else
            {
                lblPBIAliasFN.Visible = false;
                txtPBIAFN.Visible = false;
                lblPBIAliasLN.Visible = false;
                txtPBIALN.Visible = false;
            }
        }
        private void chkBizSameAsMail_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnEMP5602_Click(object sender, EventArgs e)
        {
            StartupOps.buildupEMP5602();
        }
        private void btnEMP5575_Click_1(object sender, EventArgs e)
        {
            StartupOps.buildupEMP5575();
        }
        private void StartupForm_Activated(object sender, EventArgs e)
        {
            StartupOps.getAllApplications(this);
            StartupOps.RefreshMainForm(this);
            showMainStatus();
        }
        public void showMainStatus()
        {
            tssEmployer.Text = "Employer Id: " + GlobalData.CurrentEmployerId;
            tssPerson.Text = "Person Id:" + GlobalData.CurrentPersonId;
            tssRCIC.Text = "RCIC Id: " + GlobalData.CurrentRCICId;
            tssProgram.Text = "Program Id: " + GlobalData.CurrentProgramId;
            tssApplication.Text = "Application Id: " + GlobalData.CurrentApplicationId;
        }

        private void btnEBIAddSave_Click(object sender, EventArgs e)
        {
            Employer.addressUpdate(this);
        }

        private void StartupForm_TextChanged(object sender, EventArgs e)
        {
            Employer.getInput(this);
        }

        private void chkBizSameAsMail_CheckedChanged_1(object sender, EventArgs e)
        {
            Employer.getInput(this);
        }

        private void btnEMP5593_Click(object sender, EventArgs e)
        {
            StartupOps.buildupEMP5593();
        }
    }
}

