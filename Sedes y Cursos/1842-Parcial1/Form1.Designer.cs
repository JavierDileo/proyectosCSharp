namespace _1842_Parcial1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sede = new System.Windows.Forms.TextBox();
            this.txt_curso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_inscripcion = new System.Windows.Forms.Button();
            this.lbl_inscriptos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_consulta1Curso = new System.Windows.Forms.TextBox();
            this.btn_consultar1 = new System.Windows.Forms.Button();
            this.lbl_cons1Inscriptos = new System.Windows.Forms.Label();
            this.btn_cons2Sedes = new System.Windows.Forms.Button();
            this.lbl_capital = new System.Windows.Forms.Label();
            this.lbl_sanisidro = new System.Windows.Forms.Label();
            this.lbl_laplata = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sede";
            // 
            // txt_sede
            // 
            this.txt_sede.Location = new System.Drawing.Point(81, 31);
            this.txt_sede.Name = "txt_sede";
            this.txt_sede.Size = new System.Drawing.Size(40, 20);
            this.txt_sede.TabIndex = 1;
            // 
            // txt_curso
            // 
            this.txt_curso.Location = new System.Drawing.Point(195, 31);
            this.txt_curso.Name = "txt_curso";
            this.txt_curso.Size = new System.Drawing.Size(40, 20);
            this.txt_curso.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso";
            // 
            // btn_inscripcion
            // 
            this.btn_inscripcion.Location = new System.Drawing.Point(265, 29);
            this.btn_inscripcion.Name = "btn_inscripcion";
            this.btn_inscripcion.Size = new System.Drawing.Size(75, 23);
            this.btn_inscripcion.TabIndex = 4;
            this.btn_inscripcion.Text = "Inscribirse";
            this.btn_inscripcion.UseVisualStyleBackColor = true;
            this.btn_inscripcion.Click += new System.EventHandler(this.btn_inscripcion_Click);
            // 
            // lbl_inscriptos
            // 
            this.lbl_inscriptos.AutoSize = true;
            this.lbl_inscriptos.Location = new System.Drawing.Point(358, 34);
            this.lbl_inscriptos.Name = "lbl_inscriptos";
            this.lbl_inscriptos.Size = new System.Drawing.Size(52, 13);
            this.lbl_inscriptos.TabIndex = 5;
            this.lbl_inscriptos.Text = "Inscriptos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_cons1Inscriptos);
            this.groupBox1.Controls.Add(this.btn_consultar1);
            this.groupBox1.Controls.Add(this.txt_consulta1Curso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consutla1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_laplata);
            this.groupBox2.Controls.Add(this.lbl_sanisidro);
            this.groupBox2.Controls.Add(this.lbl_capital);
            this.groupBox2.Controls.Add(this.btn_cons2Sedes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(299, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 131);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Curso";
            // 
            // txt_consulta1Curso
            // 
            this.txt_consulta1Curso.Location = new System.Drawing.Point(46, 29);
            this.txt_consulta1Curso.Name = "txt_consulta1Curso";
            this.txt_consulta1Curso.Size = new System.Drawing.Size(40, 20);
            this.txt_consulta1Curso.TabIndex = 4;
            // 
            // btn_consultar1
            // 
            this.btn_consultar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar1.Location = new System.Drawing.Point(38, 55);
            this.btn_consultar1.Name = "btn_consultar1";
            this.btn_consultar1.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar1.TabIndex = 5;
            this.btn_consultar1.Text = "Consultar";
            this.btn_consultar1.UseVisualStyleBackColor = true;
            this.btn_consultar1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_cons1Inscriptos
            // 
            this.lbl_cons1Inscriptos.AutoSize = true;
            this.lbl_cons1Inscriptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cons1Inscriptos.Location = new System.Drawing.Point(35, 87);
            this.lbl_cons1Inscriptos.Name = "lbl_cons1Inscriptos";
            this.lbl_cons1Inscriptos.Size = new System.Drawing.Size(79, 13);
            this.lbl_cons1Inscriptos.TabIndex = 6;
            this.lbl_cons1Inscriptos.Text = "Total Inscriptos";
            // 
            // btn_cons2Sedes
            // 
            this.btn_cons2Sedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cons2Sedes.Location = new System.Drawing.Point(47, 21);
            this.btn_cons2Sedes.Name = "btn_cons2Sedes";
            this.btn_cons2Sedes.Size = new System.Drawing.Size(125, 23);
            this.btn_cons2Sedes.TabIndex = 0;
            this.btn_cons2Sedes.Text = "Consulta por Sede";
            this.btn_cons2Sedes.UseVisualStyleBackColor = true;
            this.btn_cons2Sedes.Click += new System.EventHandler(this.btn_cons2Sedes_Click);
            // 
            // lbl_capital
            // 
            this.lbl_capital.AutoSize = true;
            this.lbl_capital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_capital.Location = new System.Drawing.Point(16, 55);
            this.lbl_capital.Name = "lbl_capital";
            this.lbl_capital.Size = new System.Drawing.Size(66, 13);
            this.lbl_capital.TabIndex = 1;
            this.lbl_capital.Text = "Total Capital";
            // 
            // lbl_sanisidro
            // 
            this.lbl_sanisidro.AutoSize = true;
            this.lbl_sanisidro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sanisidro.Location = new System.Drawing.Point(16, 77);
            this.lbl_sanisidro.Name = "lbl_sanisidro";
            this.lbl_sanisidro.Size = new System.Drawing.Size(81, 13);
            this.lbl_sanisidro.TabIndex = 2;
            this.lbl_sanisidro.Text = "Total San Isidro";
            // 
            // lbl_laplata
            // 
            this.lbl_laplata.AutoSize = true;
            this.lbl_laplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_laplata.Location = new System.Drawing.Point(16, 100);
            this.lbl_laplata.Name = "lbl_laplata";
            this.lbl_laplata.Size = new System.Drawing.Size(73, 13);
            this.lbl_laplata.TabIndex = 3;
            this.lbl_laplata.Text = "Total La Plata";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_inscriptos);
            this.Controls.Add(this.btn_inscripcion);
            this.Controls.Add(this.txt_curso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sede);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "1842-Parcial 1 Cautrimestre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sede;
        private System.Windows.Forms.TextBox txt_curso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_inscripcion;
        private System.Windows.Forms.Label lbl_inscriptos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_consultar1;
        private System.Windows.Forms.TextBox txt_consulta1Curso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_cons1Inscriptos;
        private System.Windows.Forms.Label lbl_laplata;
        private System.Windows.Forms.Label lbl_sanisidro;
        private System.Windows.Forms.Label lbl_capital;
        private System.Windows.Forms.Button btn_cons2Sedes;
    }
}

