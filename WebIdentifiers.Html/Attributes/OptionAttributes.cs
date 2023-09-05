namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the option element.
/// </summary>
public class OptionAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the "disabled" attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Disabled(string? value = null) => HtmlAttributes.Disabled(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the "label" attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Label(string? value = null) => HtmlAttributes.Label(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the "selected" attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Selected(string? value = null) => HtmlAttributes.Selected(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the "value" attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Value(string? value = null) => HtmlAttributes.Value(value);
}