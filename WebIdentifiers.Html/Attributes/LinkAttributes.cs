namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the link element.
/// </summary>
public class LinkAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>crossorigin</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute CrossOrigin(string? value = null) => HtmlAttributes.CrossOrigin(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>href</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Href(string? value = null) => HtmlAttributes.Href(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>hreflang</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute HrefLang(string? value = null) => HtmlAttributes.HrefLang(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>media</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Media(string? value = null) => HtmlAttributes.Media(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>referrerpolicy</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute ReferrerPolicy(string? value = null) => HtmlAttributes.ReferrerPolicy(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>rel</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Rel(string? value = null) => HtmlAttributes.Rel(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>sizes</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Sizes(string? value = null) => HtmlAttributes.Sizes(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>type</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Type(string? value = null) => HtmlAttributes.Type(value);
}