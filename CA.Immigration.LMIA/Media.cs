using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CA.Immigration.Data;
using System.Data;

namespace CA.Immigration.LMIA
{
    public class Media
    {
        public static Dictionary<int, int> mediaIndex = new Dictionary<int, int>(); 
        public static void InitialDGVMedia(LMIAForm lf)
        {
                    
            ConstructMedias(lf);
            ConstructJobPost(lf);
        }
        public static void ConstructMedias(LMIAForm lf)
        {
           

            DataGridViewCheckBoxColumn Selection = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn MediaName = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn Scope = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn Type = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn Cost = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Duration = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Pro = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Con = new DataGridViewTextBoxColumn();
            DataGridViewLinkColumn Link = new DataGridViewLinkColumn();
            

            // Select check box
            Selection.HeaderText = "Select";
            Selection.DataPropertyName = "chkSelect";
            Selection.Width = 50;
            //Media name
            MediaName.HeaderText = "Media";
            MediaName.DataPropertyName = "txtMediaName";
            MediaName.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            MediaName.Width = 150;
            // Scope
            var scope = Definition.MediaScope.Select(x => new { Id = x.Key, Name = x.Value }).ToList();
            Scope.DataSource = scope;
            Scope.HeaderText = "Scope";
            Scope.DisplayMember = "Name";
            Scope.ValueMember = "Id";
            Scope.DataPropertyName = "Id";
            Scope.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            Scope.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            Scope.Width = 80;
            // Type
            var type = Definition.MediaType.Select(x => new { Id = x.Key, Name = x.Value }).ToList();
            Type.DataSource = type;
            Type.HeaderText = "Type";
            Type.DataPropertyName = "Id";
            Type.DisplayMember = "Name";
            Type.ValueMember = "Id";
            Type.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            Type.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            Type.Width = 80;
            //Cost
            Cost.HeaderText = "Cost";
            Cost.DataPropertyName = "txtCost";
            Cost.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            Cost.DefaultCellStyle.Format = "N2";
            Cost.Width = 60;
            //Duration 
            Duration.HeaderText = "Duration";
            Duration.DataPropertyName = "txtDuration";
            Duration.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            Duration.Width = 60;
            //Pro 
            Pro.HeaderText = "Pro";
            Pro.DataPropertyName = "txtPro";
            Pro.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            Pro.Width = 150;
            //Con
            Con.HeaderText = "Con";
            Con.DataPropertyName = "txtCon";
            Con.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            Con.Width = 150;
            //Link
            Link.HeaderText = "Link";
            Link.DataPropertyName = "lnkLink";
            Link.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            Link.Width = 200;

            lf.dgvMedia.AutoGenerateColumns = false;
            lf.dgvMedia.Columns.Add(Selection);
            lf.dgvMedia.Columns.Add(MediaName);
            lf.dgvMedia.Columns.Add(Scope);
            lf.dgvMedia.Columns.Add(Type);
            lf.dgvMedia.Columns.Add(Cost);
            lf.dgvMedia.Columns.Add(Duration);
            lf.dgvMedia.Columns.Add(Pro);
            lf.dgvMedia.Columns.Add(Con);
            lf.dgvMedia.Columns.Add(Link);

            List<tblMedia> tm = new List<tblMedia>();
            
            using(CommonDataContext cdc = new CommonDataContext())
            {
                tm = cdc.tblMedias.Select(x => x).ToList();
                int i = 0;
                foreach(tblMedia m in tm)
                {
                    mediaIndex.Add(i,m.Id);
                    lf.dgvMedia.Rows.Add();
                    lf.dgvMedia.Rows[i].Cells[0].Value = false;
                    lf.dgvMedia.Rows[i].Cells[1].Value = m.MediaName;
                    lf.dgvMedia.Rows[i].Cells[2].Value = m.MediaScope == null ? -1 : (int)m.MediaScope;
                    lf.dgvMedia.Rows[i].Cells[3].Value = m.MediaType == null ? -1 : (int)m.MediaType;
                    lf.dgvMedia.Rows[i].Cells[4].Value = m.Cost;
                    lf.dgvMedia.Rows[i].Cells[5].Value = m.Duration;
                    lf.dgvMedia.Rows[i].Cells[6].Value = m.Pro;
                    lf.dgvMedia.Rows[i].Cells[7].Value = m.Con;
                    lf.dgvMedia.Rows[i].Cells[8].Value = m.Link;
                    i++;

                }
            }
        }
        private static void ConstructJobPost(LMIAForm lf)
        {
            DataGridViewComboBoxColumn Status = new DataGridViewComboBoxColumn();
            DataGridViewCheckBoxColumn Qualified = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn MediaName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn PostDate = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ExpiryDate = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn InitialPrintDate = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn LastPrintDate = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ProvenDays = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Account = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Password = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn OtherInfo = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Cost = new DataGridViewTextBoxColumn();
            DataGridViewLinkColumn Link = new DataGridViewLinkColumn();

            //Status
            var status = Definition.JobPostStatus.Select(x => new { Id = x.Key, Name = x.Value }).ToList();
            Status.DataSource = status;
            Status.HeaderText = "Status";
            Status.DisplayMember = "Name";
            Status.ValueMember = "Id";
            Status.DataPropertyName = "Id";
            Status.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            Status.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            Status.Width = 80;
            // Qualified check box
            Qualified.HeaderText = "Done";
            Qualified.DataPropertyName = "Done";
            Qualified.Width = 50;
            //Media name
            MediaName.HeaderText = "Media";
            MediaName.DataPropertyName = "Media";
            MediaName.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            MediaName.Width = 150;
            //PostDate 
            PostDate.HeaderText = "PostDate";
            PostDate.DataPropertyName = "PostDate";
            PostDate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            PostDate.Width = 150;
            //ExpiryDate 
            ExpiryDate.HeaderText = "ExpiryDate";
            ExpiryDate.DataPropertyName = "ExpiryDate";
            ExpiryDate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            ExpiryDate.Width = 150;
            //InitialPrintDate 
            InitialPrintDate.HeaderText = "InitialPrintDate";
            InitialPrintDate.DataPropertyName = "InitialPrintDate";
            InitialPrintDate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            InitialPrintDate.Width = 150;
            //LastPrintDate 
            LastPrintDate.HeaderText = "LastPrintDate";
            LastPrintDate.DataPropertyName = "LastPrintDate";
            LastPrintDate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            LastPrintDate.Width = 150;
            //ProvenDays 
            ProvenDays.HeaderText = "ProvenDays";
            ProvenDays.DataPropertyName = "ProvenDays";
            ProvenDays.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            ProvenDays.Width = 150;
            //Account 
            Account.HeaderText = "Account";
            Account.DataPropertyName = "Account";
            Account.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            Account.Width = 150;
            //Password 
            Password.HeaderText = "Password";
            Password.DataPropertyName = "Password";
            Password.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            Password.Width = 150;
            //OtherInfo 
            OtherInfo.HeaderText = "OtherInfo";
            OtherInfo.DataPropertyName = "OtherInfo";
            OtherInfo.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            OtherInfo.Width = 150;
            //Cost
            Cost.HeaderText = "Cost";
            Cost.DataPropertyName = "txtCost";
            Cost.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            Cost.DefaultCellStyle.Format = "N2";
            Cost.Width = 60;
            //Link
            Link.HeaderText = "Link";
            Link.DataPropertyName = "lnkLink";
            Link.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            Link.Width = 200;

            lf.dgvJobPost.AutoGenerateColumns = false;
            lf.dgvJobPost.Columns.Add(Status);
            lf.dgvJobPost.Columns.Add(Qualified); 
            lf.dgvJobPost.Columns.Add(MediaName);
            lf.dgvJobPost.Columns.Add(PostDate);
            lf.dgvJobPost.Columns.Add(ExpiryDate);
            lf.dgvJobPost.Columns.Add(InitialPrintDate);
            lf.dgvJobPost.Columns.Add(LastPrintDate);
            lf.dgvJobPost.Columns.Add(ProvenDays);
            lf.dgvJobPost.Columns.Add(Account);
            lf.dgvJobPost.Columns.Add(Password);
            lf.dgvJobPost.Columns.Add(OtherInfo);
            lf.dgvJobPost.Columns.Add(Cost);
            lf.dgvJobPost.Columns.Add(Link);

            
        }
        public static void SetJobPosting(LMIAForm lf, List<int> indecies)
        {
           
            using(CommonDataContext cdc = new CommonDataContext())
            {
                int i = 0;
                foreach (int index in indecies)
                {
                    int Id = mediaIndex[index];
                    tblMedia md = cdc.tblMedias.Where(x => x.Id == Id).Select(x => x).FirstOrDefault();
                    lf.dgvJobPost.Rows.Add();
                    lf.dgvJobPost.Rows[i].Cells[2].Value = md.MediaName;
                    lf.dgvJobPost.Rows[i].Cells[11].Value = md.Cost;
                    lf.dgvJobPost.Rows[i].Cells[12].Value = @"http:\\www.google.com";
                    i++;
                }
            }

        }

        public static void LoadNocMainDuties(LMIAForm lf)
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                tblNOC noc =
                    cdc.tblNOCs.Where(x => x.NOC.Equals(lf.jobPositionAdvisor.txtNoc.Text))
                        .Select(x => x)
                        .FirstOrDefault();
                if (noc != null)
                {
                    lf.txtNOCMainDuties.Text = noc.MainDuties;
                    lf.txtESDCQualification.Text = noc.EmploymentRequirement;
                }
            }

        }

        // setup remind functions based on expiry date, 14 or 28 days posted, auto direct to the web pages for printing

        // auto detect if the job post is qualified based on post date, print date, and therefore proven days. once qualified, automatically check qualified box.

    }

}
