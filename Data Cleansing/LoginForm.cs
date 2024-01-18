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
    public partial class LoginForm : Form
    {
        MainForm mainForm = new MainForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Logged In");
            this.Hide();
            mainForm.Show();
            
        }
    }
}
