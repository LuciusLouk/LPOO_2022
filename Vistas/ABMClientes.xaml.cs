using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for ABMClientes.xaml
    /// </summary>
    public partial class ABMClientes : Window
    {
        public ABMClientes()
        {
            InitializeComponent();

        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtDni.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";

            txtDni.IsReadOnly = false;
            //txtDni.IsEnabled = true;
            txtApellido.IsReadOnly = false;
            txtNombre.IsReadOnly = false;
            txtDireccion.IsReadOnly = false;

            btnGuardar.IsEnabled = true;
            btnCancelar.IsEnabled = true;

            btnNuevo.IsEnabled = false;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnPrimero.IsEnabled = false;
            btnSiguiente.IsEnabled = false;
            btnAnterior.IsEnabled = false;
            btnUltimo.IsEnabled = false;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Cliente oCliente = new Cliente();
            oCliente.Dni = txtDni.Text;
            oCliente.Apellido = txtApellido.Text;
            oCliente.Nombre = txtNombre.Text;
            oCliente.Direccion = txtDireccion.Text;

            MessageBoxResult msg = MessageBox.Show(oCliente.ToString(), "Confirmacion", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
            if (msg == MessageBoxResult.OK)
            {
                txtDni.IsReadOnly = true;
                txtApellido.IsReadOnly = true;
                txtNombre.IsReadOnly = true;
                txtDireccion.IsReadOnly = true;

                btnGuardar.IsEnabled = false;
                btnCancelar.IsEnabled = false;

                btnNuevo.IsEnabled = true;
                btnModificar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                btnPrimero.IsEnabled = true;
                btnSiguiente.IsEnabled = true;
                btnAnterior.IsEnabled = true;
                btnUltimo.IsEnabled = true;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtDni.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";

            txtDni.IsReadOnly = true;
            //txtDni.IsEnabled = false;
            txtApellido.IsReadOnly = true;
            txtNombre.IsReadOnly = true;
            txtDireccion.IsReadOnly = true;

            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = false;

            btnNuevo.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnPrimero.IsEnabled = true;
            btnSiguiente.IsEnabled = true;
            btnAnterior.IsEnabled = true;
            btnUltimo.IsEnabled = true;
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
