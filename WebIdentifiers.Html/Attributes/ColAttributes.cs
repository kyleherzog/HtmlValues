namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the col element.
/// </summary>
public class ColAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>span</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Span(string? value) => HtmlAttributes.Span(value);
}