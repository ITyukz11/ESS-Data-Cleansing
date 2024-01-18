using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Cleansing.DataCleanse
{
    public partial class F1Form : Form
    {

        Boolean accordion1Expanded = false, 
                accordion2Expanded = false,
                accordion3Expanded = false, 
                accordion4Expanded = false,
                accordion5Expanded = false,
                accordion6Expanded = false,
                accordion7Expanded = false,
                accordion8Expanded = false,
                accordion9Expanded = false;

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        Methods methods = new Methods();
        public List<DataRow> Form1Datas { get; set; } = new List<DataRow>();

        public F1Form()
        {
            InitializeComponent();
     

            this.MaximizeBox = false;
        }

        public void ProcessRowData()
        {
            if (Form1Datas != null && Form1Datas.Count > 0)
            {
                // Access the values in the DataRow
                foreach (DataRow row in Form1Datas)
                {
                    
                     if (GetStringValue(row, "CCLOA_Seq_Num") != "") InitializedData(SeqNoReadOnlyTxt, row, "CCLOA_Seq_Num");                                
                     else NoDataEncoded(SeqNoReadOnlyTxt); 
                             
                     if (GetStringValue(row, "OCT_TCT_Number") != null) InitializedData(OctTctReadOnlyTxt, row, "OCT_TCT_Number");
                     else NoDataEncoded(OctTctReadOnlyTxt);

                     if (GetStringValue(row, "CCLOA_Num") != null) InitializedData(CCLOANumReadOnlyTxt, row, "CCLOA_Num");
                     else NoDataEncoded(CCLOANumReadOnlyTxt);

                     if (GetStringValue(row, "Collective_CLOA_Date_stration_mm_dd_yyyy") != null) InitializedData(OctTctReadOnlyTxt, row, "Collective_CLOA_Date_stration_mm_dd_yyyy");
                     else NoDataEncoded(CCLOADateReadOnlyTxt);


                     //Projection Maps from NAMRIA/Certification/Approved Subdivision Plan 
                     if (GetStringValue(row, "Maps_ASP") != null) InitializedData(Maps_ASPReadOnlyTxt, row, "Maps_ASP");
                     else NoDataEncoded(Maps_ASPReadOnlyTxt);   

                     if (GetStringValue(row, "NAMRIA_Certification") != null) InitializedData(NAMRIACertReadOnlyTxt, row, "NAMRIA_Certification");
                     else NoDataEncoded(NAMRIACertReadOnlyTxt);

                     if (GetStringValue(row, "Date_of_Certification") != null) InitializedData(DateCertReadOnlyTxt, row, "Date_of_Certification");
                     else NoDataEncoded(DateCertReadOnlyTxt);   

                     //Legal Status of CCLOA

                     if (GetStringValue(row, "Does_the_CCLOA_have_pending_ca") != null) InitializedData(CCLOAPendingReadOnlyTxt, row, "Does_the_CCLOA_have_pending_ca");
                     else NoDataEncoded(CCLOAPendingReadOnlyTxt);

                    //I. Technical Description/Location
                    if (GetStringValue(row, "Municipal") != null) InitializedData(MunicipalityReadOnlyTxt, row, "Municipal");
                    else NoDataEncoded(MunicipalityReadOnlyTxt);

                    //II. Assessment of Collective CLOA for Overlaps
                    if (GetStringValue(row, "Forest_Lands") != null) InitializedData(ForestLandsReadOnlyTxt, row, "Forest_Lands");
                    else NoDataEncoded(ForestLandsReadOnlyTxt);

                    if (GetStringValue(row, "_2_Protected_Areas_National_P") != null) InitializedData(ProtAreaReadOnlyTxt, row, "_2_Protected_Areas_National_P");
                    else NoDataEncoded(ProtAreaReadOnlyTxt);

                    if (GetStringValue(row, "_3_Cultural_Heritage_and_or_Na") != null) InitializedData(CultureHeriReadOnlyTxt, row, "_3_Cultural_Heritage_and_or_Na");
                    else NoDataEncoded(CultureHeriReadOnlyTxt);

                    if (GetStringValue(row, "Ancestral_Domain") != null) InitializedData(AncenstralDomReadOnlyTxt, row, "Ancestral_Domain");
                    else NoDataEncoded(AncenstralDomReadOnlyTxt);

                    //III. ARB and CCLOA
                    if (GetStringValue(row, "Total_number_of_ARB_organizations") != null) InitializedData(TotalNoARBReadOnlyTxt, row, "Total_number_of_ARB_organizations");
                    else NoDataEncoded(TotalNoARBReadOnlyTxt);

                    if (GetStringValue(row, "Are_the_ARBs_members_f_the_organization_s") != null) InitializedData(AreArbOrgReadOnlyTxt, row, "Are_the_ARBs_members_f_the_organization_s");
                    else NoDataEncoded(AreArbOrgReadOnlyTxt);

                    //Government Support Services
                    if (GetStringValue(row, "Is_the_Collective_CLOA_area_cu") != null) InitializedData(GSS1ReadOnlyTxt, row, "Is_the_Collective_CLOA_area_cu");
                    else NoDataEncoded(GSS1ReadOnlyTxt);

                    //Prepared by
                    if (GetStringValue(row, "DARPO_ESS_Support_Organic") != null) InitializedData(PrepBy1ReadOnlyTxt, row, "DARPO_ESS_Support_Organic");
                    else NoDataEncoded(PrepBy1ReadOnlyTxt);

                    if (GetStringValue(row, "Upload_a_copy_of_your_e_signat_001") != null) InitializedData(PrepBy2ReadOnlyTxt, row, "Upload_a_copy_of_your_e_signat_001");
                    else NoDataEncoded(PrepBy2ReadOnlyTxt);

                    if (GetStringValue(row, "Upload_a_photo_of_your_Officia_001") != null) InitializedData(PrepBy3ReadOnlyTxt, row, "Upload_a_photo_of_your_Officia_001");
                    else NoDataEncoded(PrepBy3ReadOnlyTxt);
                    
                }
            }
            else
            {
                NoDataEncoded(SeqNoReadOnlyTxt);
                NoDataEncoded(OctTctReadOnlyTxt);
                NoDataEncoded(CCLOANumReadOnlyTxt);
                NoDataEncoded(CCLOADateReadOnlyTxt);
                
                NoDataEncoded(Maps_ASPReadOnlyTxt);
                NoDataEncoded(NAMRIACertReadOnlyTxt);
                NoDataEncoded(DateCertReadOnlyTxt);
                NoDataEncoded(CCLOAPendingReadOnlyTxt);

                NoDataEncoded(MunicipalityReadOnlyTxt);

                NoDataEncoded(ForestLandsReadOnlyTxt);
                NoDataEncoded(ProtAreaReadOnlyTxt);
                NoDataEncoded(CultureHeriReadOnlyTxt);
                NoDataEncoded(AncenstralDomReadOnlyTxt);

                NoDataEncoded(TotalNoARBReadOnlyTxt);
                NoDataEncoded(AreArbOrgReadOnlyTxt);

                NoDataEncoded(GSS1ReadOnlyTxt);

                NoDataEncoded(PrepBy1ReadOnlyTxt);
                NoDataEncoded(PrepBy2ReadOnlyTxt);
                NoDataEncoded(PrepBy3ReadOnlyTxt);

            }
        }


        private void NoDataEncoded(TextBox textbox)
        {
            // Set default message when there is no data and color red
            textbox.Text = "No Data Encoded!";
            textbox.BackColor = textbox.BackColor;
            textbox.ForeColor = Color.Red;
        }
        private void InitializedData(TextBox textbox, DataRow row, string column_name)
        {
            textbox.Text = GetStringValue(row, column_name);
            textbox.ForeColor = Color.Black;
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
            else if (sender == Chevron8PB)
            {
                pictureBox = Chevron8PB;
                panel = AccorPanel8;
                expanded = accordion8Expanded;
                accordion8Expanded = !accordion8Expanded;
            }
            else if (sender == Chevron9PB)
            {
                pictureBox = Chevron9PB;
                panel = AccorPanel9;
                expanded = accordion9Expanded;
                accordion9Expanded = !accordion9Expanded;
            }

            methods.Accordion(pictureBox, panel, expanded);
        }

      


    }

}
