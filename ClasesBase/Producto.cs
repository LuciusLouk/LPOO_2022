﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Producto : IDataErrorInfo
    {
        private string codProducto, categoria, color, descripcion;
        private decimal precio;

        public Producto()
        {

        }

        public string CodProducto { get { return codProducto; } set { codProducto = value; } }
        public string Categoria { get { return categoria; } set { categoria = value; } }
        public string Color { get { return color; } set { color = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public decimal Precio { get { return precio; } set { precio = value; } }

        public override string ToString()
        {
            string msg = "Desea guardar este producto?"+"\nCodigo: " + codProducto + "\nCategoria: " + categoria + "\nColor: " + color + "\nDescripcion: " + descripcion + "\nPrecio: " + precio;
            return msg;
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get {
                string msgError = null;
                switch (columnName)
                {
                    case "CodProducto":
                        msgError = validarCodProducto();
                        break;
                    case "Categoria":
                        msgError = validarCategoria();
                        break;
                    case "Color":
                        msgError = validarColor();
                        break;
                    case "Descripcion":
                        msgError = validarDescripcion();
                        break;
                    case "Precio":
                        msgError = validarPrecio();
                        break;
                }
                return msgError;
                //throw new NotImplementedException(); 
            }
        }

        private string validarCodProducto()
        {
            if (String.IsNullOrEmpty(CodProducto))
            {
                return "El valor del campo es obligatorio";
            }
            return null;
        }

        private string validarCategoria()
        {
            if (String.IsNullOrEmpty(Categoria))
            {
                return "El valor del campo es obligatorio";
            }
            return null;
        }

        private string validarColor()
        {
            if (String.IsNullOrEmpty(Color))
            {
                return "El valor del campo es obligatorio";
            }
            return null;
        }

        private string validarDescripcion()
        {
            if (String.IsNullOrEmpty(Descripcion))
            {
                return "El valor del campo es obligatorio";
            }
            return null;
        }

        private string validarPrecio()
        {
            if (Precio <= 0)
            {
                return "El valor del campo debe ser mayor a 0";
            }
            return null;
        }
    }
}
