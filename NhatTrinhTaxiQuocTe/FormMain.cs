using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NhatTrinhTaxiQuocTe
{
    public partial class FormMain : Form
    {
        private string fileName = "";
        private Excel excel;

        public FormMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                // get File Name
                txtFileName.Text = fileName;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Equals(""))
            {
                DialogResult dlr = MessageBox.Show("You didn't choose file!\nPlease choose a file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dlr == DialogResult.OK)
                {
                    btnBrowse_Click(sender, e);
                }
            }
            else if (txtEndLineOfFile.Text.Equals(""))
            {
                MessageBox.Show("You didn't enter \"Line END of file\"!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndLineOfFile.Focus();
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Do you want to \"AUTO COPY PASTE\"?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    try
                    {
                        int endOfFile = Int32.Parse(txtEndLineOfFile.Text);
                        excel = new Excel(fileName, 1, endOfFile, progressBar);
                        progressBar.Minimum = 0;
                        progressBar.Maximum = endOfFile;
                        excel.AutoCopyPatse();
                    }
                    catch (FormatException fe)
                    {
                        MessageBox.Show("You must enter number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEndLineOfFile.Focus();
                    }


                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                excel.closeExcel();
            }
            catch (Exception ex) { }
        }

    }
}
