using System;

namespace FluentHtml;

public static class HtmlBuilderExtensions
{
    /// <summary>
    /// A convenience method for creating an element with the tag 'a'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("a", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder A(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("a", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'a'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("a", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder A(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("a", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'abbr'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("abbr", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Abbr(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("abbr", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'abbr'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("abbr", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Abbr(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("abbr", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'address'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("address", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Address(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("address", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'address'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("address", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Address(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("address", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'article'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("article", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Article(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("article", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'article'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("article", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Article(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("article", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'aside'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("aside", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Aside(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("aside", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'aside'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("aside", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Aside(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("aside", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'b'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("b", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder B(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("b", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'b'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("b", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder B(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("b", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'blockquote'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("blockquote", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Blockquote(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("blockquote", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'blockquote'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("blockquote", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Blockquote(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("blockquote", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'body'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("body", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Body(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("body", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'body'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("body", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Body(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("body", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'br'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.InlineElement("br", attributes);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Br(this HtmlBuilder builder, object? attributes = null)
    {
        return builder.InlineElement("br", attributes);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'button'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("button", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Button(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("button", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'button'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("button", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Button(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("button", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'canvas'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("canvas", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Canvas(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("canvas", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'canvas'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("canvas", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Canvas(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("canvas", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'caption'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("caption", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Caption(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("caption", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'caption'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("caption", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Caption(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("caption", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'cite'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("cite", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Cite(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("cite", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'cite'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("cite", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Cite(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("cite", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'code'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("code", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Code(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("code", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'code'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("code", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Code(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("code", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'col'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.InlineElement("col", attributes);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Col(this HtmlBuilder builder, object? attributes = null)
    {
        return builder.InlineElement("col", attributes);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'colgroup'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("colgroup", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Colgroup(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("colgroup", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'colgroup'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("colgroup", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Colgroup(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("colgroup", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'dd'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("dd", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Dd(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("dd", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'dd'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("dd", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Dd(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("dd", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'del'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("del", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Del(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("del", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'del'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("del", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Del(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("del", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'details'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("details", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Details(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("details", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'details'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("details", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Details(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("details", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'dfn'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("dfn", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Dfn(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("dfn", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'dfn'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("dfn", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Dfn(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("dfn", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'div'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("div", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Div(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("div", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'div'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("div", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Div(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("div", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'dl'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("dl", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Dl(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("dl", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'dl'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("dl", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Dl(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("dl", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'dt'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("dt", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Dt(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("dt", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'dt'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("dt", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Dt(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("dt", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'em'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("em", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Em(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("em", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'em'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("em", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Em(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("em", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'fieldset'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("fieldset", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Fieldset(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("fieldset", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'fieldset'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("fieldset", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Fieldset(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("fieldset", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'figcaption'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("figcaption", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Figcaption(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("figcaption", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'figcaption'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("figcaption", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Figcaption(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("figcaption", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'figure'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("figure", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Figure(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("figure", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'figure'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("figure", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Figure(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("figure", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'footer'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("footer", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Footer(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("footer", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'footer'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("footer", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Footer(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("footer", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'form'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("form", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Form(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("form", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'form'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("form", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Form(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("form", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'h1'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("h1", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder H1(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("h1", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'h1'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("h1", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder H1(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("h1", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'h2'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("h2", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder H2(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("h2", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'h2'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("h2", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder H2(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("h2", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'h3'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("h3", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder H3(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("h3", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'h3'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("h3", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder H3(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("h3", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'h4'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("h4", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder H4(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("h4", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'h4'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("h4", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder H4(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("h4", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'h5'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("h5", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder H5(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("h5", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'h5'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("h5", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder H5(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("h5", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'h6'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("h6", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder H6(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("h6", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'h6'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("h6", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder H6(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("h6", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'head'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("head", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Head(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("head", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'head'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("head", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Head(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("head", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'header'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("header", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Header(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("header", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'header'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("header", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Header(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("header", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'hgroup'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("hgroup", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Hgroup(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("hgroup", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'hgroup'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("hgroup", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Hgroup(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("hgroup", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'hr'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.InlineElement("hr", attributes);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Hr(this HtmlBuilder builder, object? attributes = null)
    {
        return builder.InlineElement("hr", attributes);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'html'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("html", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Html(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("html", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'html'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("html", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Html(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("html", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'i'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("i", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder I(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("i", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'i'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("i", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder I(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("i", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'iframe'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("iframe", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Iframe(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("iframe", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'iframe'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("iframe", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Iframe(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("iframe", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'img'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.InlineElement("img", attributes);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Img(this HtmlBuilder builder, object? attributes = null)
    {
        return builder.InlineElement("img", attributes);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'input'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.InlineElement("input", attributes);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Input(this HtmlBuilder builder, object? attributes = null)
    {
        return builder.InlineElement("input", attributes);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'ins'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("ins", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Ins(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("ins", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'ins'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("ins", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Ins(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("ins", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'kbd'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("kbd", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Kbd(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("kbd", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'kbd'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("kbd", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Kbd(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("kbd", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'label'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("label", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Label(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("label", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'label'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("label", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Label(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("label", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'legend'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("legend", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Legend(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("legend", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'legend'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("legend", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Legend(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("legend", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'li'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("li", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Li(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("li", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'li'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("li", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Li(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("li", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'link'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.InlineElement("link", attributes);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Link(this HtmlBuilder builder, object? attributes = null)
    {
        return builder.InlineElement("link", attributes);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'main'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("main", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Main(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("main", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'main'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("main", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Main(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("main", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'map'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("map", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Map(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("map", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'map'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("map", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Map(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("map", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'meta'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.InlineElement("meta", attributes);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Meta(this HtmlBuilder builder, object? attributes = null)
    {
        return builder.InlineElement("meta", attributes);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'meter'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("meter", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Meter(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("meter", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'meter'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("meter", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Meter(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("meter", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'nav'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("nav", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Nav(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("nav", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'nav'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("nav", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Nav(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("nav", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'noscript'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("noscript", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Noscript(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("noscript", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'noscript'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("noscript", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Noscript(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("noscript", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'ol'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("ol", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Ol(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("ol", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'ol'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("ol", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Ol(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("ol", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'optgroup'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("optgroup", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Optgroup(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("optgroup", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'optgroup'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("optgroup", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Optgroup(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("optgroup", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'option'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("option", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Option(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("option", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'option'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("option", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Option(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("option", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'output'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("output", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Output(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("output", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'output'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("output", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Output(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("output", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'p'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("p", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder P(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("p", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'p'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("p", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder P(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("p", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'param'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.InlineElement("param", attributes);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Param(this HtmlBuilder builder, object? attributes = null)
    {
        return builder.InlineElement("param", attributes);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'picture'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("picture", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Picture(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("picture", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'picture'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("picture", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Picture(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("picture", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'pre'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("pre", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Pre(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("pre", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'pre'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("pre", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Pre(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("pre", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'progress'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("progress", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Progress(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("progress", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'progress'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("progress", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Progress(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("progress", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'q'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("q", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Q(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("q", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'q'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("q", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Q(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("q", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'rp'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("rp", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Rp(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("rp", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'rp'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("rp", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Rp(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("rp", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'rt'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("rt", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Rt(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("rt", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'rt'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("rt", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Rt(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("rt", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'ruby'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("ruby", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Ruby(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("ruby", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'ruby'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("ruby", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Ruby(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("ruby", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 's'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("s", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder S(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("s", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 's'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("s", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder S(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("s", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'samp'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("samp", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Samp(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("samp", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'samp'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("samp", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Samp(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("samp", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'script'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("script", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Script(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("script", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'script'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("script", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Script(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("script", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'section'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("section", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Section(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("section", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'section'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("section", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Section(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("section", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'select'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("select", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Select(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("select", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'select'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("select", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Select(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("select", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'small'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("small", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Small(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("small", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'small'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("small", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Small(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("small", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'source'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.InlineElement("source", attributes);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Source(this HtmlBuilder builder, object? attributes = null)
    {
        return builder.InlineElement("source", attributes);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'span'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("span", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Span(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("span", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'span'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("span", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Span(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("span", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'strong'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("strong", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Strong(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("strong", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'strong'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("strong", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Strong(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("strong", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'style'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("style", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Style(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("style", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'style'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("style", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Style(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("style", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'sub'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("sub", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Sub(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("sub", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'sub'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("sub", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Sub(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("sub", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'summary'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("summary", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Summary(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("summary", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'summary'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("summary", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Summary(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("summary", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'sup'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("sup", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Sup(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("sup", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'sup'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("sup", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Sup(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("sup", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'svg'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("svg", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Svg(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("svg", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'svg'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("svg", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Svg(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("svg", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'table'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("table", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Table(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("table", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'table'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("table", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Table(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("table", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'tbody'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("tbody", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Tbody(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("tbody", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'tbody'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("tbody", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Tbody(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("tbody", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'td'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("td", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Td(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("td", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'td'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("td", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Td(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("td", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'template'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("template", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Template(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("template", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'template'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("template", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Template(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("template", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'textarea'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("textarea", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Textarea(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("textarea", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'textarea'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("textarea", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Textarea(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("textarea", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'tfoot'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("tfoot", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Tfoot(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("tfoot", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'tfoot'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("tfoot", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Tfoot(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("tfoot", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'th'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("th", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Th(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("th", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'th'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("th", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Th(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("th", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'thead'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("thead", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Thead(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("thead", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'thead'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("thead", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Thead(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("thead", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'time'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("time", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Time(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("time", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'time'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("time", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Time(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("time", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'title'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("title", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Title(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("title", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'title'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("title", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Title(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("title", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'tr'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("tr", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Tr(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("tr", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'tr'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("tr", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Tr(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("tr", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'track'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.InlineElement("track", attributes);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Track(this HtmlBuilder builder, object? attributes = null)
    {
        return builder.InlineElement("track", attributes);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'u'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("u", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder U(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("u", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'u'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("u", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder U(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("u", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'ul'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("ul", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Ul(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("ul", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'ul'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("ul", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Ul(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("ul", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'var'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("var", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Var(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("var", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'var'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("var", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Var(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("var", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'video'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("video", attributes, buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Video(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("video", attributes, buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'video'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.Element("video", buildContent);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">A delegate for adding content to the element being added.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Video(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("video", buildContent);
    }

    /// <summary>
    /// A convenience method for creating an element with the tag 'wbr'.
    /// <code>
    /// <![CDATA[
    /// // Shorthand for:
    /// htmlBuilder.InlineElement("wbr", attributes);
    /// ]]>
    /// </code>
    /// </summary>
    /// <param name="builder">The HtmlBuilder instance.</param>
    /// <param name="attributes">The html attributes.</param>
    /// <returns>The HtmlBuilder instance.</returns>
    public static HtmlBuilder Wbr(this HtmlBuilder builder, object? attributes = null)
    {
        return builder.InlineElement("wbr", attributes);
    }
}

