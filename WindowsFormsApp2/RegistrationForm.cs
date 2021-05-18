using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class RegistrationForm : Form
    {
        public object MySqlcommand { get; private set; }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(NameBox.Text == "")//condition of fillinf of the field
            {
                MessageBox.Show("Type your name");
                return;
            }

            if (AdressBox.Text == "")//condition of fillinf of the field
            {
                MessageBox.Show("Type your adress");
                return;
            }

            if (PhoneBox.Text == "")//condition of fillinf of the field
            {
                MessageBox.Show("Type your phone number");
                return;
            }

            if (PassBox.Text == "")//condition of fillinf of the field
            {
                MessageBox.Show("Create a password");
                return;
            }

            if(checkUser())//condition of sameness of the passwords
            {
                MessageBox.Show("This password already exist \nCreate another password");
                return;
            }


            //creating acount for regestrated user

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user` (`id`, `name`, `adress`, `phone`, `password`) VALUES (NULL, @nam, @adr, @phon, @pass)", db.getConnection());

            command.Parameters.Add("@nam", MySqlDbType.VarChar).Value = NameBox.Text;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = AdressBox.Text;
            command.Parameters.Add("@phon", MySqlDbType.VarChar).Value = PhoneBox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassBox.Text;

            db.openConnection();

            if(command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Account was created");
                this.Hide();
                LoginForm registrationForm = new LoginForm();
                registrationForm.Show();
            }
            else
            {
                MessageBox.Show("Acoount wasn`t created");
            }



            db.closeConnection();
        }

        public bool checkUser()//checking of sameness
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `password` = @uP", db.getConnection());
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
