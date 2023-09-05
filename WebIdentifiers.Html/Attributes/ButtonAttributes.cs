namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the button element.
/// </summary>
public class ButtonAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the disabled attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Disabled(string? value) => HtmlAttributes.Disabled(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the form attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Form(string? value) => HtmlAttributes.Form(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the formaction attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute FormAction(string? value) => HtmlAttributes.FormAction(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the formenctype attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute FormEncType(string? value) => HtmlAttributes.FormEncType(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the formmethod attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute FormMethod(string? value) => HtmlAttributes.FormMethod(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the formnovalidate attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute FormNoValidate(string? value) => HtmlAttributes.FormNoValidate(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>formtarget</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute FormTarget(string? value) => HtmlAttributes.FormTarget(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>name</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Name(string? value) => HtmlAttributes.Name(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>type</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Type(string? value) => HtmlAttributes.Type(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>value</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Value(string? value) => HtmlAttributes.Value(value);
}