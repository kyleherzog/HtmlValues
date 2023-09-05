namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the colgroup element.
/// </summary>
public class ColGroupAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> instance with the attribute name <c>span</c> and an optional value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Span(string? value = null) => HtmlAttributes.Span(value);
}