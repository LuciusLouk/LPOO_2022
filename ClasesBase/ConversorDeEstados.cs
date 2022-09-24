using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Globalization;

namespace ClasesBase
{
    public class ConversorDeEstados : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString().ToLower())
            {
                case "pendiente":
                    return "Red";
                case "pagada":
                    return "Green";
                case "contabilizada":
                    return "Blue";
                case "anulada":
                    return "Gray";
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
                CultureInfo culture)
        {
            
            throw new NotImplementedException();
        }
    }
}
