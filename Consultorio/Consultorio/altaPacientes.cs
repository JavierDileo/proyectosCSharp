using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Consultorio
{
    public partial class altaPacientes : Form
    {
        string cadena = @"data source = DESKTOP-GAAOQ0U\SQLEXPRESS;initial catalog = Consultorio; integrated security = SSPI";
        SqlConnection cn;
        public altaPacientes()
        {
            InitializeComponent();
        }

        private void btn_agregarPaciente_Click(object sender, EventArgs e)
        {
            if (rb_si.Checked == true)
            {
                cn.Open();
                SqlCommand com = new SqlCommand("insert into pacientes (nombre, apellido, telefono, direccion, edad, dni, obraSocial)" +
                                               "values(@nom,@ap,@tel,@dir,@edad,@dni,@os)", cn);
                com.Parameters.AddWithValue("@nom", txt_nom.Text);
                com.Parameters.AddWithValue("@ap", txt_apellido.Text);
                com.Parameters.AddWithValue("@tel", txt_tel.Text);
                com.Parameters.AddWithValue("@dir", txt_dire.Text);
                com.Parameters.AddWithValue("@edad", txt_edad.Text);
                com.Parameters.AddWithValue("@dni", txt_dni.Text);
                com.Parameters.AddWithValue("@os", 1);
                com.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Paciente agregado exitosamente");
            }
            else
            {
                if (rb_no.Checked == true)
                {
                    cn.Open();
                    SqlCommand com = new SqlCommand("insert into pacientes (nombre, apellido, telefono, direccion, edad, dni, obraSocial)" +
                                                   "values(@nom,@ap,@tel,@dir,@edad,@dni,@os)", cn);
                    com.Parameters.AddWithValue("@nom", txt_nom.Text);
                    com.Parameters.AddWithValue("@ap", txt_apellido.Text);
                    com.Parameters.AddWithValue("@tel", txt_tel.Text);
                    com.Parameters.AddWithValue("@dir", txt_dire.Text);
                    com.Parameters.AddWithValue("@edad", txt_edad.Text);
                    com.Parameters.AddWithValue("@dni", txt_dni.Text);
                    com.Parameters.AddWithValue("@os", 0);
                    com.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Paciente agregado exitosamente");
                }
            }

        }

        private void altaPacientes_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadena);
        }
    }
}
