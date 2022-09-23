using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NICManager
{
    public partial class formQuery : Form
    {
        DatabaseConnection conn = new DatabaseConnection();
        public int caseNumber;
        public string nicNumber;
        public formQuery()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNIC.Text = "";
            txtCaseNumber.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Basic validation of data
            if (txtNIC.Text == "" && txtCaseNumber.Text == "")
            {
                lblStatusQuery.ForeColor = Color.Fuchsia;
                lblStatusQuery.Text = "You must input a NIC number or a case number to search.";
                lblStatusQuery.Visible = true;
                return;
            }
            else if (txtNIC.Text.Length < 10 && txtNIC.Text != "" && txtCaseNumber.Text == "")
            {
                lblStatusQuery.ForeColor = Color.Fuchsia;
                lblStatusQuery.Text = "NIC numbers must be 10 characters.";
                lblStatusQuery.Visible = true;
                return;
            }
            else if (!Char.IsLetter(txtNIC.Text.FirstOrDefault()) && txtCaseNumber.Text == "")
            {
                lblStatusQuery.ForeColor = Color.Fuchsia;
                lblStatusQuery.Text = "NIC numbers must begin with a letter.";
                lblStatusQuery.Visible = true;
                return;
            }
            else if (!IsDigitsOnly(txtCaseNumber.Text) && txtCaseNumber.Text != "" && txtNIC.Text == "")
            {
                lblStatusQuery.ForeColor = Color.Fuchsia;
                lblStatusQuery.Text = "Case numbers must be numbers only. Omit all letters and symbols to search.";
                lblStatusQuery.Visible = true;
                return;
            }

            // Validation complete, begin query with NIC number
            if (txtNIC.Text != "" && txtNIC.Text.Length == 10 && Char.IsLetter(txtNIC.Text.FirstOrDefault()))
            {
                nicNumber = txtNIC.Text;
            }
            // Validation complete, begin query with case number
            else if (txtCaseNumber.Text != "" && IsDigitsOnly(txtCaseNumber.Text))
            {
                try
                {
                    caseNumber = Convert.ToInt32(txtCaseNumber.Text);
                }
                catch (Exception ex)
                {
                    caseNumber = 0;
                    lblStatusQuery.ForeColor = Color.Red;
                    lblStatusQuery.Text = "Case number invalid. Error: " + ex.Message + " Contact support.";
                    lblStatusQuery.Visible = true;
                    return;
                }
            }
            else
            {
                lblStatusQuery.ForeColor = Color.Fuchsia;
                lblStatusQuery.Text = "You must enter a NIC number or case number to search.";
                lblStatusQuery.Visible = true;
                return;
            }
        }
        // Helper for making sure an item is numbers only
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            lblStatusQuery.ForeColor = Color.Black;
            lblStatusQuery.Text = "";
            lblStatusQuery.Visible = false;
        }

        private void txtCaseNumber_TextChanged(object sender, EventArgs e)
        {
            lblStatusQuery.ForeColor = Color.Black;
            lblStatusQuery.Text = "";
            lblStatusQuery.Visible = false;
        }
    }
}