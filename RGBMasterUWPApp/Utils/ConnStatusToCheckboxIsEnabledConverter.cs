﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace RGBMasterUWPApp.Utils
{
    public class ConnStatusToCheckboxIsEnabledConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var connStatus = (ConnectionStatus)value;

            return connStatus == ConnectionStatus.Connected || connStatus == ConnectionStatus.Disconnected;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
