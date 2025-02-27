namespace GestorAlumnosApp
{
    partial class Form1
    {
        /// <summary>
        /// Limpiar recursos.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar memoria.
        /// </summary>
        /// <param name="disposing">true si se debe liberar recursos.</param>
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
        /// Método para inicializar los componentes.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelDni = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNota = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificarNota = new System.Windows.Forms.Button();
            this.btnMostrarSuspensos = new System.Windows.Forms.Button();
            this.btnMostrarAprobados = new System.Windows.Forms.Button();
            this.btnMostrarCandidatosMH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(74, 27);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(29, 13);
            this.labelDni.TabIndex = 0;
            this.labelDni.Text = "DNI:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(74, 57);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(74, 83);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(52, 13);
            this.labelApellidos.TabIndex = 2;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(74, 113);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(33, 13);
            this.labelNota.TabIndex = 3;
            this.labelNota.Text = "Nota:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(154, 20);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(154, 80);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 7;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(154, 110);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 8;
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.Location = new System.Drawing.Point(33, 239);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(361, 147);
            this.lstAlumnos.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(288, 20);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar Alumno";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(288, 50);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar Alumno";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(77, 166);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(131, 23);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar Alumno";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificarNota
            // 
            this.btnModificarNota.Location = new System.Drawing.Point(288, 78);
            this.btnModificarNota.Name = "btnModificarNota";
            this.btnModificarNota.Size = new System.Drawing.Size(103, 23);
            this.btnModificarNota.TabIndex = 14;
            this.btnModificarNota.Text = "Modificar Nota";
            this.btnModificarNota.Click += new System.EventHandler(this.btnModificarNota_Click);
            // 
            // btnMostrarSuspensos
            // 
            this.btnMostrarSuspensos.BackColor = System.Drawing.Color.White;
            this.btnMostrarSuspensos.Location = new System.Drawing.Point(214, 166);
            this.btnMostrarSuspensos.Name = "btnMostrarSuspensos";
            this.btnMostrarSuspensos.Size = new System.Drawing.Size(131, 23);
            this.btnMostrarSuspensos.TabIndex = 15;
            this.btnMostrarSuspensos.Text = "Mostrar Suspensos";
            this.btnMostrarSuspensos.UseVisualStyleBackColor = false;
            this.btnMostrarSuspensos.Click += new System.EventHandler(this.btnMostrarSuspensos_Click);
            // 
            // btnMostrarAprobados
            // 
            this.btnMostrarAprobados.BackColor = System.Drawing.Color.White;
            this.btnMostrarAprobados.Location = new System.Drawing.Point(77, 195);
            this.btnMostrarAprobados.Name = "btnMostrarAprobados";
            this.btnMostrarAprobados.Size = new System.Drawing.Size(131, 23);
            this.btnMostrarAprobados.TabIndex = 16;
            this.btnMostrarAprobados.Text = "Mostrar Aprobados";
            this.btnMostrarAprobados.UseVisualStyleBackColor = false;
            this.btnMostrarAprobados.Click += new System.EventHandler(this.btnMostrarAprobados_Click);
            // 
            // btnMostrarCandidatosMH
            // 
            this.btnMostrarCandidatosMH.BackColor = System.Drawing.Color.White;
            this.btnMostrarCandidatosMH.ForeColor = System.Drawing.Color.Black;
            this.btnMostrarCandidatosMH.Location = new System.Drawing.Point(214, 195);
            this.btnMostrarCandidatosMH.Name = "btnMostrarCandidatosMH";
            this.btnMostrarCandidatosMH.Size = new System.Drawing.Size(131, 23);
            this.btnMostrarCandidatosMH.TabIndex = 17;
            this.btnMostrarCandidatosMH.Text = "Mostrar Candidatos MH";
            this.btnMostrarCandidatosMH.UseVisualStyleBackColor = false;
            this.btnMostrarCandidatosMH.Click += new System.EventHandler(this.btnMostrarCandidatosMH_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(430, 442);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnModificarNota);
            this.Controls.Add(this.btnMostrarSuspensos);
            this.Controls.Add(this.btnMostrarAprobados);
            this.Controls.Add(this.btnMostrarCandidatosMH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestion de Calificaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDni, labelNombre, labelApellidos, labelNota;
        private System.Windows.Forms.TextBox txtDni, txtNombre, txtApellidos, txtNota;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.Button btnAgregar, btnEliminar, btnConsultar, btnModificarNota,
            btnMostrarSuspensos, btnMostrarAprobados, btnMostrarCandidatosMH;
    }
}

