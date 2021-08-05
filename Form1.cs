/*  Author:                 Yash Prajapati
    Last Date Modified:     Aug 4, 2021
    Description:            In this lab we are going to make the text editor, which will look like notepad.*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        #region Event Handlers
        
        private void NewFile()
        {
            textBox.Clear();
        }
        private void OpenDifferentFile()
        {

        }
        private void SaveFile()
        {

        }

        private void SaveAsFile()
        {

        }
        private void CopyFile()
        {

        }
        private void CutFile()
        {

        }
        private void PasteFile()
        {

        }
        private void HelpPage()
        {

        }

        private void ExitApplication()
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        
        private void fileNew_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        private void fileOpen_Click(object sender, EventArgs e)
        {
            OpenDifferentFile();
        }
        private void fileSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void fileSaveas_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }
        private void fileClose_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        private void fileExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
        private void editCopy_Click(object sender, EventArgs e)
        {
            CopyFile();
        }
        private void editCut_Click(object sender, EventArgs e)
        {
            CutFile();
        }
        private void editPaste_Click(object sender, EventArgs e)
        {
            PasteFile();
        }
        private void helpAbout_Click(object sender, EventArgs e)
        {
            HelpPage();
        }
    }
}
