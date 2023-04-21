using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Windows.Forms;

namespace ExampleApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CloseName_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void vxod_Click_1(object sender, EventArgs e)
        {

            string loginUser = loginField.Text;
            string passUser = PassField.Text;

            DB db = new DB();
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @uL AND `pass` = @uP", db.getConnection());

            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string login = dt.Rows[0]["Login"].ToString();
                string pass = dt.Rows[0]["Pass"].ToString();

                this.Hide();
                avtor form = new avtor(login, pass);
                form.Show();
            }
            else if (loginUser == "Admin" && passUser == "Admin")
            {
                this.Hide();
                Next form = new Next();
                form.Show();
            }
            else
                MessageBox.Show("Ошибка");





        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registr_Click(object sender, EventArgs e)
        {
            RegistrForm form = new RegistrForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrForm form = new RegistrForm();
            form.ShowDialog();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Autorizlabel_Click(object sender, EventArgs e)
        {

        }

        private void ico2_Click(object sender, EventArgs e)
        {

        }
    }
}
