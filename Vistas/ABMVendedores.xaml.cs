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
    /// Interaction logic for ABMVendedores.xaml
    /// </summary>
    public partial class ABMVendedores : Window
    {
        public ABMVendedores()
        {
            InitializeComponent();

        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtLegajo.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";

            txtLegajo.IsReadOnly = false;
            txtApellido.IsReadOnly = false;
            txtNombre.IsReadOnly = false;

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
            Vendedor oVendedor = new Vendedor();
            oVendedor.Legajo = txtLegajo.Text;
            oVendedor.Apellido = txtApellido.Text;
            oVendedor.Nombre = txtNombre.Text;

            MessageBoxResult msg = MessageBox.Show(oVendedor.ToString(), "Confirmacion", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
            if (msg == MessageBoxResult.OK)
            {
                txtLegajo.IsReadOnly = true;
                txtApellido.IsReadOnly = true;
                txtNombre.IsReadOnly = true;

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
            txtLegajo.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";

            txtLegajo.IsReadOnly = true;
            txtApellido.IsReadOnly = true;
            txtNombre.IsReadOnly = true;

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
