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
            StartupOps.startupInitialize(this);
        }
        private void cmbSelectRCIC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GlobalData.CurrentRCICId = cmbSelectRCIC.SelectedIndex;
        }




        private void btnInsertPassport_Click(object sender, EventArgs e)
        {
            Person.passportInsert(this);
        }

        private void btnSelectEmployer_Click(object sender, EventArgs e)
        {
            EmployerSelector es = new EmployerSelector(this);
            es.Show();
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GlobalData.CurrentCategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            using(CommonDataContext cdc = new CommonDataContext())
            {
                int id = int.Parse(cmbCategory.SelectedValue.ToString());
                if(cdc.tblPrograms.Where(x => x.CategoryId == id).Select(x => x.Name) != null)
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
            switch(GlobalData.CurrentProgramId)
            {
                case (int)GlobalData.AppStream.LMIAPRandWP:

                    break;
                case (int)GlobalData.AppStream.LMIAWPOnly:
                    if(GlobalData.CurrentEmployerId != null)
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
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pcbPhoto.Image = Image.FromFile(ofd.FileName);
                pcbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnSignature_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file|*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
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

        private void btnEMP5575_Click(object sender, EventArgs e)
        {
            //if(GlobalData.CurrentApplicationId != null) { StartupOps.buildupEMP5575(); }
            //else MessageBox.Show("There is no active application");
            GlobalData.CurrentApplicationId = 7;
            StartupOps.buildupEMP5575();
        }

        private void dgvLMIAApplication_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dgvLMIAApplication.SelectedRows != null)
            {
                GlobalData.CurrentApplicationId = (int)dgvLMIAApplication.SelectedRows[0].Cells[0].Value;
                LMIAForm lf = new LMIAForm((int)GlobalData.CurrentApplicationId);
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

        private void cmbSelectRCIC_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            GlobalData.CurrentRCICId = cmbSelectRCIC.SelectedIndex;
        }
    }
}

