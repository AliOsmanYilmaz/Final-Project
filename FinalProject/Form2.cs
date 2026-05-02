using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Operators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;

        bool[] bools = new bool[8];
        Gender gender;
        enum Gender
        {
            Erkek,Kadın
        }


        public bool OnlyLetters(TextBox textBox)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^a-zA-ZçÇğĞıİöÖşŞüÜ]"))
            {
                MessageBox.Show("Please enter only letters.","ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                return false;
            }

            else if (textBox.Text.Length > 50)
            {
                MessageBox.Show("Maximum 50 characters allowed.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                return false;
            }

            else if (textBox.Text.Length == 0)
            {
                MessageBox.Show("This field cannot be empty.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                return true;
            }
        }
        public bool LoginCheck(TextBox textBox)
        {
            if(textBox.Text.Length > 50)
            {
                MessageBox.Show("Maximum 50 characters allowed.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                return false;
            }

            else if(textBox.Text.Length == 0)
            {
                MessageBox.Show("Minimum 1 characters allowed.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                return true;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmb_Field.Items.Add("Cardiology");
            cmb_Field.Items.Add("Neurology");
            cmb_Field.Items.Add("Pediatrics");
            cmb_Field.Items.Add("Orthopedics");
            cmb_Field.Items.Add("Dermatology");
            cmb_Field.Items.Add("Psychiatry");
            cmb_Field.Items.Add("Oncology");
            cmb_Field.Items.Add("Radiology");
            cmb_Field.Items.Add("Gastroenterology");
            cmb_Field.Items.Add("Endocrinology");
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            //Field
            if(cmb_Field.SelectedIndex != -1)
            {
                bools[7] = true;
            }
            else
            {
                MessageBox.Show("Please select a field.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bools[7] = false;
            }
            //Field

            //Age
            if (txt_Age.Text.Length > 0)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txt_Age.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Age.Text = txt_Age.Text.Remove(txt_Age.Text.Length - 1);
                    bools[4] = false;
                }
                else if (Convert.ToInt32(txt_Age.Text) < 18 || Convert.ToInt32(txt_Age.Text) > 80)
                {
                    MessageBox.Show("Age must be between 18 and 80.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Age.Text = txt_Age.Text.Remove(txt_Age.Text.Length - 1);
                    bools[4] = false;
                }
                else
                {
                    bools[4] = true;
                }
            }
            else
            {
                MessageBox.Show("This field cannot be empty.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bools[4] = false;
            }
            //Age

           
            foreach (bool item in bools)
            {
                if (item == false)
                {
                    MessageBox.Show("Please fill in all fields correctly.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

            //MySql 
            con = new MySqlConnection("server=localhost;username=yourUsername;password=yourPassword;");
            con.Open();
            cmd = new MySqlCommand("Insert Into hospital.doctors (name,surname,username,password,field,age,year,gender) Values(@name,@surname,@username,@password,@field,@age,@year,@gender)", con);
            cmd.Parameters.AddWithValue("@name",txt_Name.Text);
            cmd.Parameters.AddWithValue("@surname",txt_Surname.Text);
            cmd.Parameters.AddWithValue("@username", txt_Username.Text);
            cmd.Parameters.AddWithValue("@password", txt_Password.Text);
            cmd.Parameters.AddWithValue("@field", cmb_Field.Text);
            cmd.Parameters.AddWithValue("@age", txt_Age.Text);
            cmd.Parameters.AddWithValue("@year", txt_Year.Text);
            cmd.Parameters.AddWithValue("@gender", gender.ToString());

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if(OnlyLetters(txt_Name))
            {
                bools[0] = true;
            }
            else
            {
                bools[0] = false;
            }
        }

        private void txt_Surname_TextChanged(object sender, EventArgs e)
        {
            if(OnlyLetters(txt_Surname))
            {
                bools[1] = true;
            }
            else
            {
                bools[1] = false;
            }
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            if(LoginCheck(txt_Username))
            {
                bools[2] = true;
            }
            else
            {
                bools[2] = false;
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            if(LoginCheck(txt_Password))
            {
                bools[3] = true;
            }
            else
            {
                bools[3] = false;
            }
        }

        private void txt_Year_TextChanged(object sender, EventArgs e)
        {
            if (txt_Year.Text.Length > 0)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txt_Year.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Year.Text = txt_Year.Text.Remove(txt_Year.Text.Length - 1);
                    bools[5] = false;
                }

                else
                {
                    bools[5] = true;
                }
            }

            else
            {
                MessageBox.Show("Year field cannot be empty.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bools[5] = false;
            }
        }

        private void rb_Erkek_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Erkek.Checked)
            {
                gender = Gender.Erkek;
                bools[6] = true;
            }

            else if(rb_Kadin.Checked)
            {
                gender = Gender.Kadın;
                bools[6] = true;
            }

            else
            {
                MessageBox.Show("Please select a gender.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bools[6] = false;
            }
        }

        private void rb_Kadin_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Erkek.Checked)
            {
                gender = Gender.Erkek;
                bools[6] = true;
            }

            else if (rb_Kadin.Checked)
            {
                gender = Gender.Kadın;
                bools[6] = true;
            }

            else
            {
                MessageBox.Show("Please select a gender.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bools[6] = false;
            }
        }
    }
}
