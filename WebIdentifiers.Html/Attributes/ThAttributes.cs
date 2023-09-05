namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the th element.
/// </summary>
public class ThAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>abbr</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Abbr(string? value) => HtmlAttributes.Abbr(value);

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

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>scope</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Scope(string? value) => HtmlAttributes.Scope(value);
}