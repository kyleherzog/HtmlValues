namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the td element.
/// </summary>
public class TdAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>colspan</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute ColSpan(string? value) => HtmlAttributes.ColSpan(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>headers</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Headers(string? value) => HtmlAttributes.Headers(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>rowspan</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute RowSpan(string? value) => HtmlAttributes.RowSpan(value);
}