using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Data_Cleansing.DataCleanse
{
    public partial class F2Form : Form
    {

        Methods methods = new Methods();
        Boolean accordion1Expanded = false,
            accordion2Expanded = false,
            accordion3Expanded = false,
            accordion4Expanded = false,
            accordion5Expanded = false,
            accordion6Expanded = false,
            accordion7Expanded = false;

        public List<DataRow> Form2Datas { get; set; }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
          
        }



        public void ProcessRowData()
        {
            if (Form2Datas != null && Form2Datas.Count > 0)
            {
                foreach (DataRow row in Form2Datas)
                {
                    // Access the values in the DataRow
                    SeqNoReadOnlyTxt.Text = GetStringValue(row, "Collective_CLOA_Sequence_Number");
                    OctTctReadOnlyTxt.Text = GetStringValue(row, "OCT_TCT_Number");
                    CCLOANumReadOnlyTxt.Text = GetStringValue(row, "Collective_CLOA_Number");
                    CCLOADateReadOnlyTxt.Text = GetStringValue(row, "Collective_CLOA_Date_stration_mm_dd_yyyy");
                }
            }
            else
            {
                // Set default message when there is no data
                SeqNoReadOnlyTxt.Text = "No Data Encoded";
                OctTctReadOnlyTxt.Text = "No Data Encoded";
                CCLOANumReadOnlyTxt.Text = "No Data Encoded";
                CCLOADateReadOnlyTxt.Text = "No Data Encoded";
            }
        }

        private string GetStringValue(DataRow row, string columnName)
        {
            // Check if the column exists
            if (row.Table.Columns.Contains(columnName))
            {
                // Access the value in the DataRow
                object cellValue = row[columnName];

                // Return the cell value as a string or "No Data Encoded" if it's blank
                return (cellValue != DBNull.Value && !string.IsNullOrEmpty(cellValue.ToString()))
                    ? cellValue.ToString()
                    : "No Data Encoded";
            }

            // Return "No Data Encoded" if the column doesn't exist
            return "No Data Encoded";
        }



        private void F2Form_Load(object sender, EventArgs e)
        {
            SubmitBtn.Select();
        }

        public F2Form()
        {
            InitializeComponent();
        }

        private void AccorPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void ChevronPB_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = null;
            Panel panel = null;
            bool expanded = false;

            if (sender == Chevron1PB)
            {
                pictureBox = Chevron1PB;
                panel = AccorPanel1;
                expanded = accordion1Expanded;
                accordion1Expanded = !accordion1Expanded;
            }
            else if (sender == Chevron2PB)
            {
                pictureBox = Chevron2PB;
                panel = AccorPanel2;
                expanded = accordion2Expanded;
                accordion2Expanded = !accordion2Expanded;
            }
            else if (sender == Chevron3PB)
            {
                pictureBox = Chevron3PB;
                panel = AccorPanel3;
                expanded = accordion3Expanded;
                accordion3Expanded = !accordion3Expanded;
            }
            else if (sender == Chevron4PB)
            {
                pictureBox = Chevron4PB;
                panel = AccorPanel4;
                expanded = accordion4Expanded;
                accordion4Expanded = !accordion4Expanded;
            }
            else if (sender == Chevron5PB)
            {
                pictureBox = Chevron5PB;
                panel = AccorPanel5;
                expanded = accordion5Expanded;
                accordion5Expanded = !accordion5Expanded;
            }
            else if (sender == Chevron6PB)
            {
                pictureBox = Chevron6PB;
                panel = AccorPanel6;
                expanded = accordion6Expanded;
                accordion6Expanded = !accordion6Expanded;
            }
            else if (sender == Chevron7PB)
            {
                pictureBox = Chevron7PB;
                panel = AccorPanel7;
                expanded = accordion7Expanded;
                accordion7Expanded = !accordion7Expanded;
            }
  
            methods.Accordion(pictureBox, panel, expanded);
        }
    }
}
