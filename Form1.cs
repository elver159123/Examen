using System;
using System.Windows.Forms;
using Examen; // Asegúrate de que la referencia es correcta

namespace GestorAlumnosApp
{
    public partial class Form1 : Form
    {
        private GestorAlumnos gestorAlumnos;

        public Form1()
        {
            InitializeComponent();
            gestorAlumnos = new GestorAlumnos();
        }

        // Método para agregar un alumno
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string apellidos = txtApellidos.Text;
            string nombre = txtNombre.Text;
            double nota;

            if (double.TryParse(txtNota.Text, out nota))
            {
                Alumno nuevoAlumno = new Alumno(dni, apellidos, nombre, nota);
                gestorAlumnos.AgregarAlumno(nuevoAlumno);
                MessageBox.Show("Alumno agregado exitosamente.");
                MostrarAlumnos(); // Refresca la lista
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una nota válida.");
            }
        }

        // Método para eliminar un alumno por su DNI
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            if (gestorAlumnos.EliminarAlumno(dni))
            {
                MessageBox.Show("Alumno eliminado.");
                MostrarAlumnos();
            }
            else
            {
                MessageBox.Show("No se encontró un alumno con ese DNI.");
            }
            LimpiarCampos();
        }

        // Método para consultar la nota y calificación de un alumno
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            Alumno alumno = gestorAlumnos.ConsultarAlumno(dni);
            if (alumno != null)
            {
                txtNombre.Text = alumno.Nombre;
                txtApellidos.Text = alumno.Apellidos;
                txtNota.Text = alumno.Nota.ToString();
                
            }
            else
            {
                MessageBox.Show("Alumno no encontrado.");
                LimpiarCampos();
            }
        }

        // Método para modificar la nota de un alumno
        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            double nuevaNota;
            if (double.TryParse(txtNota.Text, out nuevaNota))
            {
                if (gestorAlumnos.ModificarNota(dni, nuevaNota))
                {
                    MessageBox.Show("Nota modificada.");
                    MostrarAlumnos();
                }
                else
                {
                    MessageBox.Show("Alumno no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una nota válida.");
            }
            LimpiarCampos();
        }

        // Método para mostrar alumnos suspensos (nota < 5)
        private void btnMostrarSuspensos_Click(object sender, EventArgs e)
        {
            lstAlumnos.Items.Clear();
            foreach (var alumno in gestorAlumnos.MostrarSuspensos())
            {
                lstAlumnos.Items.Add($"{alumno.Dni} - {alumno.Nombre} {alumno.Apellidos} - Nota: {alumno.Nota}");
            }
        }

        // Método para mostrar alumnos aprobados (nota >= 5)
        private void btnMostrarAprobados_Click(object sender, EventArgs e)
        {
            lstAlumnos.Items.Clear();
            foreach (var alumno in gestorAlumnos.MostrarAprobados())
            {
                lstAlumnos.Items.Add($"{alumno.Dni} - {alumno.Nombre} {alumno.Apellidos} - Nota: {alumno.Nota}");
            }
        }

        // Método para mostrar alumnos con Matrícula de Honor (nota = 10)
        private void btnMostrarCandidatosMH_Click(object sender, EventArgs e)
        {
            lstAlumnos.Items.Clear();
            foreach (var alumno in gestorAlumnos.MostrarCandidatosMH())
            {
                lstAlumnos.Items.Add($"{alumno.Dni} - {alumno.Nombre} {alumno.Apellidos} - Nota: {alumno.Nota}");
            }
        }

        // Método para modificar manualmente la calificación de un alumno


        // Método para actualizar la lista de alumnos en el ListBox
        private void MostrarAlumnos()
        {
            lstAlumnos.Items.Clear();
            foreach (var alumno in gestorAlumnos.ObtenerListaAlumnos())
            {
                lstAlumnos.Items.Add($"{alumno.Dni} - {alumno.Nombre} {alumno.Apellidos} - Nota: {alumno.Nota} { alumno.Calificacion}");
            }
        }

        // Método para limpiar los cuadros de texto
        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtApellidos.Clear();
            txtNombre.Clear();
            txtNota.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
