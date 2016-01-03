using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SoftwareByDefault.OpenSource.BatToExe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenBatch_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Input batch file";
            ofd.Multiselect = false;
            ofd.Filter = "Batch Files (*.bat)|*.bat";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtInputBatch.Text = ofd.FileName;
            }
        }

        private void btnSaveExecutable_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Specify where you want to save the generated executable file.";
            sfd.AddExtension = true;
            sfd.DefaultExt = "exe";
            sfd.Filter = "Executable (*.exe)|*.exe";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtOutputExe.Text = sfd.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtInputBatch.Text) == false)
            {
                MessageBox.Show("The input batch file you specified could not be accessed!", "Invalid input file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Directory.Exists(Path.GetDirectoryName(txtOutputExe.Text)) == false)
            {
                if (MessageBox.Show("The output directory you specified does not exist. Do you want to create it", "Output Directory", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(txtOutputExe.Text));
                }
                else
                {
                    return;
                }
            }

            //Make sure the output file specified ends in *.exe extension
            txtOutputExe.Text = Path.ChangeExtension(txtOutputExe.Text, "exe");

            if (AssemblyGenerator.Generate(txtInputBatch.Text, txtOutputExe.Text, chkShowOutput.Checked) == true)
            {
                MessageBox.Show("The Executable file was generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Process prc = new Process();
                prc.StartInfo.FileName = Path.GetDirectoryName(txtOutputExe.Text);
                prc.StartInfo.UseShellExecute = true;

                prc.Start();
            }
            else
            {
                MessageBox.Show("The Executable file failed to generate!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
