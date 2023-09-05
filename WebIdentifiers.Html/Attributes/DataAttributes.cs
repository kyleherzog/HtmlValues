namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the data element.
/// </summary>
public class DataAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the attribute name <c>value</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Value(string? value) => HtmlAttributes.Value(value);
}