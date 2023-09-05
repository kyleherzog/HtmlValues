namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the button element.
/// </summary>
public class ButtonAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the disabled attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Disabled(string? value = null) => HtmlAttributes.Disabled(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the form attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Form(string? value = null) => HtmlAttributes.Form(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the formaction attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute FormAction(string? value = null) => HtmlAttributes.FormAction(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the formenctype attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute FormEncType(string? value = null) => HtmlAttributes.FormEncType(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the formmethod attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute FormMethod(string? value = null) => HtmlAttributes.FormMethod(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the formnovalidate attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute FormNoValidate(string? value = null) => HtmlAttributes.FormNoValidate(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>formtarget</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute FormTarget(string? value = null) => HtmlAttributes.FormTarget(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>name</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Name(string? value = null) => HtmlAttributes.Name(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>type</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Type(string? value = null) => HtmlAttributes.Type(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>value</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Value(string? value = null) => HtmlAttributes.Value(value);
}