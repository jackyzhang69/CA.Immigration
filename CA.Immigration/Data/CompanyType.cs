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
            for (int i = 0; i < Definition.CompanyType.Length / 2; i++) cmbCompanyType.Items.Add(Definition.CompanyType[i, 1]);
        }
    }
}
