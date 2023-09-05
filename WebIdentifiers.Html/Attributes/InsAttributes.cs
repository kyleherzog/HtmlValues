namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the ins element.
/// </summary>
public class InsAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>cite</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Cite(string? value = null) => HtmlAttributes.Cite(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>datetime</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute DateTime(string? value = null) => HtmlAttributes.DateTime(value);
}