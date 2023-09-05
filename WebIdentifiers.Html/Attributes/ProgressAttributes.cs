namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the progress element.
/// </summary>
public class ProgressAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>max</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Max(string? value = null) => HtmlAttributes.Max(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>value</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Value(string? value = null) => HtmlAttributes.Value(value);
}