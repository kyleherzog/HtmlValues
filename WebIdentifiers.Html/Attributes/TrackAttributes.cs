namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the track element.
/// </summary>
public class TrackAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>default</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Default(string? value = null) => HtmlAttributes.Default(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>kind</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Kind(string? value = null) => HtmlAttributes.Kind(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>label</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Label(string? value = null) => HtmlAttributes.Label(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>src</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Src(string? value = null) => HtmlAttributes.Src(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>srclang</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute SrcLang(string? value = null) => HtmlAttributes.SrcLang(value);
}