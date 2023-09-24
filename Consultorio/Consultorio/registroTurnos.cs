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
    public partial class registroTurnos : Form
    {
        string cadena = @"data source = DESKTOP-GAAOQ0U\SQLEXPRESS;initial catalog = Consultorio; integrated security = SSPI";
        SqlConnection cn;
        
        public registroTurnos()
        {
            InitializeComponent();
        }

        private void registroTurnos_Load(object sender, EventArgs e)
        {
            
            cn = new SqlConnection(cadena);

            SqlDataAdapter da; 
            DataTable dt = new DataTable(); 
         
            cn.Open(); 

            da = new SqlDataAdapter("select especialidad from medicos", cn); 
            da.Fill(dt);  

            cn.Close();
           

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_medicos.Items.Add(Convert.ToString(dt.Rows[i][0]));
                
            }

        }

        private void btn_medico_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();

            da = new SqlDataAdapter("select especialidad, idMedico from Medicos where especialidad = '" + cmb_medicos.SelectedItem +"'" , cn);
            da.Fill(dt);

            cn.Close();

            dataGridViewMedico.DataSource = dt;
        }

        private void btn_paciente_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();

            da = new SqlDataAdapter("select idPaciente, dni from pacientes where dni = " + txt_dni.Text  , cn);
            da.Fill(dt);

            cn.Close();

            dataGridViewPaciente.DataSource = dt;
        }
    }
}
