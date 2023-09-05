namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the label element.
/// </summary>
public class LabelAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>for</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute For(string? value) => HtmlAttributes.For(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>form</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Form(string? value) => HtmlAttributes.Form(value);
}