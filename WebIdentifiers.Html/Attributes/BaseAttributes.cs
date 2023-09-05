namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the base element.
/// </summary>
public class BaseAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the href attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Href(string? value = null) => HtmlAttributes.Href(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the target attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Target(string? value = null) => HtmlAttributes.Target(value);
}