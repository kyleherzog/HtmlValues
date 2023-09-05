namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the meta element.
/// </summary>
public class MetaAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>charset</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute CharSet(string? value = null) => HtmlAttributes.CharSet(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>content</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Content(string? value = null) => HtmlAttributes.Content(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>http-equiv</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute HttpEquiv(string? value = null) => HtmlAttributes.HttpEquiv(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>name</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Name(string? value = null) => HtmlAttributes.Name(value);
}