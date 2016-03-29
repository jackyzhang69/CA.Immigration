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
        public static void initialDGVMedia(LMIAForm lf)
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
            //Media name
            MediaName.HeaderText = "Media";
            MediaName.DataPropertyName = "txtMediaName";
            // Scope
            var scope = Definition.MediaScope.Select(x=>x.Value).ToList();
            Scope.DataSource = scope;
            Scope.HeaderText = "Scope";
            Scope.DataPropertyName = "MediaScope";
            // Type
            var type = Definition.MediaType.Select(x => x.Value).ToList();
            Type.DataSource = type;
            Type.HeaderText = "Type";
            Type.DataPropertyName = "MediaType";
            //Cost
            Cost.HeaderText = "Cost";
            Cost.DataPropertyName = "txtCost";
            //Duration 
            Duration.HeaderText = "Duration";
            Duration.DataPropertyName = "txtDuration";
            //Pro 
            Pro.HeaderText = "Pro";
            Pro.DataPropertyName = "txtPro";
            //Con
            Con.HeaderText = "Con";
            Con.DataPropertyName = "txtCon";
            //Link
            Link.HeaderText = "Link";
            Link.DataPropertyName = "lnkLink";

            lf.dgvMedia.Columns.Add(Selection);
            lf.dgvMedia.Columns.Add(MediaName);
            lf.dgvMedia.Columns.Add(Scope);
            lf.dgvMedia.Columns.Add(Type);
            lf.dgvMedia.Columns.Add(Cost);
            lf.dgvMedia.Columns.Add(Duration);
            lf.dgvMedia.Columns.Add(Pro);
            lf.dgvMedia.Columns.Add(Con);
            lf.dgvMedia.Columns.Add(Link);

            DataTable dt = new DataTable();

            using (CommonDataContext cdc=new CommonDataContext()) {
                List<tblMedia> tm = cdc.tblMedias.Select(x => x).ToList() ;
                int i = 0;
                foreach(tblMedia m in tm)
                {
                    lf.dgvMedia.Rows[i].Cells[1].Value = m.MediaName;
                    lf.dgvMedia.Rows[i].Cells[2].Value = m.MediaScope;
                    lf.dgvMedia.Rows[i].Cells[3].Value = m.MediaType;
                    lf.dgvMedia.Rows[i].Cells[4].Value = m.Cost;
                    lf.dgvMedia.Rows[i].Cells[5].Value = m.Duration;
                    lf.dgvMedia.Rows[i].Cells[6].Value = m.Pro;
                    lf.dgvMedia.Rows[i].Cells[7].Value = m.Con;
                    lf.dgvMedia.Rows[i].Cells[8].Value = m.Link;

                    lf.dgvMedia.Rows.Add();
                    i++;

                }
            }
        }
    }
}
