namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the audio element.
/// </summary>
public class AudioAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the autoplay attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute AutoPlay(string? value = null) => HtmlAttributes.AutoPlay(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the controls attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Controls(string? value = null) => HtmlAttributes.Controls(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the crossorigin attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute CrossOrigin(string? value = null) => HtmlAttributes.CrossOrigin(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the loop attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Loop(string? value = null) => HtmlAttributes.Loop(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the muted attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Muted(string? value = null) => HtmlAttributes.Muted(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the preload attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Preload(string? value = null) => HtmlAttributes.Preload(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the src attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Src(string? value = null) => HtmlAttributes.Src(value);
}