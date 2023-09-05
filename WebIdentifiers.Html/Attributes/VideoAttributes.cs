namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the video element.
/// </summary>
public class VideoAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>autoplay</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute AutoPlay(string? value) => HtmlAttributes.AutoPlay(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>controls</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Controls(string? value) => HtmlAttributes.Controls(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>crossorigin</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute CrossOrigin(string? value) => HtmlAttributes.CrossOrigin(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>height</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Height(string? value) => HtmlAttributes.Height(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>loop</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Loop(string? value) => HtmlAttributes.Loop(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>muted</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Muted(string? value) => HtmlAttributes.Muted(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>poster</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Poster(string? value) => HtmlAttributes.Poster(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>preload</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Preload(string? value) => HtmlAttributes.Preload(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>src</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Src(string? value) => HtmlAttributes.Src(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>width</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Width(string? value) => HtmlAttributes.Width(value);
}