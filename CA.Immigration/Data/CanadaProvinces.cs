using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CA.Immigration.Data;

namespace CA.Immigration.Data
{
    public partial class CanadaProvinces : UserControl
    {
        public CanadaProvinces()
        {
            InitializeComponent();
            for (int i = 0; i < Definition.CndProvince.Count-1;i++) cmbProvince.Items.Add(Definition.CndProvince[i]);

        }
    }
}

