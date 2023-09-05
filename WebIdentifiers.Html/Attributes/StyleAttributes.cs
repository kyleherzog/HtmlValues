namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the style element.
/// </summary>
public class StyleAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>media</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Media(string? value = null) => HtmlAttributes.Media(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>nonce</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Nonce(string? value = null) => HtmlAttributes.Nonce(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>type</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Type(string? value = null) => HtmlAttributes.Type(value);
}