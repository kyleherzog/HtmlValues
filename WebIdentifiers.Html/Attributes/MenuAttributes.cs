namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the menu element.
/// </summary>
public class MenuAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>label</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Label(string? value) => HtmlAttributes.Label(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>type</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Type(string? value) => HtmlAttributes.Type(value);
}