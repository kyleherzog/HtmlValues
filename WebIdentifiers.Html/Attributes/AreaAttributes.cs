namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the area element.
/// </summary>
public class AreaAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>alt</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Alt(string? value = null) => HtmlAttributes.Alt(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>coords</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Coords(string? value = null) => HtmlAttributes.Coords(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>download</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Download(string? value = null) => HtmlAttributes.Download(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>href</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Href(string? value = null) => HtmlAttributes.Href(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>hrefland</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute HrefLang(string? value = null) => HtmlAttributes.HrefLang(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>media</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Media(string? value = null) => HtmlAttributes.Media(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>rel</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Rel(string? value = null) => HtmlAttributes.Rel(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>shape</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Shape(string? value = null) => HtmlAttributes.Shape(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>target</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Target(string? value = null) => HtmlAttributes.Target(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>type</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Type(string? value = null) => HtmlAttributes.Type(value);
}