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

namespace FinalProject
{
    public partial class Form1 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server=localhost;username=yourUsername;password=yourPassword;");
            con.Open();

            cmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS Hospital", con);
            cmd.ExecuteNonQuery();
            con.Close();
             
            con.Open();
            cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS Hospital.Doctors (id INT PRIMARY KEY AUTO_INCREMENT, name VARCHAR(50),surname VARCHAR(50) ,username VARCHAR(50),password VARCHAR(50),field VARCHAR(50),age INT,year INT,gender VARCHAR(10))", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text.Trim();
            string password = txt_Password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!");
                return;
            }

            try
            {
                con.Open();

                string query = "SELECT username, password FROM hospital.doctors " +
                               "WHERE username = @username AND password = @password";

                da = new MySqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@username", username);
                da.SelectCommand.Parameters.AddWithValue("@password", password);

                DataTable dt = new DataTable();
                da.Fill(dt);

                

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful! Welcome!: " + username, "WELCOME!", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message,"ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
