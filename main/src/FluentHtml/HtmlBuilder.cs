using System;
using System.Collections;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.Text;

namespace FluentHtml;

public class HtmlBuilder(CultureInfo culture)
{
    private readonly StringBuilder _sb = new();
    private readonly CultureInfo _culture = culture;

    private static readonly char[] _NamePrefixes = ['@'];

    public HtmlBuilder() : this(CultureInfo.InvariantCulture)
    {

    }

    /// <summary>
    /// Adds an element to the html.
    /// <code>
    /// <![CDATA[
    /// <tag></tag>
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="tag">The name of the tag of the element. e.g. div, table etc.</param>
    /// <param name="attributes">The html attributes to add to the element.</param>
    /// <param name="buildContent">A delegate for adding content to the element being added.</param>
    /// <returns></returns>
    public HtmlBuilder Element(string tag, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        _sb.Append('<')
            .Append(tag);

        string attributesString = ReadAttributes(attributes);
        if (!string.IsNullOrEmpty(attributesString))
        {
            _sb.Append(' ')
                .Append(attributesString);
        }

        _sb.Append('>');

        buildContent?.Invoke(this);

        _sb.Append("</")
            .Append(tag)
            .Append('>');

        return this;
    }

    /// <summary>
    /// Adds an element to the html.
    /// <code>
    /// <![CDATA[
    /// <tag></tag>
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="tag">The name of the tag of the element. e.g. div, table etc.</param>
    /// <param name="buildContent">A delegate for adding content to the element being added.</param>
    /// <returns></returns>
    public HtmlBuilder Element(string tag, Action<HtmlBuilder> buildContent)
    {
        _ = buildContent ?? throw new ArgumentNullException(nameof(buildContent));

        return Element(tag, null, buildContent);
    }

    /// <summary>
    /// Adds a self-clossing element to the html.
    /// <code>
    /// <![CDATA[
    /// <tag/>
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="tag">The name of the tag of the element. e.g. img, input etc.</param>
    /// <param name="attributes">The html attributes to add to the element.</param>
    /// <returns></returns>
    public HtmlBuilder InlineElement(string tag, object? attributes = null)
    {
        _sb.Append('<')
            .Append(tag);

        string attributesString = ReadAttributes(attributes, _culture);
        if (!string.IsNullOrEmpty(attributesString))
        {
            _sb.Append(' ')
                .Append(attributesString);
        }

        _sb.Append("/>");

        return this;
    }

    /// <summary>
    /// Adds content to the html.  This can be text or raw html. If this is html, <paramref name="encode"/> should be false.
    /// </summary>
    /// <param name="content">The content to add.</param>
    /// <param name="encode">Specifies whether the content should be encoded before being added to the html.</param>
    /// <returns></returns>
    public HtmlBuilder Content(string content, bool encode = true)
    {
        if (encode)
        {
            content = WebUtility.HtmlEncode(content);
        }

        _sb.Append(content);

        return this;
    }

    /// <summary>
    /// Removes all previously added html. 
    /// </summary>
    /// <returns></returns>
    public HtmlBuilder Clear()
    {
        _sb.Clear();

        return this;
    }

    /// <summary>
    /// Writes the html to a string instance.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return _sb.ToString();
    }

    /// <summary>
    /// Write the html to a string.
    /// </summary>
    /// <returns></returns>
    public string Build()
    {
        return ToString();
    }

    private static string ReadAttributes(object? attributes, CultureInfo? culture = null)
    {
        if (attributes == null)
        {
            return string.Empty;
        }

        culture ??= CultureInfo.InvariantCulture;

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

