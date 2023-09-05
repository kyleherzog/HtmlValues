namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the optgroup element.
/// </summary>
public class OptGroupAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>disabled</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Disabled(string? value = null) => HtmlAttributes.Disabled(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>label</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Label(string? value = null) => HtmlAttributes.Label(value);
}