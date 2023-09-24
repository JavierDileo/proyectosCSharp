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
    public partial class Form1 : Form
    {
        string cadena = @"data source = DESKTOP-GAAOQ0U\SQLEXPRESS;initial catalog = Consultorio; integrated security = SSPI";
        SqlConnection cn;
        bool verif;
        int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadena);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            altaPacientes altP = new altaPacientes();
            altP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registroTurnos regTurn = new registroTurnos();
            regTurn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            medicos med = new medicos();
            med.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            verif = int.TryParse(txt_dni.Text, out num);

            if (verif == false)
            {
                MessageBox.Show("Ingrese solo números");
               txt_dni.Text = "";
            }
            else
            {
                SqlDataAdapter da; //declaracion dataAdapter
                DataTable dt = new DataTable(); // declaracion dataTable
                                                //DT GUARDA LOS REGISTROS EN LA MEMORIA
                cn.Open(); //conexion abierta

                da = new SqlDataAdapter("select * from pacientes where dni = " + txt_dni.Text, cn); //iniciar dataAdapter ejecucion de consultas
                da.Fill(dt);  //rellenar el dataTable

                cn.Close();// desconectar de la base de datos

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Paciente no registrado en la base de datos");
                }

                else
                {
                    if (Convert.ToString(dt.Rows[0][6]) == txt_dni.Text)
                    {

                        dataGridView1.DataSource = dt;
                    }

                }
            }

    
        }
    }
}
