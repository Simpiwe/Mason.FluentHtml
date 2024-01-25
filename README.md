# FluentHtml

FluentHtml is a simple, unambitious library for building HTML documents in a fluent manner.

## Getting Started

```
HtmlBuilder htmlBuilder = new HtmlBuilder();

htmlBuilder.Table(new { @class = "table-primary" }, table =>
{
    table.Tbody(tbody =>
    {
        tbody.Tr(tr =>
        {
            tr.Td(td => td.Content("Cell 1"));
            tr.Td(td => td.Content("Cell 2"));
        });
    });
});

string html = htmlBuilder.ToString(); //<table class="table-primary"><tbody><tr><td>Cell 1</td><td>Cell 2</td></tr></tbody></table>
```

This example shows how to use FluentHtml to build a basic HTML table. 

## Features

- **Fluent Interface:** Build HTML documents with a natural and intuitive syntax.
- **No Dependencies:** The library has no external dependencies and is designed to be lightweight.
- **Target Framework:** FluentHtml targets .NET Standard 2.0, ensuring compatibility across various platforms.

## Installation

To install FluentHtml, you can use the following [NuGet](https://www.nuget.org/) command:

```
dotnet add package FluentHtml --version 1.0.0
```

## License

FluentHtml is licensed under the [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.en.html#license-text).
