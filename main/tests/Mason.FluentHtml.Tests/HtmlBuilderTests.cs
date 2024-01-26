using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace Mason.FluentHtml.Tests
{
    public partial class HtmlBuilderTests
    {
        private static readonly Regex _nonSelfClosingRegex = GetNonSelfClosingRegex();
        private static readonly Regex _selfClosingRegex = GetSelfClosingRegex();

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
            HtmlDocument document = new();

            //Act
            string html = sut.Element(tag).ToString();
            document.LoadHtml(html);

            //Assert
            Assert.Single(document.DocumentNode.ChildNodes);
            Assert.Equal(tag, document.DocumentNode.FirstChild.Name);
            Assert.Empty(document.ParseErrors);
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
            HtmlDocument document = new();

            //Act
            string html = sut.Element(tag).ToString();
            document.LoadHtml(html);

            //Assert
            Assert.Single(document.DocumentNode.ChildNodes);
            Assert.Equal(tag, document.DocumentNode.FirstChild.Name);
            Assert.Empty(document.ParseErrors);
            Assert.Matches(_nonSelfClosingRegex, document.DocumentNode.FirstChild.OuterHtml);
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
            HtmlDocument document = new();

            //Act
            string html = sut.Element(parentTag, parent => parent.Element(tag)).ToString();
            document.LoadHtml(html);

            //Assert
            Assert.Empty(document.ParseErrors);
            Assert.Single(document.DocumentNode.ChildNodes);
            Assert.Equal(parentTag, document.DocumentNode.FirstChild.Name);
            Assert.Equal(tag, document.DocumentNode.FirstChild.FirstChild.Name);
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
            HtmlDocument document = new();

            //Act
            string html = sut.InlineElement(tag).ToString();
            document.LoadHtml(html);

            //Assert
            Assert.Single(document.DocumentNode.ChildNodes);
            Assert.Equal(tag, document.DocumentNode.FirstChild.Name);
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
            HtmlDocument document = new();

            //Act
            string html = sut.InlineElement(tag).ToString();
            document.LoadHtml(html);

            //Assert
            Assert.Single(document.DocumentNode.ChildNodes);
            Assert.Equal(tag, document.DocumentNode.FirstChild.Name);
            Assert.Empty(document.ParseErrors);
            Assert.Matches(_selfClosingRegex, document.DocumentNode.FirstChild.OuterHtml);
        }

        [GeneratedRegex(@"<(\w|\W)+>((\w|\W)+|)</\w+>", RegexOptions.IgnoreCase | RegexOptions.Compiled, "en-ZA")]
        private static partial Regex GetNonSelfClosingRegex();

        [GeneratedRegex(@"<((\w|\W)+|)/>", RegexOptions.IgnoreCase | RegexOptions.Compiled, "en-ZA")]
        private static partial Regex GetSelfClosingRegex();
    }
}