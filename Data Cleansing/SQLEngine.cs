using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Windows.Forms;

namespace Data_Cleansing
{
    internal class SQLEngine

    {
 
        SqlConnection conn = new SqlConnection(@"Server=mssql-160792-0.cloudclusters.net,14693;Database=split_dar_db;User Id=Admin;Password=darroSplit12");


        public string CountTotaleEncodedInForm(string table_name)
        {
            string CountF1 = "";

            try
                 
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM " + table_name;
                SqlCommand cmd = new SqlCommand(query, conn);

                // Use ExecuteScalar to retrieve a single value
                object result = cmd.ExecuteScalar();

                // Check if the result is not null before converting to string
                if (result != null)
                {
                    // Format the number with commas
                    CountF1 = string.Format("{0:#,0}", result);
                    // Alternatively, you can use string interpolation in C# 6 and later:
                    // CountF1 = $"{result:#,0}";
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return CountF1;
        }


        public DataTable SearchData(string table_name, string column_name, string search_qry)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                // Your SQL query
                string qry = "SELECT * FROM "+ table_name + " WHERE "+ column_name + " LIKE '"+ search_qry + "%'";

                using (SqlDataAdapter adapter = new SqlDataAdapter(qry, conn))
                {
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public DataTable SearchData(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                // Your SQL query
                string qry = query;

                using (SqlDataAdapter adapter = new SqlDataAdapter(qry, conn))
                {
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

  

    }
}
