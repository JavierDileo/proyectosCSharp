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

namespace _1842_DileoJavier_Parcial2
{
    public partial class Form1 : Form
    {
        string cadenaConexion = @"data source = DESKTOP-GAAOQ0U\SQLEXPRESS;initial catalog=BANCO;integrated security = SSPI";

        SqlConnection  cn; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConexion);
            cmb_cuotas.Items.Add("12");
            cmb_cuotas.Items.Add("24");
            cmb_cuotas.Items.Add("32");
            cmb_cuotas.Items.Add("48");

            cmb_sucursal.Items.Add("Palermo");
            cmb_sucursal.Items.Add("Villa Urquiza");
            cmb_sucursal.Items.Add("Pompeya");
            cmb_sucursal.Items.Add("Caballito");

            cmb_sucursal2.Items.Add("Palermo");
            cmb_sucursal2.Items.Add("Villa Urquiza");
            cmb_sucursal2.Items.Add("Pompeya");
            cmb_sucursal2.Items.Add("Caballito");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_apellido.Text == "" || txt_montoPrestamo.Text == "" || txt_numCliente.Text == "" )
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                cn.Open();
                SqlCommand comando = new SqlCommand("insert into prestamos (Nro_cliente, Apellido, Monto_prestamo,Cantidad_Cuotas,Sucursal)" +
                                                    " values (@numCli,@ape,@monto,@cuotas,@suc)", cn);

                comando.Parameters.AddWithValue("@numCli", txt_numCliente.Text);
                comando.Parameters.AddWithValue("@ape", txt_apellido.Text);
                comando.Parameters.AddWithValue("@monto", txt_montoPrestamo.Text);
                comando.Parameters.AddWithValue("@cuotas", Convert.ToInt32(cmb_cuotas.SelectedItem));
                comando.Parameters.AddWithValue("@suc", cmb_sucursal.SelectedIndex + 1);

                comando.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Datos ingresados correctamente");
            }
         
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_montoTotal.Text = "Monto TOTAL:";
            int montoTotal =0;
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter("select Monto_prestamo from prestamos where Sucursal = " + Convert.ToString(cmb_sucursal2.SelectedIndex+1) ,cn);
            da.Fill(dt);

            cn.Close();

            for(int i=0; i< dt.Rows.Count; i++)
            {
                montoTotal += Convert.ToInt32(dt.Rows[i][0]);
                
            }
            lbl_montoTotal.Text += " " + montoTotal.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_24Cuotas.Text = "Monto TOTAL 24 Cuotas:";
            int montoTotal24Cuotas = 0;
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter("select Monto_prestamo from prestamos where Cantidad_Cuotas = 24 " , cn);
            da.Fill(dt);

            cn.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                montoTotal24Cuotas += Convert.ToInt32(dt.Rows[i][0]);

            }
            lbl_24Cuotas.Text += " " + montoTotal24Cuotas.ToString();

        }
    }

}
