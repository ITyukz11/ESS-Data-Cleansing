using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Data_Cleansing.DataCleanse;

namespace Data_Cleansing
{
    
    public partial class DataCleansePage : UserControl
    {

        
        SQLEngine sqlEngine = new SQLEngine();

        string SeqNo = ""; // For storing the selected SeqNo 

        //INITIALIZE THE 4 FORMS
        F1Form form1form = new F1Form();
        F2Form form2form = new F2Form();
        public DataCleansePage()
        {
            InitializeComponent();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            if (FilterCB.SelectedIndex == 0) dataGridView1.DataSource = sqlEngine.SearchData("dbo.F3A_Root", "Collective_CLOA_Sequence_Number", SearchTxt.Text);
            else dataGridView1.DataSource = sqlEngine.SearchData("dbo.F3A_Root", "Collective_CLOA_Number", SearchTxt.Text);

            //dataGridView1.DataSource = sqlEngine.SearchData("SELECT Collective_CLOA_Sequence_Number, OCT_TCT_Number, Collective_CLOA_Number, First_Name, Middle_Name, Last_Name FROM dbo.F3A_Root WHERE Collective_CLOA_Sequence_Number = "+SearchTxt.Text+"");
        }

        private void DataCleansePage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sqlEngine.SearchData("SELECT TOP 12 * FROM dbo.F3A_Root WHERE Collective_CLOA_Sequence_Number LIKE '11%';");
            Form1Btn.Enabled = false;
            Form2Btn.Enabled = false;
            Form3ABtn.Enabled = false;
            Form3BBtn.Enabled = false;

            FilterCB.SelectedIndex=0;
        }

  



        private void SeqNoTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               // dataGridView1.DataSource = sqlEngine.SearchData("dbo.F3A_Root", "Collective_CLOA_Sequence_Number", SeqNoTxt.Text);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Do nothing if header is clicked
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //Store seq no 
                SeqNo = dataGridView1[14, e.RowIndex].Value.ToString();
                CCLOASeqNumTxt.Text = dataGridView1[14, e.RowIndex].Value.ToString();
                OCTTCTNumTxt.Text = dataGridView1[15, e.RowIndex].Value.ToString();
                CCLOANumTxt.Text = dataGridView1[16, e.RowIndex].Value.ToString();

                FirstNameTxt.Text = dataGridView1[18, e.RowIndex].Value.ToString();
                LastNameTxt.Text = dataGridView1[20, e.RowIndex].Value.ToString();
                AreaTxt.Text = dataGridView1[22, e.RowIndex].Value.ToString();
            }
            if (SeqNo.Length != 0)
            {
               Form1Btn.Enabled = true;
               Form2Btn.Enabled = true;
               Form3ABtn.Enabled = true;
               Form3BBtn.Enabled = true;
            }
        }




        private void Form1Btn_Click(object sender, EventArgs e)
        {
            LoadDataToForms("dbo.F1_Root", "CCLOA_Seq_Num", form1form, form1form.Form1Datas);
        }
        private void Form2Btn_Click(object sender, EventArgs e)
        {
            LoadDataToForms("dbo.F2_Root", "Collective_CLOA_Sequence_Number", form2form, form2form.Form2Datas);
        }

        private void LoadDataToForms(string tableName, string column_name, Form form, List<DataRow> datas)
        {
            // parameterized query to prevent SQL injection
            DataTable resultTable = sqlEngine.SearchData($"SELECT * FROM {tableName} WHERE {column_name} = {SeqNo}");

            if (resultTable != null)
            {
                // Initialize datas if it's null
                if (datas == null)
                {
                    datas = new List<DataRow>();
                }

                // Map data
                foreach (DataRow row in resultTable.Rows)
                {
                    // Add the current row to the list
                    datas.Add(row);
                }

                // Process the data and show the form
                if (form != null)
                {
                    ProcessRowData(form, datas);
                }
                else
                {
                    // Handle the case where form is null
                    MessageBox.Show("Form is null.");
                }
            }
            else
            {
                // Handle the case where resultTable is null
                MessageBox.Show("No data available.");
            }
        }





        private void ProcessRowData(Form form, List<DataRow> datas)
        {
            // Adjust based on the specific form type
            if (form is F1Form form1)
            {
                form1.Form1Datas = datas;
                form1.ProcessRowData();
                form1.ShowDialog();
            }
            else if (form is F2Form form2)
            {
                form2.Form2Datas = datas;
                form2.ProcessRowData();
                form2.ShowDialog();
            }
           
        }
    }
}
