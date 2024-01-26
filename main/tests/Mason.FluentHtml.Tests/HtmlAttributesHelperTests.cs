using System.Dynamic;
using static Mason.FluentHtml.HtmlAttributesHelper;

namespace Mason.FluentHtml.Tests
{
    public class HtmlAttributesHelperTests
    {
        [Fact]
        public void ReadAttributes_ReturnsEmptyString_WhenAttributesIsNull()
        {
            // Arrange
            object? attributes = null;

            // Act
            string result = ReadAttributes(attributes);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ReadAttributes_ReturnsString_WhenAttributesIsString()
        {
            // Arrange
            object? attributes = "test";

            // Act
            string result = ReadAttributes(attributes);

            // Assert
            Assert.Equal("test", result);
        }

        [Fact]
        public void ReadAttributes_ReturnsAttributes_WhenAttributesIsDictionary()
        {
            // Arrange
            object? attributes = new Dictionary<string, string> { { "key", "value" } };

            // Act
            string result = ReadAttributes(attributes);

            // Assert
            Assert.Equal(" key=\"value\"", result);
        }

        [Fact]
        public void ReadAttributes_ThrowsNotSupportedException_WhenAttributesIsUnsupportedType()
        {
            // Arrange
            object? attributes = new List<string>();

            // Act & Assert
            Assert.Throws<NotSupportedException>(() => HtmlAttributesHelper.ReadAttributes(attributes));
        }

        [Fact]
        public void ReadAttributes_ReturnsAttributes_WhenAttributesIsAnonymousType()
        {
            // Arrange
            object? attributes = new { key = "value" };

            // Act
            string result = ReadAttributes(attributes);

            // Assert
            Assert.Equal(" key=\"value\"", result);
        }

        [Fact]
        public void ReadAttributes_RemovesNamePrefix_WhenNameStartsWithAtSymbol()
        {
            // Arrange
            object? attributes = new { @key = "value" };

            // Act
            string result = ReadAttributes(attributes);

            // Assert
            Assert.Equal(" key=\"value\"", result);
        }

        [Fact]
        public void ReadAttributes_ReturnsAttributes_WhenAttributesIsExpandoObject()
        {
            // Arrange
            dynamic attributes = new ExpandoObject();
            attributes.key = "value";

            // Act
            string result = ReadAttributes(attributes);

            // Assert
            Assert.Equal(" key=\"value\"", result);
        }

        [Fact]
        public void ReadAttributes_ReturnsAttributesWithoutValue_WhenValueIsNull()
        {
            // Arrange
            object? attributes = new { key = (string?)null };

            // Act
            string result = ReadAttributes(attributes);

            // Assert
            Assert.Equal(" key", result);
        }
    }
}
