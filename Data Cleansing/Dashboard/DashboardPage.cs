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
    public partial class DashboardPage : UserControl
    {
        FormDesign formDesign = new FormDesign();
        SQLEngine sqlEngine = new SQLEngine();

        public DashboardPage()
        {
            InitializeComponent();

           // formDesign.InitializePanelWithBorderRadiusAndShadow(DashboardPanel1, 10, 5);
            //formDesign.InitializePanelWithBorderRadiusAndShadow(DashboardPanel2, 10, 5);
           // formDesign.InitializePanelWithBorderRadiusAndShadow(DashboardPanel3, 10, 5);
           // formDesign.InitializePanelWithBorderRadiusAndShadow(DashboardPanel4, 10, 5);
            //formDesign.InitializeProgressBarWithBorderRadius(progressBar1);
            double form1Value= Convert.ToDouble(sqlEngine.CountTotaleEncodedInForm("dbo.F1_Root"));
            double form2Value = Convert.ToDouble(sqlEngine.CountTotaleEncodedInForm("dbo.F2_Root"));
            double form3AValue = Convert.ToDouble(sqlEngine.CountTotaleEncodedInForm("dbo.F3A_Root"));
            double form3BValue = Convert.ToDouble(sqlEngine.CountTotaleEncodedInForm("dbo.F3B_Root"));

            int overviewTotalValue = Convert.ToInt32(form1Value + form2Value + form3AValue + form3BValue);

            solidGauge1.To = form1Value;
            solidGauge2.To = form2Value;
            solidGauge3.To = form3AValue;
            solidGauge4.To = form3BValue;

            progressBar1.Maximum = overviewTotalValue;

            overviewTotalLbl.Text = overviewTotalValue.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {

        }

  
    }
}
