using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileRenamer
{
    public partial class frmMain : Form
    {
        public string ContainingFolder;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select a file inside a directory to list all files in the directory","Information");
            dlgBrowseFile.ShowDialog();

            ContainingFolder = dlgBrowseFile.FileName.Substring(0, dlgBrowseFile.FileName.LastIndexOf(@"\") + 1);
            edtFolder.Text = ContainingFolder;
        }

        private void edtFolder_TextChanged(object sender, EventArgs e)
        {
            lstbxFileinDirectory.Items.Clear();


            if (Directory.Exists(@edtFolder.Text))
            {
                DirectoryInfo d = new DirectoryInfo(@edtFolder.Text);
                FileInfo[] Files = d.GetFiles("*.*");
                foreach (FileInfo file in Files)
                {
                    lstbxFileinDirectory.Items.Add(file.Name);
                }
                lblFileCount.Text = "Total Files: " + Convert.ToString(lstbxFileinDirectory.Items.Count);
            }


        }

        private void lstbxFileinDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* string SelectedItem = lstbxFileinDirectory.SelectedItem.ToString();
            edtCurrentSelection.Text = SelectedItem.Substring(0, SelectedItem.LastIndexOf("."));*/
        }

        private void edtReplaceOriginal_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                edtReplaceEnd.Focus();
            }
        }

        private void edtReplaceEnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string org = edtReplaceOriginal.Text;
                string end = edtReplaceEnd.Text;



                lstbxCommands.Items.Add(org + ">" + end);
                edtReplaceOriginal.Text = "";
                edtReplaceEnd.Text = "";
                edtReplaceOriginal.Focus();
            }
        }

        private void removeCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstbxCommands.SelectedIndex > -1)
            {
                lstbxCommands.Items.RemoveAt(lstbxCommands.SelectedIndex);
            }
        }

        private void clearAllCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstbxCommands.Items.Clear();
        }

        private void lstbxCommands_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lstbxCommands.SelectedIndex > -1)
                {
                    lstbxCommands.Items.RemoveAt(lstbxCommands.SelectedIndex);
                }
            }
        }

        private void btnRunRenamer_Click(object sender, EventArgs e)
        {
            if (lstbxFileinDirectory.Items.Count == 0)
            {
                MessageBox.Show("No Files Available.", "Unable to Proceed");
                return;
            }

            if (lstbxCommands.Items.Count == 0)
            {
                MessageBox.Show("No Commands Were Specified.", "Unable to Proceed");
                return;
            }


            pnlLog.Visible = true;
            Log("Process Log");
            Log("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            workerRenamer.RunWorkerAsync();
        }

        private void edtReplaceOriginal_TextChanged(object sender, EventArgs e)
        {
            string Haystack = edtReplaceOriginal.Text;

            if (Haystack.Contains(@"\") || Haystack.Contains("/") || Haystack.Contains(":") || Haystack.Contains("*") || Haystack.Contains("?") || Haystack.Contains("\"") || Haystack.Contains("<") || Haystack.Contains(">") || Haystack.Contains("|"))
            {
                MessageBox.Show("A file name can't contain any of the following" + System.Environment.NewLine + @"\ " + "/ : * ? \" < > | ", "Error. Invalid Character.");
                edtReplaceOriginal.Text = edtReplaceOriginal.Text.Substring(0, edtReplaceOriginal.Text.Length - 1);
                edtReplaceOriginal.SelectionStart = edtReplaceOriginal.Text.Length;
                edtReplaceOriginal.SelectionLength = 0;
            }
        }

        private void edtReplaceEnd_TextChanged(object sender, EventArgs e)
        {
            string Haystack = edtReplaceEnd.Text;

            if (Haystack.Contains(@"\") || Haystack.Contains("/") || Haystack.Contains(":") || Haystack.Contains("*") || Haystack.Contains("?") || Haystack.Contains("\"") || Haystack.Contains("<") || Haystack.Contains(">") || Haystack.Contains("|"))
            {
                MessageBox.Show("A file name can't contain any of the following" + System.Environment.NewLine + @"\ " + "/ : * ? \" < > | ", "Error. Invalid Character.");
                edtReplaceEnd.Text = edtReplaceEnd.Text.Substring(0, edtReplaceEnd.Text.Length - 1);
                edtReplaceEnd.SelectionStart = edtReplaceEnd.Text.Length;
                edtReplaceEnd.SelectionLength = 0;
            }
        }

        private void Log(string sMsg)
        {
            redtLog.BeginInvoke(new Action(() =>
            {
                redtLog.AppendText("\r\n" + sMsg);
            }));
        }

        private string GetExtension(string FileName)
        {
            return FileName.Substring(FileName.LastIndexOf("."), FileName.Length);
        }

        private void btnCloseLog_Click(object sender, EventArgs e)
        {
            pnlLog.Visible = false;
            ClearSession();
        }

        private void ClearSession()
        {
            lstbxFileinDirectory.Items.Clear();
            lstbxCommands.Items.Clear();
            edtCurrentSelection.Text = "";
            edtReplaceOriginal.Text = "";
            edtReplaceEnd.Text = "";
            edtFolder.Text = "";
            redtLog.Clear();
            progressbarProgress.Value = 0;
            Log("Process Log");
            Log("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        private void workerRenamer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressbarProgress.Value = e.ProgressPercentage;
        }

        private void workerRenamer_DoWork(object sender, DoWorkEventArgs e)
        {
            string Org;
            string End;
            string CurrentItem;
            string OldFileName;
            string CurrentCommand;
            string LogMessage;
            string Extension = ".error";

            int ProgressTicker = (int)Math.Floor(100m / (lstbxFileinDirectory.Items.Count * lstbxCommands.Items.Count));
            int TotalProgress = 0;
            Log("Containing Folder: " + ContainingFolder + Environment.NewLine);
            for (int i = 0; i < lstbxFileinDirectory.Items.Count; i++)
            {
                CurrentItem = lstbxFileinDirectory.Items[i].ToString();
                OldFileName = CurrentItem;
                Extension = CurrentItem.Substring(CurrentItem.LastIndexOf("."), CurrentItem.Length - CurrentItem.LastIndexOf("."));
                CurrentItem = CurrentItem.Substring(0, CurrentItem.LastIndexOf("."));
                LogMessage = CurrentItem;

                for (int ii = 0; ii < lstbxCommands.Items.Count; ii++)
                {
                    CurrentCommand = lstbxCommands.Items[ii].ToString();
                    Org = CurrentCommand.Substring(0, CurrentCommand.IndexOf(">"));
                    End = CurrentCommand.Substring(CurrentCommand.IndexOf(">") + 1, (CurrentCommand.Length - (CurrentCommand.IndexOf(">") + 1)));


                    CurrentItem = CurrentItem.Replace(Org, End);
                    TotalProgress = TotalProgress + ProgressTicker;
                }
                try
                {
                    File.Move(Path.Combine(ContainingFolder, OldFileName), Path.Combine(ContainingFolder, CurrentItem + Extension));
                    LogMessage = LogMessage + " > " + CurrentItem;
                    Log(LogMessage);
                }
                catch (Exception exp)
                {
                    LogMessage = "ERROR:" + LogMessage + " > " + CurrentItem + Extension;
                    LogMessage = Environment.NewLine + exp.ToString();
                    Log(LogMessage);
                }
                workerRenamer.ReportProgress(TotalProgress);
            }
            workerRenamer.ReportProgress(100);
            Log(Environment.NewLine + "Rename Completed Successfully.");
        }

        private void removeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstbxFileinDirectory.SelectedIndex >= 0)
            {
                int Index = lstbxFileinDirectory.SelectedIndex ;
                edtCurrentSelection.Focus();
                lstbxFileinDirectory.Items.RemoveAt(Index);
                edtCurrentSelection.Text = "";
            }
        }

        private void clearListdeselectDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearSession();
        }

        private void lstbxFileinDirectory_Click(object sender, EventArgs e)
        {
            if (lstbxFileinDirectory.SelectedIndex >= 0)
            {
                string SelectedItem = lstbxFileinDirectory.SelectedItem.ToString();
                edtCurrentSelection.Text = SelectedItem.Substring(0, SelectedItem.LastIndexOf("."));
            }
            
        }

        private void lstbxFileinDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lstbxFileinDirectory.SelectedIndex >= 0)
                {
                    int Index = lstbxFileinDirectory.SelectedIndex;
                    edtCurrentSelection.Focus();
                    lstbxFileinDirectory.Items.RemoveAt(Index);
                    edtCurrentSelection.Text = "";
                }
            }
        }

        private void btnTempBtn_Click(object sender, EventArgs e)
        {
            frmAbout AboutPage = new frmAbout();
            AboutPage.Show();
        }
    }
}
