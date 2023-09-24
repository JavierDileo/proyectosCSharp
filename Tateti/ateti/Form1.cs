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
    public partial class Form1 : Form
    {
        int pos = 1;
        int[,] matriz = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int empate = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            radioButton1.Text = "";
            radioButton2.Text = "";
            radioButton1.Checked = true;
            panel1.Visible = false;


        }

        private void btn_nombres_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="" || textBox2.Text == "")
            {
                MessageBox.Show("Ingrese los nombres por favor.");
            }
            else
            {
                radioButton1.Text = textBox1.Text;
                radioButton2.Text = textBox2.Text;
                panel1.Visible = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {

                button1.Text = "O";
                matriz[0, 0] = 1;
                button1.Enabled = false;
            }

            if (radioButton2.Checked)
            {

                button1.Text = "X";
                matriz[0, 0] = 2;
                button1.Enabled = false;
            }
            jugador();
            ganador();
            iguales();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                button2.Text = "O";
                matriz[0, 1] = 1;
                button2.Enabled = false;
            }
            if (radioButton2.Checked)
            {
                button2.Text = "X";
                matriz[0, 1] = 2;
                button2.Enabled = false;
            }
            jugador();
            ganador();
            iguales();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button3.Text = "O";
                matriz[0, 2] = 1;
                button3.Enabled = false;
            }
            if (radioButton2.Checked)
            {
                button3.Text = "X";
                matriz[0, 2] = 2;
                button3.Enabled = false;
            }
            jugador();
            ganador();
            iguales();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button4.Text = "O";
                matriz[1, 0] = 1;
                button4.Enabled = false;
            }
            if (radioButton2.Checked)
            {
                button4.Text = "X";
                matriz[1, 0] = 2;
                button4.Enabled = false;
            }
            jugador();
            ganador();
            iguales();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button5.Text = "O";
                matriz[1, 1] = 1;
                button5.Enabled = false;
            }
            if (radioButton2.Checked)
            {
                button5.Text = "X";
                matriz[1, 1] = 2;
                button5.Enabled = false;
            }
            jugador();
            ganador();
            iguales();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button6.Text = "O";
                matriz[1, 2] = 1;
                button6.Enabled = false;
            }
            if (radioButton2.Checked)
            {
                button6.Text = "X";
                matriz[1, 2] = 2;
                button6.Enabled = false;
            }
            jugador();
            ganador();
            iguales();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button7.Text = "O";
                matriz[2, 0] = 1;
                button7.Enabled = false;
            }
            if (radioButton2.Checked)
            {
                button7.Text = "X";
                matriz[2, 0] = 2;
                button7.Enabled = false;
            }
            jugador();
            ganador();
            iguales();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button8.Text = "O";
                matriz[2, 1] = 1;
                button8.Enabled = false;
            }
            if (radioButton2.Checked)
            {
                button8.Text = "X";
                matriz[2, 1] = 2;
                button8.Enabled = false;
            }
            jugador();
            ganador();
            iguales();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button9.Text = "O";
                matriz[2, 2] = 1;
                button9.Enabled = false;

            }
            if (radioButton2.Checked)
            {
                button9.Text = "X";
                matriz[2, 2] = 2;
                button9.Enabled = false;
            }
            jugador();
            ganador();
            iguales();
        }

        void jugador()
        {
            if (pos % 2 == 0)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            pos++;

        }
        void iguales()
        {
            if(button1.Enabled == false  && button2.Enabled == false &&button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false && empate != 1 )
            {
                MessageBox.Show("EMPATE! VUELVAN A JUGAR =)");
            }
        }

        void ganador()
        {
            
            if (matriz[0, 0] == 1 && matriz[0, 1] == 1 && matriz[0, 2] == 1)
            {
                MessageBox.Show("GANADOR CIRCULO " + radioButton1.Text);
                empate = 1;
            }
            else
            {
                if (matriz[0, 0] == 2 && matriz[0, 1] == 2 && matriz[0, 2] == 2)
                {
                    MessageBox.Show("GANADOR CRUZ " + radioButton2.Text);
                    empate = 1;
                }
            }

            if (matriz[1, 0] == 1 && matriz[1, 1] == 1 && matriz[1, 2] == 1)
            {
                MessageBox.Show("GANADOR CIRCULO " + radioButton1.Text);
                empate = 1;
            }
            else
            {
                if (matriz[1, 0] == 2 && matriz[1, 1] == 2 && matriz[1, 2] == 2)
                {
                    MessageBox.Show("GANADOR  CRUZ " + radioButton2.Text);
                    empate = 1;
                }
            }


            if (matriz[2, 0] == 1 && matriz[2, 1] == 1 && matriz[2, 2] == 1)
            {
                MessageBox.Show("GANADOR CIRCULO " + radioButton1.Text);
                empate = 1;
            }
            else
            {
                if (matriz[2, 0] == 2 && matriz[2, 1] == 2 && matriz[2, 2] == 2)
                {
                    MessageBox.Show("GANADOR CRUZ " + radioButton2.Text);
                    empate = 1;
                }
            }


            if (matriz[0, 0] == 1 && matriz[1, 1] == 1 && matriz[2, 2] == 1)
            {
                MessageBox.Show("GANADOR CIRCULO " + radioButton1.Text);
                empate = 1;
            }
            else
            {
                if (matriz[0, 0] == 2 && matriz[1, 1] == 2 && matriz[2, 2] == 2)
                {
                    MessageBox.Show("GANADOR CRUZ " + radioButton2.Text);
                    empate = 1;
                }
            }

            if (matriz[2, 0] == 1 && matriz[1, 1] == 1 && matriz[0, 2] == 1)
            {
                MessageBox.Show("GANADOR CIRCULO " + radioButton1.Text);
                empate = 1;
            }
            else
            {
                if (matriz[2, 0] == 2 && matriz[1, 1] == 2 && matriz[0, 2] == 2)
                {
                    MessageBox.Show("GANADOR CRUZ " + radioButton2.Text);
                    empate = 1;
                }
            }

            if (matriz[0, 0] == 1 && matriz[1, 0] == 1 && matriz[2, 0] == 1)
            {
                MessageBox.Show("GANADOR CIRCULO " + radioButton1.Text);
                empate = 1;
            }
            else
            {
                if (matriz[0, 0] == 2 && matriz[1, 0] == 2 && matriz[2, 0] == 2)
                {
                    MessageBox.Show("GANADOR CRUZ " + radioButton2.Text);
                    empate = 1;
                }
            }
                                   
            if (matriz[0, 1] == 1 && matriz[1, 1] == 1 && matriz[2, 1] == 1)
            {
                MessageBox.Show("GANADOR CIRCULO " + radioButton1.Text);
                empate = 1;
            }
            else
            {
                if (matriz[0, 1] == 2 && matriz[1, 1] == 2 && matriz[2, 1] == 2)
                {
                    MessageBox.Show("GANADOR CRUZ " + radioButton2.Text);
                    empate = 1;
                }
            }
                                            
            if (matriz[0, 2] == 1 && matriz[1, 2] == 1 && matriz[2, 2] == 1)
            {
                MessageBox.Show("GANADOR CIRCULO " + radioButton1.Text);
                empate = 1;
            }
            else
            {
                if (matriz[0, 2] == 2 && matriz[1, 2] == 2 && matriz[2, 2] == 2)
                {
                    MessageBox.Show("GANADOR CRUZ " + radioButton2.Text);
                    empate = 1;
                }
            }
                                                
           
            
            


        }
        void reiniciar()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            
            radioButton1.Checked = true;
            panel1.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            matriz = new int [3,3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            pos = 1;
            empate = 0;

        }
        
       

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            reiniciar();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
