using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CA.Immigration.Data;

namespace CA.Immigration.LMIA
{
    public class Media
    {
        public static void initialDGVMedia(LMIAForm lf)
        {
            DataGridViewComboBoxColumn Scope = new DataGridViewComboBoxColumn();
            var scope = Definition.MediaScope.Select(x=>x.Value).ToList();
            Scope.DataSource = scope;
            Scope.HeaderText = "Scope";
            Scope.DataPropertyName = "MediaScope";

            lf.dgvMedia.Columns.Add(Scope);
        }
    }
}
