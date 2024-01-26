using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
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

        if (attributes is IDictionary d1)
        {
            return ReadAttributes(d1, culture);
        }

        if (attributes is IEnumerable<KeyValuePair<string, string?>> d2)
        {
            return ReadAttributes(d2, culture);
        }

        if (attributes is IEnumerable<KeyValuePair<string, string?>> d3)
        {
            return ReadAttributes(d3, culture);
        }

        if (attributes is ExpandoObject e)
        {
            return ReadAttributes((IEnumerable<KeyValuePair<string, object?>>)e, culture);
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

            WriteAttribute(sb, name, value, culture);
        }

        return sb.ToString();
    }

    private static string ReadAttributes(IDictionary dictionary, CultureInfo culture)
    {
        StringBuilder sb = new();

        foreach (object? key in dictionary.Keys)
        {
            WriteAttribute(sb, key, dictionary[key], culture);
        }

        return sb.ToString();
    }

    private static string ReadAttributes<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> attributes, CultureInfo culture)
    {
        StringBuilder sb = new();

        foreach (KeyValuePair<TKey, TValue> attribute in attributes)
        {
            WriteAttribute(sb, attribute.Key, attribute.Value, culture);
        }

        return sb.ToString();
    }
    
    private static void WriteAttribute(StringBuilder destination, object? name, object? value, CultureInfo culture)
    {
        string? key = Convert.ToString(name, culture);

        if (string.IsNullOrEmpty(key))
            return;

        string? v = null;
        if (value is not null)
        {
            v = Convert.ToString(value, culture);
        }

        WriteAttribute(destination, key, v);
    }
    
    private static void WriteAttribute(StringBuilder destination, string name, string? value)
    {
        destination.Append(' ')
          .Append(WebUtility.HtmlEncode(name));
        
        if (value is not null)
        {
            destination.Append('=')
              .Append('"')
              .Append(WebUtility.HtmlEncode(value))
              .Append('"');
        }
    }

    private static string RemoveNamePrefix(string name)
    {
        return name.TrimStart(_NamePrefixes);
    }
}