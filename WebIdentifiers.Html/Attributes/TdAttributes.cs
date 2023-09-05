namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the td element.
/// </summary>
public class TdAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>colspan</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute ColSpan(string? value = null) => HtmlAttributes.ColSpan(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>headers</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Headers(string? value = null) => HtmlAttributes.Headers(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>rowspan</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute RowSpan(string? value = null) => HtmlAttributes.RowSpan(value);
}