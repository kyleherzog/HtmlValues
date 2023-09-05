namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the output element.
/// </summary>
public class OutputAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the "for" attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute For(string? value) => HtmlAttributes.For(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the "form" attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Form(string? value) => HtmlAttributes.Form(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the "name" attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Name(string? value) => HtmlAttributes.Name(value);
}