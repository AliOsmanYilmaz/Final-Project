using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TextBox = System.Windows.Forms.TextBox;

namespace FinalProject
{
    public partial class Form3 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds;

        int index;

        bool[] bools = new bool[6];

        Gender gender;
        enum Gender
        {
            Erkek, Kadın
        }

        public bool DeletePatient()
        {
            if (con.State != ConnectionState.Open) con.Open();

            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (dataGridView1.SelectedRows[0].IsNewRow)
                    {
                        MessageBox.Show("Please choose a row!","ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return false;
                    }

                    index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                    MySqlCommand cmd = new MySqlCommand("Delete From hospital.patients where id = @id;", con);
                    cmd.Parameters.AddWithValue("@id", index);

                    cmd.ExecuteNonQuery();
                    return true;
                }

                else
                {
                    MessageBox.Show("Please select a patient!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                MySql();
                con.Close();
            }
        }

        public void MySql()
        {
            if (con.State != ConnectionState.Open) con.Open();

            da = new MySqlDataAdapter("Select * from hospital.patients", con);
            ds = new DataSet();
            da.Fill(ds, "patients");
            dataGridView1.DataSource = ds.Tables["patients"];
        }

        public bool OnlyLetters(TextBox textBox)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^a-zA-ZçÇğĞıİöÖşŞüÜ]"))
            {
                MessageBox.Show("Please enter only letters.");
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                return false;
            }

            else if (textBox.Text.Length > 50)
            {
                MessageBox.Show("Maximum 50 characters allowed.");
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                return false;
            }

            else
            {
                return true;
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmb_Yonlendir.Items.Add("Mehmet Türk");
            cmb_Yonlendir.Items.Add("Mustafa Kut");
            cmb_Yonlendir.Items.Add("Enver Kurt");
            cmb_Yonlendir.Items.Add("Fatih Bozkurt");

            cmb_Illness.Items.Add("Cardiology");
            cmb_Illness.Items.Add("Neurology");
            cmb_Illness.Items.Add("Pediatrics");
            cmb_Illness.Items.Add("Orthopedics");
            cmb_Illness.Items.Add("Dermatology");
            cmb_Illness.Items.Add("Psychiatry");
            cmb_Illness.Items.Add("Oncology");
            cmb_Illness.Items.Add("Radiology");
            cmb_Illness.Items.Add("Gastroenterology");
            cmb_Illness.Items.Add("Endocrinology");

            cmb_Medicine.Items.Add("Metoprolol");
            cmb_Medicine.Items.Add("Levetiracetam");
            cmb_Medicine.Items.Add("Amoksisilin");
            cmb_Medicine.Items.Add("İbuprofen");
            cmb_Medicine.Items.Add("Tretinoin");
            cmb_Medicine.Items.Add("Sertralin");
            cmb_Medicine.Items.Add("Tamoksifen");
            cmb_Medicine.Items.Add("Gadolinyum");
            cmb_Medicine.Items.Add("Omeprazol");
            cmb_Medicine.Items.Add("Metformin");

            cmb_IlacGuncelle.Items.Add("Metoprolol");
            cmb_IlacGuncelle.Items.Add("Levetiracetam");
            cmb_IlacGuncelle.Items.Add("Amoksisilin");
            cmb_IlacGuncelle.Items.Add("İbuprofen");
            cmb_IlacGuncelle.Items.Add("Tretinoin");
            cmb_IlacGuncelle.Items.Add("Sertralin");
            cmb_IlacGuncelle.Items.Add("Tamoksifen");
            cmb_IlacGuncelle.Items.Add("Gadolinyum");
            cmb_IlacGuncelle.Items.Add("Omeprazol");
            cmb_IlacGuncelle.Items.Add("Metformin");

            con = new MySqlConnection("server=localhost;username=root;password=1234;");
            con.Open();

            cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS Hospital.patients(id INT PRIMARY KEY AUTO_INCREMENT, name VARCHAR(50), surname VARCHAR(50), age Int, gender VARCHAR(10), illness Varchar(50),time Datetime, medicine Varchar(50),report varchar(200))", con);
            cmd.ExecuteNonQuery();
            con.Close();

            MySql();
        }

        private void btn_HastaEkle_Click(object sender, EventArgs e)
        {
            // 1. Ad Kontrolü (0. indeks)
            if (!string.IsNullOrWhiteSpace(txt_Name.Text) && OnlyLetters(txt_Name))
                bools[0] = true;
            else bools[0] = false;

            // 2. Soyad Kontrolü (1. indeks)
            if (!string.IsNullOrWhiteSpace(txt_Surname.Text) && OnlyLetters(txt_Surname))
                bools[1] = true;
            else bools[1] = false;

            // 3. Cinsiyet Kontrolü (2. indeks)
            if (rb_Erkek.Checked || rb_Kadin.Checked)
                bools[2] = true;
            else
            {
                bools[2] = false;
                MessageBox.Show("Please select a gender.");
            }


            // 4. Yaş Kontrolü (3. indeks)
            if (!string.IsNullOrWhiteSpace(txt_Age.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txt_Age.Text, "[^0-9]"))
                bools[3] = true;
            else
                bools[3] = false;


            // 5. Hastalık Seçimi (4. indeks)
            bools[4] = (cmb_Illness.SelectedIndex != -1);

            // 6. Rapor Uzunluğu (5. indeks)
            bools[5] = (rtb_Report.Text.Length <= 200);

            
            
            foreach (bool item in bools)
            {
                if (item == false)
                {
                    MessageBox.Show("Please fill in all fields correctly.");
                    return;
                }
            }


            if (con.State != ConnectionState.Open) con.Open();
            cmd = new MySqlCommand("Insert Into Hospital.patients (name,surname,age,gender,illness,time,medicine,report) Values (@name,@surname,@age,@gender,@illness,@time,@medicine,@report)", con);
            cmd.Parameters.AddWithValue("@name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@surname", txt_Surname.Text);
            cmd.Parameters.AddWithValue("@age", txt_Age.Text);
            cmd.Parameters.AddWithValue("@gender", gender.ToString());
            cmd.Parameters.AddWithValue("@illness", cmb_Illness.Text);
            cmd.Parameters.AddWithValue("@time", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@medicine", cmb_Medicine.Text);
            cmd.Parameters.AddWithValue("@report", rtb_Report.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MySql();
        }
        
        private void rb_Erkek_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Erkek.Checked)
            {
                gender = Gender.Erkek;
            }

            else
            {
                gender = Gender.Kadın;
            }
        }

        private void rb_Kadin_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Erkek.Checked)
            {
                gender = Gender.Erkek;
            }

            else
            {
                gender = Gender.Kadın;
                
            }
        }

        private void btn_Yonlendir_Click(object sender, EventArgs e)
        {
            if (cmb_Yonlendir.Text != "")
            {
                if(DeletePatient())
                {
                    MessageBox.Show("The patient was referred to the doctor", "SUCCESSFUL!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                
            }
            else MessageBox.Show("Please choose a doctor!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_IlacGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 ||
            dataGridView1.SelectedRows[0].Cells["id"].Value == null ||
            dataGridView1.SelectedRows[0].Cells["id"].Value == DBNull.Value)
            {
                MessageBox.Show("Please select a patient!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmb_IlacGuncelle.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a medicine!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            try
            {
                if (con.State != ConnectionState.Open) con.Open();

                cmd = new MySqlCommand("UPDATE hospital.patients SET medicine = @medicine WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@medicine", cmb_IlacGuncelle.Text);
                cmd.Parameters.AddWithValue("@id", index);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Medicine was updated!", "SUCCESSFUL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MySql();
                con.Close();
            }

        }

        private void btn_RaporGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 ||
            dataGridView1.SelectedRows[0].Cells["id"].Value == null ||
            dataGridView1.SelectedRows[0].Cells["id"].Value == DBNull.Value)
            {
                MessageBox.Show("Please select a patient!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(rtb_RaporGuncelle.Text))
            {
                MessageBox.Show("Please enter report!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rtb_RaporGuncelle.Text.Length > 200)
            {
                MessageBox.Show("The report can be a maximum of 200 characters!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            try
            {
                if (con.State != ConnectionState.Open) con.Open();

                cmd = new MySqlCommand("UPDATE hospital.patients SET report = @report WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@report", rtb_RaporGuncelle.Text);
                cmd.Parameters.AddWithValue("@id", index);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Report was updated!", "SUCCESSFUL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MySql();
                con.Close();
            }
        }

        private void btn_RandevuGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 ||
            dataGridView1.SelectedRows[0].Cells["id"].Value == null ||
            dataGridView1.SelectedRows[0].Cells["id"].Value == DBNull.Value)
            {
                MessageBox.Show("Please select a patient!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            try
            {
                if (con.State != ConnectionState.Open) con.Open();

                cmd = new MySqlCommand("UPDATE hospital.patients SET time = @time WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@time", dtp_RandevuGuncelle.Value);
                cmd.Parameters.AddWithValue("@id", index);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Report was updated!", "SUCCESSFUL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MySql();
                con.Close();
            }
        }

        private void btn_HastaSil_Click(object sender, EventArgs e)
        {
            DeletePatient();
        }



    }
}
