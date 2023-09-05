namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the map element.
/// </summary>
public class MapAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>name</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Name(string? value = null) => HtmlAttributes.Name(value);
}