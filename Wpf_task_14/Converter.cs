﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Wpf_task_14
{
    class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((ProductCategorys)value == ProductCategorys.Food)
            {
                return "Еда";
            }
            return "Бытовая техника";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}