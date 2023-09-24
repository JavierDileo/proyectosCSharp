using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ateti
{
    public partial class Form2 : Form
    {
        int num1, num2, res;
        Random r = new Random();
        bool verif;
        int  num;
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_ok2_Click(object sender, EventArgs e)
        {
            verif = int.TryParse(txt_res2.Text, out num);

            if (verif == false)
            {
                MessageBox.Show("Ingrese solo números");
                txt_res2.Text = "";
            }
            else
            {
                res = Convert.ToInt32(txt_res2.Text);
                if (res == (num1 - num2))
                {
                    num1 = r.Next(101);
                    num2 = r.Next(101);
                    lbl_num5.Text = Convert.ToString(num1);
                    lbl_num6.Text = Convert.ToString(num2);

                }
            }
          
        }

        private void btn_ok3_Click(object sender, EventArgs e)
        {
            verif = int.TryParse(txt_res3.Text, out num);

            if (verif == false)
            {
                MessageBox.Show("Ingrese solo números");
                txt_res3.Text = "";
            }
            else
            {
                res = Convert.ToInt32(txt_res3.Text);
                if (res == (num1 * num2))
                {
                    num1 = r.Next(101);
                    num2 = r.Next(101);
                    lbl_num7.Text = Convert.ToString(num1);
                    lbl_num8.Text = Convert.ToString(num2);

                }
            }
            
        }

        private void btn_ok4_Click(object sender, EventArgs e)
        {

            verif = int.TryParse(txt_res4.Text, out num);

            if (verif == false)
            {
                MessageBox.Show("Ingrese solo números");
                txt_res4.Text = "";
            }
            else
            {
                res = Convert.ToInt32(txt_res4.Text);
                if (res == (num1 / num2))
                {
                    MessageBox.Show("GANASTE! VOLVE A JUGAR!");
                    btn_volverJugar.Enabled = true;

                }
            }
            
        }

        private void btn_volverJugar_Click(object sender, EventArgs e)
        {
            num1 = r.Next(101);
            num2 = r.Next(101);

            lbl_num1.Text = Convert.ToString(num1);
            lbl_num2.Text = Convert.ToString(num2);
            lbl_num3.Text = "?";
            lbl_num4.Text = "?";
            lbl_num5.Text = "?";
            lbl_num6.Text = "?";
            lbl_num7.Text = "?";
            lbl_num8.Text = "?";
            txt_res1.Text = "";
            txt_res2.Text = "";
            txt_res3.Text = "";
            txt_res4.Text = "";
            btn_volverJugar.Enabled = false;


        }

        private void Form2_Load(object sender, EventArgs e)
        {

            MessageBox.Show("INGRESE EL RESULTADO CORRECTO PARA DESBLOQUEAR EL SIGUIENTE NIVEL");
            num1 = r.Next(101);
            num2 = r.Next(101);

            lbl_num1.Text = Convert.ToString(num1 );
            lbl_num2.Text = Convert.ToString(num2);
            btn_volverJugar.Enabled = false;

           

          
        }

        private void btn_ok1_Click(object sender, EventArgs e)
        {
            verif = int.TryParse(txt_res1.Text, out num);

            if (verif == false)
            {
                MessageBox.Show("Ingrese solo números");
                txt_res1.Text = "";
            }
            else
            {
                res = Convert.ToInt32(txt_res1.Text);
                if (res == (num1 + num2))
                {
                    num1 = r.Next(101);
                    num2 = r.Next(101);
                    lbl_num3.Text = Convert.ToString(num1);
                    lbl_num4.Text = Convert.ToString(num2);

                }
            }
            
        }
    }
}
