using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CA.Immigration.Data;

namespace CA.Immigration.LMIA
{
    public partial class LMIAForm : Form
    {
        int _employerId;
        int _employeeId;

        public LMIAForm()
        {
            InitializeComponent();
        }
        public LMIAForm(int employerId, int employeeId,int streamId)
        {
            InitializeComponent();
            _employerId = employerId;
            _employeeId = employeeId;

            GlobalData.CurrentEmployerId = employerId;
            GlobalData.CurrentPersonId = employeeId;


            // set status in status strip : Application Id, employer id, employee id, Program id, maybe RCIC id
            //-- for Analysis table
            // set application program value and disable edit
            using (CommonDataContext cdc = new CommonDataContext()) {
                applicationSteam.txtProgram.Text= cdc.tblPrograms.Where(x=>x.Id==streamId).Select(x => x.Name).Single();
                applicationSteam.txtProgram.ReadOnly = true;
            }
            

            

            // initial province data



        }

        private void LMIAForm_Load(object sender, EventArgs e)
        {

            //UCAppStream.lblAnotherEmployer.Visible = false;
            //UCAppStream.txtAnotherEmployer.Visible = false;
        
        }
    }
}
