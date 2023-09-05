namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the fieldset element.
/// </summary>
public class FieldSetAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>disabled</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Disabled(string? value = null) => HtmlAttributes.Disabled(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>form</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Form(string? value = null) => HtmlAttributes.Form(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the attribute name <c>name</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Name(string? value = null) => HtmlAttributes.Name(value);
}