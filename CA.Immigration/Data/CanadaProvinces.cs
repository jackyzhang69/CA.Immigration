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
            foreach(KeyValuePair<int,string> kvp in  Definition.CndProvince)   cmbProvince.Items.Add(kvp.Value);
            
         }

        }
}

