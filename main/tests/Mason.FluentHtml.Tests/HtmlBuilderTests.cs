
namespace Mason.FluentHtml.Tests;

public partial class HtmlBuilderTests
{
    [Theory]
    [InlineData("div")]
    [InlineData("head")]
    [InlineData("html")]
    [InlineData("select")]
    [InlineData("figure")]
    public void Element_AddsExpectedElement(string tag)
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.Element(tag).ToString();

        //Assert
        Assert.Equal($"<{tag}></{tag}>", html);
    }

    [Theory]
    [InlineData("div")]
    [InlineData("head")]
    [InlineData("html")]
    [InlineData("select")]
    [InlineData("figure")]
    public void Element_AddsNonSelfClosingElement(string tag)
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.Element(tag).ToString();

        //Assert
        Assert.Equal($"<{tag}></{tag}>", html);
    }

    [Theory]
    [InlineData("div", "div")]
    [InlineData("head", "div")]
    [InlineData("html", "span")]
    [InlineData("select", "option")]
    [InlineData("figure", "figcaption")]
    public void Element_AddsNestedElement(string parentTag, string tag)
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.Element(parentTag, parent => parent.Element(tag)).ToString();

        //Assert
        Assert.Equal($"<{parentTag}><{tag}></{tag}></{parentTag}>", html);
    }

    [Theory]
    [InlineData("img")]
    [InlineData("input")]
    [InlineData("hr")]
    [InlineData("br")]
    [InlineData("link")]
    public void InlineElement_AddsExpectedElement(string tag)
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.InlineElement(tag).ToString();

        //Assert
        Assert.Equal($"<{tag}/>", html);
    }

    [Theory]
    [InlineData("div")]
    [InlineData("head")]
    [InlineData("html")]
    [InlineData("select")]
    [InlineData("figure")]
    public void InlineElement_AddsSelfClosingElement(string tag)
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.InlineElement(tag).ToString();

        //Assert
        Assert.Equal($"<{tag}/>", html);
    }

    [Theory]
    [InlineData("Hello World!")]
    [InlineData("Donald Duck!")]
    public void Content_AddsExpectedContent(string content)
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.Content(content).ToString();

        //Assert
        Assert.Equal(content, html);
    }

    [Fact]
    public void Content_EncodesContent()
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.Content("<div></div>", true).ToString();

        //Assert
        Assert.Equal("&lt;div&gt;&lt;/div&gt;", html);
    }

    [Fact]
    public void Content_DoesNotEncodeContent()
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.Content("<div></div>", false).ToString();

        //Assert
        Assert.Equal("<div></div>", html);
    }

    [Fact]
    public void Clear_RemovesAllHtml()
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.Element("div", div => div.Element("span"))
            .Clear()
            .ToString();

        //Assert
        Assert.Empty(html);
    }

    [Fact]
    public void ToString_ReturnsHtml()
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.Element("div", div => div.Element("span")).ToString();

        //Assert
        Assert.Equal("<div><span></span></div>", html);
    }

    [Fact]
    public void Build_ReturnsHtml()
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.Element("div", div => div.Element("span")).Build();

        //Assert
        Assert.Equal("<div><span></span></div>", html);
    }

    [Fact]
    public void Build_ReturnsSameHtmlAsToString()
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.Element("div", div => div.Element("span")).Build();

        sut.Clear();
        string html2 = sut.Element("div", div => div.Element("span")).ToString();

        //Assert
        Assert.Equal(html, html2);
    }

    [Fact]
    public void Element_AddsAttributesWithValues()
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.Element("div", new { ready = "true" }).ToString();

        //Assert
        Assert.Equal("<div ready=\"true\"></div>", html);
    }

    [Fact]
    public void Element_EmptyAttributeWhenValueIsNull()
    {
        //Arrange
        HtmlBuilder sut = new();

        //Act
        string html = sut.Element("div", new { required = (string?)null }).ToString();

        //Assert
        Assert.Equal("<div required></div>", html);
    }
}