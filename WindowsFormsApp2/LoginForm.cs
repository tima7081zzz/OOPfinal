using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Restaurant;

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // reading user information

            DB db = new DB();
            String passUser = passField.Text;
            String passAdmin;
            db.openConnection();
            MySqlCommand reqest = new MySqlCommand("SELECT password FROM `user` WHERE `id` = 2", db.getConnection());
            passAdmin = reqest.ExecuteScalar().ToString();
            db.closeConnection();


            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `password` = @uP", db.getConnection());
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count>0)// condition when user was found 
            {
                if(passUser == passAdmin)
                {
                    this.Hide();
                    AdminForm admin_form = new AdminForm();
                    admin_form.Show();
                }
                else
                {
                    this.Hide();
                    Menu menu_form = new Menu();
                    menu_form.Show();
                }
            }
            else // user wasnt found
            {
                MessageBox.Show("There is no user with this password!");
            }
        }
        private void registrLabel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm(); //going to another form
            registrationForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
