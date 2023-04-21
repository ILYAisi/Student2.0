using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ExampleApp
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();

            loginField.Text = "Введите имя";
            loginField.ForeColor = Color.Gray;
        }

        

        private void CloseName_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите имя")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите имя";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname);", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            
                MessageBox.Show("Аккаунт был создан");
            
            else
            
                MessageBox.Show("Аккаунт не был создан");
            

            db.closeConnection();

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void fon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            string FileName = openFile.FileName;
            pictureBox1.ImageLocation = FileName;
        }
    }
}
