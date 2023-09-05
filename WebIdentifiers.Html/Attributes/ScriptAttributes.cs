namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the script element.
/// </summary>
public class ScriptAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>async</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Async(string? value = null) => HtmlAttributes.Async(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>crossorigin</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute CrossOrigin(string? value = null) => HtmlAttributes.CrossOrigin(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>defer</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Defer(string? value = null) => HtmlAttributes.Defer(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>integrity</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Integrity(string? value = null) => HtmlAttributes.Integrity(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>nomodule</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute NoModule(string? value = null) => HtmlAttributes.NoModule(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>nonce</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Nonce(string? value = null) => HtmlAttributes.Nonce(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>referrerpolicy</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute ReferrerPolicy(string? value = null) => HtmlAttributes.ReferrerPolicy(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>src</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Src(string? value = null) => HtmlAttributes.Src(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>type</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Type(string? value = null) => HtmlAttributes.Type(value);
}