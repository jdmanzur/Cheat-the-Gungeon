using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;


namespace CheatEnterTheGungeon
{
    public partial class mainForm : Form
    {
        public static Mem m = new Mem();
        public mainForm()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelCheatsSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelCheatsSubMenu.Visible == true)
                panelCheatsSubMenu.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region subMenuCheats
        private void btnCheats_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCheatsSubMenu);
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            openChildForm(new moneyForm(m));
            //your codes

            hideSubMenu();
        }

        private void btnHealf_Click(object sender, EventArgs e)
        {

            openChildForm(new healfForm(m));
            //your codes

            hideSubMenu();

        }

        private void btnBlanks_Click(object sender, EventArgs e)
        {
            openChildForm(new blanksForm(m));
            hideSubMenu();
        }
        #endregion

        #region Help
        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            openChildForm(new helpForm());
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
          if (activeForm != null)
            activeForm.Close();
          activeForm = childForm;
          childForm.TopLevel = false;
          childForm.FormBorderStyle = FormBorderStyle.None;
          childForm.Dock = DockStyle.Fill;
          panelChildForm.Controls.Add(childForm);
          panelChildForm.Tag = childForm;
          childForm.BringToFront();
          childForm.Show();
        }

        public bool procOpen = false;

        private void processStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            procOpen = m.OpenProcess("EtG");

            Thread.Sleep(1000);

            processStatus.ReportProgress(0);
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            processStatus.RunWorkerAsync();
        }

        private void processStatus_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (procOpen)
            {
                labelProcessStatus.ForeColor = Color.Green;
                labelProcessStatus.Text = "Enter the Gungeon Encontrado";
            }
            else
            {
                labelProcessStatus.ForeColor = Color.DarkRed;
                labelProcessStatus.Text = "Enter the Gungeon Não Encontrado";
                return;
            }
        }

        private void processStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            processStatus.RunWorkerAsync();
        }
    }
}
