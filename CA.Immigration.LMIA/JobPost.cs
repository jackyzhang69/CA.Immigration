﻿using System;
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
        public static int _applicationID { get; set; }
        public static int _Status { get; set; }
        public static string _MediaName { get; set; }
        public static DateTime? _PostDate { get; set; }
        public static DateTime? _ExpiryDate { get; set; }
        public static DateTime? _InitialPrintDate { get; set; }
        public static DateTime? _LastPrintDate { get; set; }
        public static string _Account { get; set; }
        public static string _Password { get; set; }
        public static string _OtherInfo { get; set; }
        public static decimal? _Cost { get; set; }
        public static string _Link { get; set; }
        public static int _days { get; set; }

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
            PostDate.DefaultCellStyle.Format = "yyyy/MM/dd";
            PostDate.DataPropertyName = "PostDate";
            PostDate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            PostDate.Width = 80;
            //ExpiryDate 
            ExpiryDate.HeaderText = "ExpiryDate";
            ExpiryDate.DefaultCellStyle.Format = "yyyy/MM/dd";
            ExpiryDate.DataPropertyName = "ExpiryDate";
            ExpiryDate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            ExpiryDate.Width = 80;
            //InitialPrintDate 
            InitialPrintDate.HeaderText = "InitialPrintDate";
            InitialPrintDate.DefaultCellStyle.Format = "yyyy/MM/dd";
            InitialPrintDate.DataPropertyName = "InitialPrintDate";
            InitialPrintDate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            InitialPrintDate.Width = 80;
            //LastPrintDate 
            LastPrintDate.HeaderText = "LastPrintDate";
            LastPrintDate.DefaultCellStyle.Format = "yyyy/MM/dd";
            LastPrintDate.DataPropertyName = "LastPrintDate";
            LastPrintDate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            LastPrintDate.Width = 80;
            //ProvenDays 
            ProvenDays.HeaderText = "Days";
            ProvenDays.DataPropertyName = "ProvenDays";
            ProvenDays.DefaultCellStyle.Format = "#";
            ProvenDays.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            ProvenDays.Width = 40;
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
            Cost.Width = 50;
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
            lf.dgvJobPost.AllowUserToAddRows = false;
            // disable column sort 
            foreach(DataGridViewColumn column in lf.dgvJobPost.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //lf.dgvJobPost.AutoSizeRowsMode =DataGridVieutoSizeRowsMode.AllCells;
            lf.dgvJobPost.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }
        public static void SetJobPosting(LMIAForm lf)  // for form load construction
        {
            jobPostIndex.Clear();
            List<tblJobPost> jp = LoadFromDB();

            if(jp != null)
            {
                FillDGVJobPost(lf, jp);
                for(int i = 0; i < jp.Count; i++) jobPostIndex.Add(i, jp[i].Id);
            }

        }
        public static void SetJobPosting(LMIAForm lf, List<int> indecies) // for Go Post button clicked
        {
            InsertToDB(lf, indecies);
            List<tblJobPost> jp = LoadFromDB();
            jobPostIndex.Clear();
            if(jp != null)
            {
                FillDGVJobPost(lf, jp);
                for(int i = 0; i < jp.Count; i++) jobPostIndex.Add(i, jp[i].Id);
            }

        }
        public static void FillDGVJobPost(LMIAForm lf, List<tblJobPost> jp)
        {
            int i;
            lf.dgvJobPost.Rows.Clear();
            for(i = 0; i < jp.Count; i++)
            {
                lf.dgvJobPost.Rows.Add();
                lf.dgvJobPost.Rows[i].Cells[0].Value = jp[i].Checked;
                lf.dgvJobPost.Rows[i].Cells[1].Value = jp[i].Status;
                lf.dgvJobPost.Rows[i].Cells[2].Value = jp[i].MediaName;
                setRowAndColumn(lf, 2, i);
                lf.dgvJobPost.Rows[i].Cells[3].Value = jp[i].PostDate;
                lf.dgvJobPost.Rows[i].Cells[4].Value = jp[i].ExpiryDate;
                lf.dgvJobPost.Rows[i].Cells[5].Value = jp[i].InitialPrintDate;
                lf.dgvJobPost.Rows[i].Cells[6].Value = jp[i].LastPrintDate;
                lf.dgvJobPost.Rows[i].Cells[7].Value = (jp[i].LastPrintDate==null || jp[i].InitialPrintDate==null) ?0:((DateTime)jp[i].LastPrintDate - (DateTime)jp[i].InitialPrintDate).Days;
                lf.dgvJobPost.Rows[i].Cells[8].Value = jp[i].Account;
                setRowAndColumn(lf, 8, i);
                lf.dgvJobPost.Rows[i].Cells[9].Value = jp[i].Password;
                setRowAndColumn(lf, 9, i);
                lf.dgvJobPost.Rows[i].Cells[10].Value = jp[i].OtherInfo;
                setRowAndColumn(lf, 10, i);
                lf.dgvJobPost.Rows[i].Cells[11].Value = jp[i].Cost;
                lf.dgvJobPost.Rows[i].Cells[12].Value = jp[i].Link;
                setRowAndColumn(lf, 12, i);
                // lf.dgvJobPost.AutoResizeRow(i);
            }
        }
        public static void InsertToDB(LMIAForm lf, List<int> indecies)
        {
            using(CommonDataContext cdc = new CommonDataContext())
            {
                List<tblJobPost> jp = new List<tblJobPost>();
                foreach(int index in indecies)
                {
                    _mediaName = (string)lf.dgvMedia.Rows[index].Cells[1].Value;
                    _MediaCost = (decimal)lf.dgvMedia.Rows[index].Cells[4].Value;
                    tblJobPost tjp = new tblJobPost
                    {
                        applicationID = GlobalData.CurrentApplicationId,
                        mediaId=Media.mediaIndex[index],
                        MediaName = _mediaName,
                        Cost = _MediaCost
                    };
                    jp.Add(tjp);
                }
                for(int i = 0; i < jp.Count; i++) cdc.tblJobPosts.InsertOnSubmit(jp[i]);

                try
                {
                    cdc.SubmitChanges();
                    //  MessageBox.Show("Job posts have been created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        public static List<tblJobPost> LoadFromDB()
        {
            using(CommonDataContext cdc = new CommonDataContext())
            {
                List<tblJobPost> jp = cdc.tblJobPosts.Where(x => x.applicationID == GlobalData.CurrentApplicationId).Select(x => x).ToList();
                return jp;
            }
        }
        public static void DeleteJobPosts(List<int> idList)
        {
            using(CommonDataContext cdc = new CommonDataContext())
            {
                for(int i = 0; i < idList.Count; i++)
                {
                    tblJobPost jp = cdc.tblJobPosts.Where(x => x.Id == idList[i]).Select(x => x).FirstOrDefault();
                    if(jp != null) cdc.tblJobPosts.DeleteOnSubmit(jp);
                }
                try
                {

                    if(MessageBox.Show("Are you sure to delete selected Job Post?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) cdc.SubmitChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        public static void GetInput(LMIAForm lf, int rowIndex)
        {
            _Status = lf.dgvJobPost.Rows[rowIndex].Cells[1].Value == null ? -1 : (int)lf.dgvJobPost.Rows[rowIndex].Cells[1].Value;
            _MediaName = (string)lf.dgvJobPost.Rows[rowIndex].Cells[2].Value;
            _PostDate = DateOps.getDate(lf.dgvJobPost.Rows[rowIndex].Cells[3].Value);
            _ExpiryDate = DateOps.getDate(lf.dgvJobPost.Rows[rowIndex].Cells[4].Value);
            _InitialPrintDate = DateOps.getDate(lf.dgvJobPost.Rows[rowIndex].Cells[5].Value);
            _LastPrintDate = DateOps.getDate(lf.dgvJobPost.Rows[rowIndex].Cells[6].Value);
            _Account = (string)lf.dgvJobPost.Rows[rowIndex].Cells[8].Value;
            _Password = (string)lf.dgvJobPost.Rows[rowIndex].Cells[9].Value;
            _OtherInfo = (string)lf.dgvJobPost.Rows[rowIndex].Cells[10].Value;
            _Cost = (decimal)lf.dgvJobPost.Rows[rowIndex].Cells[11].Value;
            _Link = (string)lf.dgvJobPost.Rows[rowIndex].Cells[12].Value;

        }
        internal static void UpdateJobPost(LMIAForm lf)
        {

            using(CommonDataContext cdc = new CommonDataContext())
            {
                for(int i = 0; i < lf.dgvJobPost.Rows.Count; i++)
                {
                    GetInput(lf, i);
                    tblJobPost jp = cdc.tblJobPosts.Where(x => x.Id == jobPostIndex[i]).Select(x => x).FirstOrDefault();
                    jp.Status = _Status;
                    jp.MediaName = _MediaName;
                    jp.PostDate = _PostDate;
                    jp.ExpiryDate = _ExpiryDate;
                    jp.InitialPrintDate = _InitialPrintDate;
                    jp.LastPrintDate = _LastPrintDate;
                    jp.Account = _Account;
                    jp.Password = _Password;
                    jp.OtherInfo = _OtherInfo;
                    jp.Cost = _Cost;
                    jp.Link = _Link;
                }
                try
                {
                    cdc.SubmitChanges();
                    MessageBox.Show("Data has been updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        internal static void setRowAndColumn(LMIAForm lf, int columnIndex, int rowIndex)
        {
            int maxRowHeight = 0;
            for(int i = 0; i < lf.dgvJobPost.Columns.Count; i++)
            {
                if(lf.dgvJobPost.Rows[rowIndex].Cells[i].Value != null)
                {
                    string cellValue = lf.dgvJobPost.Rows[rowIndex].Cells[i].Value.ToString();

                    int rowHeight = (int)(cellValue.Length * 10 / lf.dgvJobPost.Columns[columnIndex].Width);
                    rowHeight =  rowHeight * 10+22; //default row height is 22
                    maxRowHeight = rowHeight > maxRowHeight ? rowHeight : maxRowHeight;

                }
            }
            lf.dgvJobPost.Rows[rowIndex].Height = maxRowHeight > 65536 ? 65536 : maxRowHeight;
        }

        public static void getProvenDays(LMIAForm lf, int columnIndex, int rowIndex)
        {

            if(DateOps.isValidDate(lf.dgvJobPost.Rows[rowIndex].Cells[5].Value) && DateOps.isValidDate(lf.dgvJobPost.Rows[rowIndex].Cells[6].Value))
            {
                _InitialPrintDate = DateOps.getDate(lf.dgvJobPost.Rows[rowIndex].Cells[5].Value);
                _LastPrintDate = DateOps.getDate(lf.dgvJobPost.Rows[rowIndex].Cells[6].Value);
                lf.dgvJobPost.Rows[rowIndex].Cells[7].Value =(_LastPrintDate==null || _InitialPrintDate==null) ?0:((DateTime)_LastPrintDate - (DateTime)_InitialPrintDate).Days;
            }
        }
    }
}
