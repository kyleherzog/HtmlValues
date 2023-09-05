namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the textarea element.
/// </summary>
public class TextAreaAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>autocomplete</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute AutoComplete(string? value = null) => HtmlAttributes.AutoComplete(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>cols</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Cols(string? value = null) => HtmlAttributes.Cols(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>dirname</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute DirName(string? value = null) => HtmlAttributes.DirName(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>disabled</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Disabled(string? value = null) => HtmlAttributes.Disabled(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>form</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Form(string? value = null) => HtmlAttributes.Form(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>maxlength</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute MaxLength(string? value = null) => HtmlAttributes.MaxLength(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>minlength</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute MinLength(string? value = null) => HtmlAttributes.MinLength(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>name</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Name(string? value = null) => HtmlAttributes.Name(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>placeholder</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Placeholder(string? value = null) => HtmlAttributes.Placeholder(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>readonly</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute ReadOnly(string? value = null) => HtmlAttributes.ReadOnly(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>required</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Required(string? value = null) => HtmlAttributes.Required(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>rows</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Rows(string? value = null) => HtmlAttributes.Rows(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>wrap</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Wrap(string? value = null) => HtmlAttributes.Wrap(value);
}