using System;
using System.Net;
using System.Text;

namespace Mason.FluentHtml;

public class HtmlBuilder(HtmlBuilderOptions? options = null)
{
    private static readonly HtmlBuilderOptions _defaultOptions = new();

    private readonly HtmlBuilderOptions _options = options ?? _defaultOptions;
    private readonly StringBuilder _sb = new();

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
            .Append(tag)
            .Append(HtmlAttributesHelper.ReadAttributes(attributes, _options.Culture))
            .Append('>');

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
    /// Adds a self-closing element to the html.
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
            .Append(tag)
            .Append(HtmlAttributesHelper.ReadAttributes(attributes, _options.Culture))
            .Append("/>");

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
        if (encode && !string.IsNullOrWhiteSpace(content))
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
}

