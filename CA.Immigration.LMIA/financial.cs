using System;
using CA.Immigration.Utility;
using System.Windows.Forms;

namespace CA.Immigration.LMIA
{
    public partial class financial : UserControl
    {
        public financial()
        {
            InitializeComponent();
        }

        private void validate()
        {
            if (txtGrossPayroll1.Text != string.Empty && txtSlips1.Text != string.Empty)
            {
                if (Validation.IsFloat(txtGrossPayroll1.Text) && Validation.IsFloat(txtSlips1.Text)) txtAverageWage1.Text = getAverage(txtGrossPayroll1.Text, txtSlips1.Text);
                else {
                    MessageBox.Show("Your input, pay roll or slips, is not float");
                }

            }
            if (txtGrossPayroll2.Text != string.Empty && txtSlips2.Text != string.Empty)
            {
                if (Validation.IsFloat(txtGrossPayroll2.Text) && Validation.IsFloat(txtSlips2.Text)) txtAverageWage2.Text = getAverage(txtGrossPayroll2.Text, txtSlips2.Text);
                else {
                    MessageBox.Show("Your input, pay roll or slips, is not float");
                }
            }
        }

        public string getAverage(string a, string b)
        {

            if (Validation.IsFloat(a) && Validation.IsFloat(b))
            {
                float x = float.Parse(a);
                float y = float.Parse(b);
                if (y != 0) return (x / y).ToString();
                else return string.Empty;
            }
            else return string.Empty;

        }

        private void txtGrossPayroll1_Leave(object sender, EventArgs e)
        {
            validate();
        }

        private void txtSlips1_Leave(object sender, EventArgs e)
        {
            validate();
        }

        private void txtGrossPayroll2_Leave(object sender, EventArgs e)
        {
            validate();
        }

        private void txtSlips2_Leave(object sender, EventArgs e)
        {
            validate();
        }

        private void txtLast1Year_Leave(object sender, EventArgs e)
        {
            if (!Validation.IsIntInRange(txtLast1Year.Text, 2000, 2050) && txtLast1Year.Text != string.Empty)
            {
                MessageBox.Show("Year should be between 2000 and 2050");
                txtLast1Year.Focus();
            }
        }

        private void txtLast2Year_Leave(object sender, EventArgs e)
        {
            if (!Validation.IsIntInRange(txtLast1Year.Text, 2000, 2050) && txtLast2Year.Text != string.Empty)
            {
                MessageBox.Show("Year should be between 2000 and 2050");
                txtLast2Year.Focus();
            }
        }

        private void txtRevenue1_Leave(object sender, EventArgs e)
        {
            if (!Validation.IsFloat(txtRevenue1.Text) && txtRevenue1.Text != string.Empty)
            {
                MessageBox.Show("Revenue should be a float number");
                txtRevenue1.Focus();
            }
        }

        private void txtRevenue2_Leave(object sender, EventArgs e)
        {
            if (!Validation.IsFloat(txtRevenue2.Text) && txtRevenue2.Text != string.Empty)
            {
                MessageBox.Show("Revenue should be a float number");
                txtRevenue2.Focus();
            }
        }

        private void txtCash1_Leave(object sender, EventArgs e)
        {
            if (!Validation.IsFloat(txtCash1.Text) && txtCash1.Text != string.Empty)
            {
                MessageBox.Show("Revenue should be a float number");
                txtCash1.Focus();
            }
        }

        private void txtCash2_Leave(object sender, EventArgs e)
        {
            if (!Validation.IsFloat(txtCash2.Text) && txtCash2.Text != string.Empty)
            {
                MessageBox.Show("Revenue should be a float number");
                txtCash2.Focus();
            }
        }

        private void txtNetImcome1_Leave(object sender, EventArgs e)
        {
            if (!Validation.IsFloat(txtNetImcome1.Text) && txtNetImcome1.Text != string.Empty)
            {
                MessageBox.Show("Income should be a float number");
                txtNetImcome1.Focus();
            }
        }

        private void txtNetImcome2_Leave(object sender, EventArgs e)
        {
            if (!Validation.IsFloat(txtNetImcome2.Text) && txtNetImcome2.Text != string.Empty)
            {
                MessageBox.Show("Income should be a float number");
                txtNetImcome2.Focus();
            }
        }

        private void txtRetainedEarning1_Leave(object sender, EventArgs e)
        {
            if (!Validation.IsFloat(txtRetainedEarning1.Text) && txtRetainedEarning1.Text != string.Empty)
            {
                MessageBox.Show("Retained Earning should be a float number");
                txtRetainedEarning1.Focus();
            }
        }

        private void txtRetainedEarning2_Leave(object sender, EventArgs e)
        {
            if (!Validation.IsFloat(txtRetainedEarning2.Text) && txtRetainedEarning2.Text != string.Empty)
            {
                MessageBox.Show("Retained Earning should be a float number");
                txtRetainedEarning2.Focus();
            }
        }
    }
}

