using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CA.Immigration.Data;
using System.Data;
using CA.Immigration.Utility;

namespace CA.Immigration.LMIA
{
    public class JobPost
    {
        public static Dictionary<int, int> jobPostIndex = new Dictionary<int, int>();
        public int _applicationID { get; set; }
        public int _Status { get; set; }
        public int _Qualified { get; set; }
        public string _MediaName { get; set; }
        public DateTime _PostDate { get; set; }
        public DateTime _ExpiryDate { get; set; }
        public DateTime _InitialPrintDate { get; set; }
        public DateTime _LastPrintDate { get; set; }
        public string _Account { get; set; }
        public string _Password { get; set; }
        public string _OtherInfo { get; set; }
        public decimal? _Cost { get; set; }
        public string _Link { get; set; }

        // Media variables
        public static string _mediaName { get; set; }
        public static decimal? _MediaCost { get; set; }

        public static void ConstructJobPost(LMIAForm lf)
        {
            DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn();
            DataGridViewComboBoxColumn Status = new DataGridViewComboBoxColumn();
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

            // Select check box
            Select.HeaderText = "Select";
            Select.DataPropertyName = "Select";
            Select.Width = 50;
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
            lf.dgvJobPost.Columns.Add(Select);
            lf.dgvJobPost.Columns.Add(Status);
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
        public static void SetJobPosting(LMIAForm lf)  // for form load construction
        {
            List<tblJobPost> jp = LoadFromDB();
            if (jp != null)
            {
                FillDGVJobPost(lf, jp);
                for (int i = 0; i < jp.Count; i++) jobPostIndex.Add(i, jp[i].Id);
            }

        }
        public static void SetJobPosting(LMIAForm lf, List<int> indecies) // for Go Post button clicked
        {
            InsertToDB(lf, indecies);
            List<tblJobPost> jp = LoadFromDB();
            jobPostIndex.Clear();
            if (jp != null)
            {
                FillDGVJobPost(lf, jp);
                for (int i = 0; i < jp.Count; i++) jobPostIndex.Add(i, jp[i].Id);
            }

        }


        private static void FillDGVJobPost(LMIAForm lf, List<tblJobPost> jp)
        {
            int i;
            for (i = 0; i < jp.Count; i++)
            {
                lf.dgvJobPost.Rows.Add();
                lf.dgvJobPost.Rows[i].Cells[0].Value = jp[i].Checked;
                lf.dgvJobPost.Rows[i].Cells[1].Value = jp[i].Status;
                lf.dgvJobPost.Rows[i].Cells[2].Value = jp[i].MediaName;
                lf.dgvJobPost.Rows[i].Cells[3].Value = jp[i].PostDate;
                lf.dgvJobPost.Rows[i].Cells[4].Value = jp[i].ExpiryDate;
                lf.dgvJobPost.Rows[i].Cells[5].Value = jp[i].InitialPrintDate;
                lf.dgvJobPost.Rows[i].Cells[6].Value = jp[i].LastPrintDate;
                lf.dgvJobPost.Rows[i].Cells[7].Value = jp[i].LastPrintDate - jp[i].InitialPrintDate;
                lf.dgvJobPost.Rows[i].Cells[8].Value = jp[i].Account;
                lf.dgvJobPost.Rows[i].Cells[9].Value = jp[i].Password;
                lf.dgvJobPost.Rows[i].Cells[10].Value = jp[i].OtherInfo;
                lf.dgvJobPost.Rows[i].Cells[11].Value = jp[i].Cost;
                lf.dgvJobPost.Rows[i].Cells[12].Value = jp[i].Link;
            }
        }
        public static void InsertToDB(LMIAForm lf, List<int> indecies)
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                List<tblJobPost> jp = new List<tblJobPost>();
                foreach (int index in indecies)
                {
                    _mediaName = (string)lf.dgvMedia.Rows[index].Cells[1].Value;
                    _MediaCost = (decimal)lf.dgvMedia.Rows[index].Cells[4].Value;
                    tblJobPost tjp = new tblJobPost
                    {
                        applicationID = GlobalData.CurrentApplicationId,
                        MediaName = _mediaName,
                        Cost = _MediaCost
                    };
                    jp.Add(tjp);
                }
                for (int i = 0; i < jp.Count; i++) cdc.tblJobPosts.InsertOnSubmit(jp[i]);

                try
                {
                    cdc.SubmitChanges();
                    MessageBox.Show("Job posts have been created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        public static List<tblJobPost> LoadFromDB()
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                List<tblJobPost> jp = cdc.tblJobPosts.Where(x => x.applicationID == GlobalData.CurrentApplicationId).Select(x => x).ToList();
                return jp;
            }
        }

    }
}
