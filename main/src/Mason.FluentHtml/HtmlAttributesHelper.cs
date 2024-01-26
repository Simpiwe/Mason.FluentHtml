using System;
using System.Collections;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.Text;

namespace Mason.FluentHtml;

internal static class HtmlAttributesHelper
{
    private static readonly char[] _NamePrefixes = ['@'];

    public static string ReadAttributes(object? attributes, CultureInfo? culture = null)
    {
        if (attributes == null)
        {
            return string.Empty;
        }

        culture ??= CultureInfo.InvariantCulture;

        if (attributes is string s)
        {
            return s;
        }

        if (attributes is IDictionary dictionary)
        {
            return ReadAttributes(dictionary, culture);
        }

        Type type = attributes.GetType();

        if (type.Module.Name == "System.Private.CoreLib.dll")
        {
            throw new NotSupportedException($"{type.FullName} is not a supported type for the html attributes. Please use an anonymous type, a dictionary or a custom class.");
        }

        StringBuilder sb = new();

        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty);

        for (int i = 0; i < properties.Length; i++)
        {
            PropertyInfo property = properties[i];

            string name = RemoveNamePrefix(property.Name);

            object? value = property.GetValue(attributes);
            string? valueString = Convert.ToString(value, culture);

            if (sb.Length > 0)
            {
                sb.Append(' ');
            }

            WriteAttribute(sb, name, valueString, culture);
        }

        return sb.ToString();
    }

    private static string ReadAttributes(IDictionary dictionary, CultureInfo culture)
    {
        StringBuilder sb = new();

        foreach (object? key in dictionary.Keys)
        {
            string? k = Convert.ToString(key, culture);

            if (string.IsNullOrEmpty(k))
                continue;

            object? value = dictionary[key];
            string? v = Convert.ToString(value, culture);

            if (sb.Length > 0)
            {
                sb.Append(' ');
            }

            WriteAttribute(sb, k, v, culture);
        }

        return sb.ToString();
    }

    private static void WriteAttribute(StringBuilder destination, string name, string? value, CultureInfo culture)
    {
        destination.Append(WebUtility.HtmlEncode(name));

        if (value is not null)
        {
            string? valueString = Convert.ToString(value, culture);

            destination.Append('=')
              .Append('"')
              .Append(WebUtility.HtmlEncode(valueString))
              .Append('"');
        }
    }

    private static string RemoveNamePrefix(string name)
    {
        return name.TrimStart(_NamePrefixes);
    }
}