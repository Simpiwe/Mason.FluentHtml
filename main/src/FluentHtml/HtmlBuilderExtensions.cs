using System;

namespace FluentHtml;

public static class HtmlBuilderExtensions
{
    public static HtmlBuilder A(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("a", attributes, buildContent);
    }

    public static HtmlBuilder A(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("a", buildContent);
    }

    public static HtmlBuilder Abbr(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("abbr", attributes, buildContent);
    }

    public static HtmlBuilder Abbr(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("abbr", buildContent);
    }

    public static HtmlBuilder Address(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("address", attributes, buildContent);
    }

    public static HtmlBuilder Address(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("address", buildContent);
    }

    public static HtmlBuilder Article(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("article", attributes, buildContent);
    }

    public static HtmlBuilder Article(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("article", buildContent);
    }

    public static HtmlBuilder Aside(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("aside", attributes, buildContent);
    }

    public static HtmlBuilder Aside(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("aside", buildContent);
    }

    public static HtmlBuilder B(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("b", attributes, buildContent);
    }

    public static HtmlBuilder B(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("b", buildContent);
    }

    public static HtmlBuilder Blockquote(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("blockquote", attributes, buildContent);
    }

    public static HtmlBuilder Blockquote(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("blockquote", buildContent);
    }

    public static HtmlBuilder Body(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("body", attributes, buildContent);
    }

    public static HtmlBuilder Body(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("body", buildContent);
    }

    public static HtmlBuilder Br(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("br", attributes, buildContent);
    }

    public static HtmlBuilder Br(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("br", buildContent);
    }

    public static HtmlBuilder Button(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("button", attributes, buildContent);
    }

    public static HtmlBuilder Button(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("button", buildContent);
    }

    public static HtmlBuilder Canvas(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("canvas", attributes, buildContent);
    }

    public static HtmlBuilder Canvas(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("canvas", buildContent);
    }

    public static HtmlBuilder Caption(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("caption", attributes, buildContent);
    }

    public static HtmlBuilder Caption(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("caption", buildContent);
    }

    public static HtmlBuilder Cite(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("cite", attributes, buildContent);
    }

    public static HtmlBuilder Cite(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("cite", buildContent);
    }

    public static HtmlBuilder Code(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("code", attributes, buildContent);
    }

    public static HtmlBuilder Code(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("code", buildContent);
    }

    public static HtmlBuilder Col(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("col", attributes, buildContent);
    }

    public static HtmlBuilder Col(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("col", buildContent);
    }

    public static HtmlBuilder Colgroup(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("colgroup", attributes, buildContent);
    }

    public static HtmlBuilder Colgroup(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("colgroup", buildContent);
    }

    public static HtmlBuilder Dd(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("dd", attributes, buildContent);
    }

    public static HtmlBuilder Dd(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("dd", buildContent);
    }

    public static HtmlBuilder Del(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("del", attributes, buildContent);
    }

    public static HtmlBuilder Del(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("del", buildContent);
    }

    public static HtmlBuilder Details(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("details", attributes, buildContent);
    }

    public static HtmlBuilder Details(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("details", buildContent);
    }

    public static HtmlBuilder Dfn(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("dfn", attributes, buildContent);
    }

    public static HtmlBuilder Dfn(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("dfn", buildContent);
    }

    public static HtmlBuilder Div(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("div", attributes, buildContent);
    }

    public static HtmlBuilder Div(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("div", buildContent);
    }

    public static HtmlBuilder Dl(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("dl", attributes, buildContent);
    }

    public static HtmlBuilder Dl(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("dl", buildContent);
    }

    public static HtmlBuilder Dt(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("dt", attributes, buildContent);
    }

    public static HtmlBuilder Dt(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("dt", buildContent);
    }

    public static HtmlBuilder Em(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("em", attributes, buildContent);
    }

    public static HtmlBuilder Em(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("em", buildContent);
    }

    public static HtmlBuilder Fieldset(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("fieldset", attributes, buildContent);
    }

    public static HtmlBuilder Fieldset(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("fieldset", buildContent);
    }

    public static HtmlBuilder Figcaption(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("figcaption", attributes, buildContent);
    }

    public static HtmlBuilder Figcaption(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("figcaption", buildContent);
    }

    public static HtmlBuilder Figure(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("figure", attributes, buildContent);
    }

    public static HtmlBuilder Figure(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("figure", buildContent);
    }

    public static HtmlBuilder Footer(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("footer", attributes, buildContent);
    }

    public static HtmlBuilder Footer(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("footer", buildContent);
    }

    public static HtmlBuilder Form(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("form", attributes, buildContent);
    }

    public static HtmlBuilder Form(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("form", buildContent);
    }

    public static HtmlBuilder H1(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("h1", attributes, buildContent);
    }

    public static HtmlBuilder H1(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("h1", buildContent);
    }

    public static HtmlBuilder H2(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("h2", attributes, buildContent);
    }

    public static HtmlBuilder H2(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("h2", buildContent);
    }

    public static HtmlBuilder H3(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("h3", attributes, buildContent);
    }

    public static HtmlBuilder H3(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("h3", buildContent);
    }

    public static HtmlBuilder H4(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("h4", attributes, buildContent);
    }

    public static HtmlBuilder H4(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("h4", buildContent);
    }

    public static HtmlBuilder H5(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("h5", attributes, buildContent);
    }

    public static HtmlBuilder H5(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("h5", buildContent);
    }

    public static HtmlBuilder H6(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("h6", attributes, buildContent);
    }

    public static HtmlBuilder H6(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("h6", buildContent);
    }

    public static HtmlBuilder Head(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("head", attributes, buildContent);
    }

    public static HtmlBuilder Head(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("head", buildContent);
    }

    public static HtmlBuilder Header(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("header", attributes, buildContent);
    }

    public static HtmlBuilder Header(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("header", buildContent);
    }

    public static HtmlBuilder Hgroup(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("hgroup", attributes, buildContent);
    }

    public static HtmlBuilder Hgroup(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("hgroup", buildContent);
    }

    public static HtmlBuilder Hr(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("hr", attributes, buildContent);
    }

    public static HtmlBuilder Hr(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("hr", buildContent);
    }

    public static HtmlBuilder Html(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("html", attributes, buildContent);
    }

    public static HtmlBuilder Html(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("html", buildContent);
    }

    public static HtmlBuilder I(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("i", attributes, buildContent);
    }

    public static HtmlBuilder I(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("i", buildContent);
    }

    public static HtmlBuilder Iframe(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("iframe", attributes, buildContent);
    }

    public static HtmlBuilder Iframe(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("iframe", buildContent);
    }

    public static HtmlBuilder Img(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("img", attributes, buildContent);
    }

    public static HtmlBuilder Img(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("img", buildContent);
    }

    public static HtmlBuilder Input(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("input", attributes, buildContent);
    }

    public static HtmlBuilder Input(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("input", buildContent);
    }

    public static HtmlBuilder Ins(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("ins", attributes, buildContent);
    }

    public static HtmlBuilder Ins(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("ins", buildContent);
    }

    public static HtmlBuilder Kbd(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("kbd", attributes, buildContent);
    }

    public static HtmlBuilder Kbd(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("kbd", buildContent);
    }

    public static HtmlBuilder Label(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("label", attributes, buildContent);
    }

    public static HtmlBuilder Label(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("label", buildContent);
    }

    public static HtmlBuilder Legend(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("legend", attributes, buildContent);
    }

    public static HtmlBuilder Legend(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("legend", buildContent);
    }

    public static HtmlBuilder Li(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("li", attributes, buildContent);
    }

    public static HtmlBuilder Li(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("li", buildContent);
    }

    public static HtmlBuilder Link(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("link", attributes, buildContent);
    }

    public static HtmlBuilder Link(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("link", buildContent);
    }

    public static HtmlBuilder Main(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("main", attributes, buildContent);
    }

    public static HtmlBuilder Main(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("main", buildContent);
    }

    public static HtmlBuilder Map(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("map", attributes, buildContent);
    }

    public static HtmlBuilder Map(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("map", buildContent);
    }

    public static HtmlBuilder Meta(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("meta", attributes, buildContent);
    }

    public static HtmlBuilder Meta(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("meta", buildContent);
    }

    public static HtmlBuilder Meter(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("meter", attributes, buildContent);
    }

    public static HtmlBuilder Meter(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("meter", buildContent);
    }

    public static HtmlBuilder Nav(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("nav", attributes, buildContent);
    }

    public static HtmlBuilder Nav(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("nav", buildContent);
    }

    public static HtmlBuilder Noscript(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("noscript", attributes, buildContent);
    }

    public static HtmlBuilder Noscript(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("noscript", buildContent);
    }

    public static HtmlBuilder Ol(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("ol", attributes, buildContent);
    }

    public static HtmlBuilder Ol(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("ol", buildContent);
    }

    public static HtmlBuilder Optgroup(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("optgroup", attributes, buildContent);
    }

    public static HtmlBuilder Optgroup(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("optgroup", buildContent);
    }

    public static HtmlBuilder Option(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("option", attributes, buildContent);
    }

    public static HtmlBuilder Option(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("option", buildContent);
    }

    public static HtmlBuilder Output(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("output", attributes, buildContent);
    }

    public static HtmlBuilder Output(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("output", buildContent);
    }

    public static HtmlBuilder P(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("p", attributes, buildContent);
    }

    public static HtmlBuilder P(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("p", buildContent);
    }

    public static HtmlBuilder Param(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("param", attributes, buildContent);
    }

    public static HtmlBuilder Param(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("param", buildContent);
    }

    public static HtmlBuilder Picture(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("picture", attributes, buildContent);
    }

    public static HtmlBuilder Picture(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("picture", buildContent);
    }

    public static HtmlBuilder Pre(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("pre", attributes, buildContent);
    }

    public static HtmlBuilder Pre(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("pre", buildContent);
    }

    public static HtmlBuilder Progress(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("progress", attributes, buildContent);
    }

    public static HtmlBuilder Progress(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("progress", buildContent);
    }

    public static HtmlBuilder Q(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("q", attributes, buildContent);
    }

    public static HtmlBuilder Q(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("q", buildContent);
    }

    public static HtmlBuilder Rp(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("rp", attributes, buildContent);
    }

    public static HtmlBuilder Rp(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("rp", buildContent);
    }

    public static HtmlBuilder Rt(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("rt", attributes, buildContent);
    }

    public static HtmlBuilder Rt(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("rt", buildContent);
    }

    public static HtmlBuilder Ruby(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("ruby", attributes, buildContent);
    }

    public static HtmlBuilder Ruby(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("ruby", buildContent);
    }

    public static HtmlBuilder S(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("s", attributes, buildContent);
    }

    public static HtmlBuilder S(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("s", buildContent);
    }

    public static HtmlBuilder Samp(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("samp", attributes, buildContent);
    }

    public static HtmlBuilder Samp(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("samp", buildContent);
    }

    public static HtmlBuilder Script(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("script", attributes, buildContent);
    }

    public static HtmlBuilder Script(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("script", buildContent);
    }

    public static HtmlBuilder Section(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("section", attributes, buildContent);
    }

    public static HtmlBuilder Section(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("section", buildContent);
    }

    public static HtmlBuilder Select(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("select", attributes, buildContent);
    }

    public static HtmlBuilder Select(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("select", buildContent);
    }

    public static HtmlBuilder Small(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("small", attributes, buildContent);
    }

    public static HtmlBuilder Small(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("small", buildContent);
    }

    public static HtmlBuilder Source(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("source", attributes, buildContent);
    }

    public static HtmlBuilder Source(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("source", buildContent);
    }

    public static HtmlBuilder Span(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("span", attributes, buildContent);
    }

    public static HtmlBuilder Span(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("span", buildContent);
    }

    public static HtmlBuilder Strong(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("strong", attributes, buildContent);
    }

    public static HtmlBuilder Strong(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("strong", buildContent);
    }

    public static HtmlBuilder Style(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("style", attributes, buildContent);
    }

    public static HtmlBuilder Style(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("style", buildContent);
    }

    public static HtmlBuilder Sub(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("sub", attributes, buildContent);
    }

    public static HtmlBuilder Sub(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("sub", buildContent);
    }

    public static HtmlBuilder Summary(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("summary", attributes, buildContent);
    }

    public static HtmlBuilder Summary(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("summary", buildContent);
    }

    public static HtmlBuilder Sup(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("sup", attributes, buildContent);
    }

    public static HtmlBuilder Sup(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("sup", buildContent);
    }

    public static HtmlBuilder Svg(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("svg", attributes, buildContent);
    }

    public static HtmlBuilder Svg(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("svg", buildContent);
    }

    public static HtmlBuilder Table(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("table", attributes, buildContent);
    }

    public static HtmlBuilder Table(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("table", buildContent);
    }

    public static HtmlBuilder Tbody(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("tbody", attributes, buildContent);
    }

    public static HtmlBuilder Tbody(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("tbody", buildContent);
    }

    public static HtmlBuilder Td(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("td", attributes, buildContent);
    }

    public static HtmlBuilder Td(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("td", buildContent);
    }

    public static HtmlBuilder Template(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("template", attributes, buildContent);
    }

    public static HtmlBuilder Template(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("template", buildContent);
    }

    public static HtmlBuilder Textarea(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("textarea", attributes, buildContent);
    }

    public static HtmlBuilder Textarea(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("textarea", buildContent);
    }

    public static HtmlBuilder Tfoot(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("tfoot", attributes, buildContent);
    }

    public static HtmlBuilder Tfoot(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("tfoot", buildContent);
    }

    public static HtmlBuilder Th(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("th", attributes, buildContent);
    }

    public static HtmlBuilder Th(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("th", buildContent);
    }

    public static HtmlBuilder Thead(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("thead", attributes, buildContent);
    }

    public static HtmlBuilder Thead(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("thead", buildContent);
    }

    public static HtmlBuilder Time(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("time", attributes, buildContent);
    }

    public static HtmlBuilder Time(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("time", buildContent);
    }

    public static HtmlBuilder Title(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("title", attributes, buildContent);
    }

    public static HtmlBuilder Title(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("title", buildContent);
    }

    public static HtmlBuilder Tr(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("tr", attributes, buildContent);
    }

    public static HtmlBuilder Tr(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("tr", buildContent);
    }

    public static HtmlBuilder Track(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("track", attributes, buildContent);
    }

    public static HtmlBuilder Track(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("track", buildContent);
    }

    public static HtmlBuilder U(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("u", attributes, buildContent);
    }

    public static HtmlBuilder U(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("u", buildContent);
    }

    public static HtmlBuilder Ul(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("ul", attributes, buildContent);
    }

    public static HtmlBuilder Ul(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("ul", buildContent);
    }

    public static HtmlBuilder Var(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("var", attributes, buildContent);
    }

    public static HtmlBuilder Var(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("var", buildContent);
    }

    public static HtmlBuilder Video(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("video", attributes, buildContent);
    }

    public static HtmlBuilder Video(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("video", buildContent);
    }

    public static HtmlBuilder Wbr(this HtmlBuilder builder, object? attributes = null, Action<HtmlBuilder>? buildContent = null)
    {
        return builder.Element("wbr", attributes, buildContent);
    }

    public static HtmlBuilder Wbr(this HtmlBuilder builder, Action<HtmlBuilder> buildContent)
    {
        return builder.Element("wbr", buildContent);
    }
}

