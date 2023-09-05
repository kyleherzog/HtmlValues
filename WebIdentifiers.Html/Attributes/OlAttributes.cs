namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the ol element.
/// </summary>
public class OlAttributes
{
    /// <summary>
    /// Gets the name of the reversed attribute.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Reversed(string? value) => HtmlAttributes.Reversed(value);

    /// <summary>
    /// Gets the name of the start attribute.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Start(string? value) => HtmlAttributes.Start(value);

    /// <summary>
    /// Gets the name of the type attribute.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Type(string? value) => HtmlAttributes.Type(value);
}