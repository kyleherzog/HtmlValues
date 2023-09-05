namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the select element.
/// </summary>
public class SelectAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>autocomplete</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute AutoComplete(string? value = null) => HtmlAttributes.AutoComplete(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>disabled</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Disabled(string? value = null) => HtmlAttributes.Disabled(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>form</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Form(string? value = null) => HtmlAttributes.Form(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>multiple</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Multiple(string? value = null) => HtmlAttributes.Multiple(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>name</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Name(string? value = null) => HtmlAttributes.Name(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>required</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Required(string? value = null) => HtmlAttributes.Required(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>size</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Size(string? value = null) => HtmlAttributes.Size(value);
}