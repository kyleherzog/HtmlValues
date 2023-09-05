namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the source element.
/// </summary>
public class SourceAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>media</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Media(string? value = null) => HtmlAttributes.Media(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>sizes</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Sizes(string? value = null) => HtmlAttributes.Sizes(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>src</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Src(string? value = null) => HtmlAttributes.Src(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>srcset</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute SrcSet(string? value = null) => HtmlAttributes.SrcSet(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>type</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Type(string? value = null) => HtmlAttributes.Type(value);
}