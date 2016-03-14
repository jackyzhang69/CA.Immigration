using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA.Immigration.Data
{
    public partial class SelectRCIC : UserControl
    {
        public SelectRCIC()
        {
            InitializeComponent();
            using (CommonDataContext cdc=new CommonDataContext())
            {
                cmbSelectRCIC.DataSource = cdc.tblRCICs.Select(x => new { Id = x.Id, Prompt = x.FirstName + " " + x.LastName + "@" + x.BusinessLegalName });
                cmbSelectRCIC.DisplayMember = "Prompt";
                cmbSelectRCIC.ValueMember = "Id";
                cmbSelectRCIC.SelectedIndex = 0;
                GlobalData.CurrentRCICId = cdc.tblRCICs.Select(x => x.Id).First();
            }
        }

        private void cmbSelectRCIC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GlobalData.CurrentRCICId = cmbSelectRCIC.SelectedIndex;
        }
    }
}
