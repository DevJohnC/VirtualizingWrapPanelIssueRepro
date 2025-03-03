using System.Globalization;
using Avalonia.Data.Converters;

namespace AvalonaWrapPanelRepro.ValueConverters;

public sealed class ScaleConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is double d)
            return d * 100;

        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}