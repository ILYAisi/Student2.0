using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleApp
{
    public partial class avtor : Form
    {
        public avtor()
        {
            InitializeComponent();
        }

        private void Autorizlabel_Click(object sender, EventArgs e)
        {

        }

        public avtor(string loginUser, string passUser)
        {
            InitializeComponent();
            IsLogin.Text = loginUser;
            IsPass.Text = passUser;
        }

        private void IsLogin_Click(object sender, EventArgs e)
        {

        }

        private void CloseName_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
