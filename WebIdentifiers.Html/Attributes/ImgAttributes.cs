namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the img element.
/// </summary>
public class ImgAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>alt</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Alt(string? value = null) => HtmlAttributes.Alt(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>crossOrigin</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute CrossOrigin(string? value = null) => HtmlAttributes.CrossOrigin(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>decoding</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Decoding(string? value = null) => HtmlAttributes.Decoding(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>height</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Height(string? value = null) => HtmlAttributes.Height(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>ismap</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute IsMap(string? value = null) => HtmlAttributes.IsMap(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>loading</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Loading(string? value = null) => HtmlAttributes.Loading(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>referrerpolicy</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute ReferrerPolicy(string? value = null) => HtmlAttributes.ReferrerPolicy(value);

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
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>usemap</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute UseMap(string? value = null) => HtmlAttributes.UseMap(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>width</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Width(string? value = null) => HtmlAttributes.Width(value);
}