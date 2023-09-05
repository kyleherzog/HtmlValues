namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the del element.
/// </summary>
public class DelAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>cite</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Cite(string? value = null) => HtmlAttributes.Cite(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>datetime</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute DateTime(string? value = null) => HtmlAttributes.DateTime(value);
}