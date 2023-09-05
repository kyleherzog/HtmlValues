namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the form element.
/// </summary>
public class FormAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>accept-charset</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute AcceptCharset(string? value = null) => HtmlAttributes.AcceptCharset(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>action</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Action(string? value = null) => HtmlAttributes.Action(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>autocomplete</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute AutoComplete(string? value = null) => HtmlAttributes.AutoComplete(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>enctype</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute EncType(string? value = null) => HtmlAttributes.EncType(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>method</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Method(string? value = null) => HtmlAttributes.Method(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>name</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Name(string? value = null) => HtmlAttributes.Name(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>novalidate</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute NoValidate(string? value = null) => HtmlAttributes.NoValidate(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>rel</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Rel(string? value = null) => HtmlAttributes.Rel(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>target</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Target(string? value = null) => HtmlAttributes.Target(value);
}