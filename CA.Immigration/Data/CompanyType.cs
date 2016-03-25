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
    public partial class CompanyType : UserControl
    {
        public CompanyType()
        {
            InitializeComponent();
           foreach(KeyValuePair<int,string> kvp in Definition.CompanyType) cmbCompanyType.Items.Add(kvp.Value);
        }
    }
}
