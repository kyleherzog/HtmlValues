namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the source element.
/// </summary>
public class SourceAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>media</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Media(string? value) => HtmlAttributes.Media(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>sizes</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Sizes(string? value) => HtmlAttributes.Sizes(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>src</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Src(string? value) => HtmlAttributes.Src(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>srcset</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute SrcSet(string? value) => HtmlAttributes.SrcSet(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>type</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Type(string? value) => HtmlAttributes.Type(value);
}