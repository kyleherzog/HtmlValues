namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the del element.
/// </summary>
public class DelAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the attribute name <c>cite</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Cite(string? value) => HtmlAttributes.Cite(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the attribute name <c>datetime</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute DateTime(string? value) => HtmlAttributes.DateTime(value);
}