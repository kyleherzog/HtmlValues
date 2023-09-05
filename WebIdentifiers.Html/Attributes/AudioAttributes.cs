namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the audio element.
/// </summary>
public class AudioAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the autoplay attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute AutoPlay(string? value = null) => HtmlAttributes.AutoPlay(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the controls attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Controls(string? value = null) => HtmlAttributes.Controls(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the crossorigin attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute CrossOrigin(string? value = null) => HtmlAttributes.CrossOrigin(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the loop attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Loop(string? value = null) => HtmlAttributes.Loop(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the muted attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Muted(string? value = null) => HtmlAttributes.Muted(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the preload attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Preload(string? value = null) => HtmlAttributes.Preload(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the src attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Src(string? value = null) => HtmlAttributes.Src(value);
}