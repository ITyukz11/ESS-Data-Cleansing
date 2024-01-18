using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Cleansing
{
    public partial class MainForm : Form
    {
      
        SQLEngine sqlEngine = new SQLEngine();

        public MainForm()
        {
            InitializeComponent();
            dataCleansePage1.Visible = false;
            dashboardPage1.Visible = true;
           // logsPage1.Visible = false;

            //MaterialSkin2
           /* var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.BlueGrey900,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.DeepOrange700,
                TextShade.WHITE
                );*/
           // F1solidGauge.From = 200;
           //// F1solidGauge.To = Convert.ToDouble(sqlEngine.CountTotaleEncodedInForm("dbo.F1_Root"));
           // F2solidGauge.To = Convert.ToDouble(sqlEngine.CountTotaleEncodedInForm("dbo.F2_Root"));
           // F3AsolidGauge.To = Convert.ToDouble(sqlEngine.CountTotaleEncodedInForm("dbo.F3A_Root"));
           // F3BsolidGauge.To = Convert.ToDouble(sqlEngine.CountTotaleEncodedInForm("dbo.F3B_Root"));

           // F1solidGauge.ForeColor = Color.White;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }






        private void dashboardPage1_Load_1(object sender, EventArgs e)
        {

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardPage1.Visible = true;
            
            dataCleansePage1.Visible = false;

            DashboardBtn.BackColor = Color.Gainsboro;
            DataCleanseBtn.BackColor = Color.Transparent;
            LogsBtn.BackColor = Color.Transparent;
            dashboardPage1.Select();
   
            PanelDashboard.BackColor = Color.FromArgb(40, 86, 182);
            PanelDataCleanse.BackColor = Color.Transparent;
            LogsBtn.BackColor = Color.Transparent;

        }

        private void DataCleanseBtn_Click(object sender, EventArgs e)
        {
            dataCleansePage1.Visible = true;
            dashboardPage1.Visible = false;

            DashboardBtn.BackColor = Color.Transparent;
            DataCleanseBtn.BackColor = Color.Gainsboro;
            LogsBtn.BackColor = Color.Transparent;

            PanelDashboard.BackColor = Color.Transparent;
            PanelDataCleanse.BackColor = Color.FromArgb(40, 86, 182);
            PanelLogs.BackColor = Color.Transparent;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void LogsBtn_Click(object sender, EventArgs e)
        {
            dataCleansePage1.Visible = false;
            dashboardPage1.Visible = false;

            DashboardBtn.BackColor = Color.Transparent;
            DataCleanseBtn.BackColor = Color.Transparent;
            LogsBtn.BackColor = Color.Gainsboro;

            PanelDashboard.BackColor = Color.Transparent;
            PanelDataCleanse.BackColor = Color.Transparent;
            PanelLogs.BackColor = Color.FromArgb(40, 86, 182);
        }
    }
}
