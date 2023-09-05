namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the col element.
/// </summary>
public class ColAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>span</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Span(string? value = null) => HtmlAttributes.Span(value);
}