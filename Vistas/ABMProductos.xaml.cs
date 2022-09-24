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
    /// Interaction logic for ABMProducto.xaml
    /// </summary>
    public partial class ABMProductos : Window
    {
        public ABMProductos()
        {
            InitializeComponent();

        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtCodigo.Text = "";
            txtCategoria.Text = "";
            txtColor.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";

            //txtCategoria.IsEnabled = true;
            txtCategoria.IsReadOnly = false;
            txtCodigo.IsReadOnly = false;
            txtColor.IsReadOnly = false;
            txtDescripcion.IsReadOnly = false;
            txtPrecio.IsReadOnly = false;

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
            Producto oProducto = new Producto();
            oProducto.Categoria = txtCategoria.Text;
            oProducto.CodProducto = txtCodigo.Text;
            oProducto.Color = txtColor.Text;
            oProducto.Descripcion = txtDescripcion.Text;
            oProducto.Precio = Decimal.Parse(txtPrecio.Text);

            MessageBoxResult msg = MessageBox.Show(oProducto.ToString(), "Confirmacion", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
            if (msg == MessageBoxResult.OK)
            {
                txtCategoria.IsReadOnly = true;
                txtCodigo.IsReadOnly = true;
                txtColor.IsReadOnly = true;
                txtDescripcion.IsReadOnly = true;
                txtPrecio.IsReadOnly = true;

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

            txtCodigo.Text = "";
            txtCategoria.Text = "";
            txtColor.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";

            txtCategoria.IsReadOnly = true;
            txtCodigo.IsReadOnly = true;
            txtColor.IsReadOnly = true;
            txtDescripcion.IsReadOnly = true;
            txtPrecio.IsReadOnly = true;

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

        private void txtPrecio_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            bool approvedDecimalPoint = false;

            if (e.Text == ".")
            {
                if (!((TextBox)sender).Text.Contains("."))
                    approvedDecimalPoint = true;
            }

            if (!(char.IsDigit(e.Text, e.Text.Length - 1) || approvedDecimalPoint))
                e.Handled = true;
        }
    }
}
