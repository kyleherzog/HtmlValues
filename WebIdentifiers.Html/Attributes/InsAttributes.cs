namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the ins element.
/// </summary>
public class InsAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>cite</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Cite(string? value) => HtmlAttributes.Cite(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>datetime</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute DateTime(string? value) => HtmlAttributes.DateTime(value);
}