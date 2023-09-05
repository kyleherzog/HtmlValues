namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the q element.
/// </summary>
public class QAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>cite</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Cite(string? value = null) => HtmlAttributes.Cite(value);
}