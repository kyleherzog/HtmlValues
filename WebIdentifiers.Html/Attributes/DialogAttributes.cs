namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the dialog element.
/// </summary>
public class DialogAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the attribute name <c>open</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Open(string? value = null) => HtmlAttributes.Open(value);
}