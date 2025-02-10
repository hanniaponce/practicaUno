using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaUno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // boton para limpiar los textbox
            txtCorreo.Clear();
            txtNombre.Clear();
            txtTel.Clear();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // se declaran las variables de tipo string
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTel.Text;

            //se utiliza la condicion para verificar que no haya espacios en blanco
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //se agregar los datos ingresados al listbox
            lstContacto.Items.Add($"Nombre: {nombre}, Correo: {correo}, Teléfono: {telefono}");


        }

        private void lstContacto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //se utiliza una condicion para revisar que se seleccione un contacto y asi poder eliminarlo
            if (lstContacto.SelectedItem != null)
            {
                
                lstContacto.Items.Remove(lstContacto.SelectedItem);
            }
            //si la condicion no se cumple se muestra un mensaje para seleccionar una opcion
            else
            {
                
                MessageBox.Show("Por favor, seleccione un ítem para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            //para salir de la aplicacion
            Application.Exit();
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            //se muestra mensaje con info de la aplicacion
            MessageBox.Show("Aplicación de gestion de contactos");
        }

    }
}