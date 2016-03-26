﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CA.Immigration.Data;
using System.Windows.Forms;
using System.Drawing;
using CA.Immigration.Utility;
using CA.Immigration.PDF;
using CA.Immigration.CICDict;
using CA.Immigration.LMIA;

namespace CA.Immigration.Startup
{
    public class StartupOps
    {
        public static void startupInitialize(StartupForm sf)
        {
            // turn label things invisible
            sf.lblSelectedPerson.Visible = false;
            sf.lblSelectedPersonId.Visible = false;
            sf.lblSelectedEmployer.Visible = false;
            sf.lblSelectedEmployerId.Visible = false;

            using(CommonDataContext cdc = new CommonDataContext())
            {
                sf.cmbCategory.DataSource = cdc.tblCategories.Select(x => new { x.Name, x.Id });
                sf.cmbCategory.DisplayMember = "Name";
                sf.cmbCategory.ValueMember = "Id";
                sf.cmbProgram.DataSource = cdc.tblPrograms.Select(x => new { x.Name, x.Id });
                sf.cmbProgram.DisplayMember = "Name";
                sf.cmbProgram.ValueMember = "Id";
                sf.cmbProgram.SelectedIndex = 0;
                GlobalData.CurrentProgramId = sf.cmbProgram.SelectedIndex + 1;
                sf.cmbSelectRCIC.DataSource = cdc.tblRCICs.Where(x => x != null).Select(x => new { Id = x.Id, Prompt = x.FirstName + " " + x.LastName + "@" + x.BusinessLegalName });
                sf.cmbSelectRCIC.DisplayMember = "Prompt";
                sf.cmbSelectRCIC.ValueMember = "Id";
                sf.cmbSelectRCIC.SelectedIndex = 0;
                GlobalData.CurrentRCICId = cdc.tblRCICs.Select(x => x.Id).First();


                sf.cmbPBIMS.DataSource = cdc.tblMarriageStatusTypes.Select(x => new { x.MarriageStatusType, x.TypeCode });
                sf.cmbPBIMS.DisplayMember = "MarriageStatusType";
                sf.cmbPBIMS.ValueMember = "TypeCode";
                sf.cmbPBIGender.DataSource = cdc.tblGenders.Select(x => new { x.Gender, x.GenderCode });
                sf.cmbPBIGender.DisplayMember = "Gender";
                sf.cmbPBIGender.ValueMember = "GenderCode";
            }
           
            getAllApplications(sf);
        }
        public static void getAllApplications(StartupForm sf)
        {
            // if no person or/and employer selected, display all applications
            // Get LMIA application 
            using(CommonDataContext cdc = new CommonDataContext())
            {
                sf.dgvLMIAApplication.DataSource = cdc.tblLMIAApplications.Select(x => new { ID = x.Id, Employer = ((int)x.EmployerId).getEmployerFromId(), Employee = ((int)x.EmployeeId).getEmployeeFromId(), CreateDate = x.CreatedDate,SubmitDate=x.SubmittedDate,ApplicationNumber=x.ApplicationNumber,PositionNumber=x.NumberofPosition });
                sf.dgvLMIAApplication.Columns[0].Width = 35;
                sf.dgvLMIAApplication.Columns[1].Width = 185;
                sf.dgvLMIAApplication.Columns[2].Width = 110;
                sf.dgvLMIAApplication.Columns[3].Width = 80;
                sf.dgvLMIAApplication.Columns[4].Width = 80;
                sf.dgvLMIAApplication.Columns[5].Width = 85;
                sf.dgvLMIAApplication.Columns[6].Width = 85;
            }

            // Get ... application





        }
        public static void RefreshMainForm(StartupForm sf)
        {
            getAllApplications(sf);
            if(GlobalData.CurrentPersonId != null)
            {
                sf.lblSelectedPersonId.Text = GlobalData.CurrentPersonId.ToString();
                using(CommonDataContext cdc = new CommonDataContext())
                {
                    tblPerson p = cdc.tblPersons.Where(x => x.Id == GlobalData.CurrentPersonId).Select(x => x).FirstOrDefault();
                    sf.lblSelectedPerson.Text = p.FirstName + " " + p.LastName;

                }
                sf.lblSelectedPersonId.Visible = true;
                sf.lblSelectedPerson.Visible = true;
                // get Person Info
                Person.loadFromDB();
                Person.fillForm(sf);
                sf.btnPBIInsert.Visible = false;
            }
            else {
                Person.clearForm(sf);
                clearSelectedPerson(sf);
                sf.btnPBIInsert.Visible = true;
            }

            if(GlobalData.CurrentEmployerId != null)
            {
                sf.lblSelectedEmployerId.Text = GlobalData.CurrentEmployerId.ToString();
                using(CommonDataContext cdc = new CommonDataContext())
                {
                    tblEmployer e = cdc.tblEmployers.Where(x => x.Id == GlobalData.CurrentEmployerId).Select(x => x).FirstOrDefault();
                    sf.lblSelectedEmployer.Text = e.LegalName;
                }
                sf.lblSelectedEmployer.Visible = true;
                sf.lblSelectedEmployerId.Visible = true;
                Employer.loadFromDB();
                Employer.fillForm(sf);
                sf.btnEBIInsert.Visible = false;
            }
            else { Employer.clearForm(sf); clearSelectedEmployer(sf); sf.btnEBIInsert.Visible = false; }

        }

        public static void clearSelectedPerson(StartupForm sf)
        {
            sf.lblSelectedPerson.Text = null;
            sf.lblSelectedPersonId.Text = null;
        }
        public static void clearSelectedEmployer(StartupForm sf)
        {
            sf.lblSelectedEmployer.Text = null;
            sf.lblSelectedEmployerId.Text = null;
        }
        public static void buildupEMP5575()
        {
            Dictionary<string, string> dict5575 = new Dictionary<string, string>();
                       
            //RCIC's company Information
            RCIC.buildupDict5575(ref dict5575);
            // Employer Information
            Employer.buildupDict5575(ref dict5575);
            // Employee information
            Person.buildupDict5575(ref dict5575);   
            
            FormOPs.fillForm(@"c:\data\emp5575.pdf", dict5575);
        }
        public static void buildupEMP5602()
        {
          
            Dictionary<string, string> dict5602 = new Dictionary<string, string>();

            // Analysis information
            LMIAAnalysis.buildupDict5602(ref dict5602);  
            //Employer Information
            Employer.buildupDict5602(ref dict5602);
            //3rd party information
            RCIC.buildupDict5602(ref dict5602);
            // Business detail Information
            LMIABusinessDetail.buildupDict5602(ref dict5602);
            // Job offer information
            LMIAJobOffer.buildupDict5602(ref dict5602);
            // 

            FormOPs.fillForm(@"c:\data\emp5602.pdf", dict5602);
        }
    }
}
