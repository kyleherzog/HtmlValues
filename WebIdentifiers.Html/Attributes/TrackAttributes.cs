namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the track element.
/// </summary>
public class TrackAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>default</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Default(string? value) => HtmlAttributes.Default(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>kind</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Kind(string? value) => HtmlAttributes.Kind(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>label</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Label(string? value) => HtmlAttributes.Label(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>src</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Src(string? value) => HtmlAttributes.Src(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>srclang</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute SrcLang(string? value) => HtmlAttributes.SrcLang(value);
}