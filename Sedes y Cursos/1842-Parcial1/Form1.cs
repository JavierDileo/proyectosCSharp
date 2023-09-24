using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1842_Parcial1
{
    public partial class Form1 : Form
    {
        int[,] matriz;
        int num;
        bool verif,verif2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int curso;
            curso = Convert.ToInt32(txt_consulta1Curso.Text);
            for (int i = 0; i < 3; i++)
            {
                
                    suma += matriz[curso - 1, i];
                
            }
            lbl_cons1Inscriptos.Text = "Total Inscriptos" + Environment.NewLine + suma;
            suma = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matriz = new int[5, 3];
        }

        private void btn_inscripcion_Click(object sender, EventArgs e)
        {
            int curso, sede;

            verif = int.TryParse(txt_sede.Text, out num);
            verif2 = int.TryParse(txt_curso.Text, out num);
            if (verif == false || verif2 == false)
            {
                MessageBox.Show("Ingrese numeros solo numeros");
                txt_sede.Text = "";
                txt_curso.Text = "";


            }
            else
            {
                
                sede = Convert.ToInt32(txt_sede.Text);

                curso = Convert.ToInt32(txt_curso.Text);

                if(sede >3 || curso > 5)
                {
                    MessageBox.Show("ingrese un numero valido" + Environment.NewLine+"Cursos del 1 al 5" + Environment.NewLine+"Sedes del 1 al 3");
                }
                else
                {

                    if (matriz[curso - 1, sede - 1] >= 10)
                    {
                        MessageBox.Show("Curso completo" + Environment.NewLine + "Elija otro curso");


                    }
                    else
                    {
                        matriz[curso - 1, sede - 1] += 1;
                        lbl_inscriptos.Text = "Inscriptos : " + matriz[curso - 1, sede - 1];
                    }
                }

            }
          


           
            
        }

        private void btn_cons2Sedes_Click(object sender, EventArgs e)
        {
            int[] vecsuma = { 0, 0, 0 };
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    vecsuma[i] += matriz[j, i];
                    
                }

            }
            lbl_capital.Text = "Total Capital " + vecsuma[0];
            lbl_sanisidro.Text = "Total San Isidro " + vecsuma[1];
            lbl_laplata.Text = "Total La Plata " + vecsuma[2];
        }
    }
}
