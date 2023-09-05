namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the li element.
/// </summary>
public class LiAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>value</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Value(string? value) => HtmlAttributes.Value(value);
}