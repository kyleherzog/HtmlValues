namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the video element.
/// </summary>
public class VideoAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>autoplay</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute AutoPlay(string? value = null) => HtmlAttributes.AutoPlay(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>controls</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Controls(string? value = null) => HtmlAttributes.Controls(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>crossorigin</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute CrossOrigin(string? value = null) => HtmlAttributes.CrossOrigin(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>height</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Height(string? value = null) => HtmlAttributes.Height(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>loop</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Loop(string? value = null) => HtmlAttributes.Loop(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>muted</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Muted(string? value = null) => HtmlAttributes.Muted(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>poster</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Poster(string? value = null) => HtmlAttributes.Poster(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>preload</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Preload(string? value = null) => HtmlAttributes.Preload(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>src</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Src(string? value = null) => HtmlAttributes.Src(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>width</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Width(string? value = null) => HtmlAttributes.Width(value);
}