namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the meter element.
/// </summary>
public class MeterAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>form</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Form(string? value = null) => HtmlAttributes.Form(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>high</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute High(string? value = null) => HtmlAttributes.High(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>low</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Low(string? value = null) => HtmlAttributes.Low(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>max</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Max(string? value = null) => HtmlAttributes.Max(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>min</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Min(string? value = null) => HtmlAttributes.Min(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>optimum</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Optimum(string? value = null) => HtmlAttributes.Optimum(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>value</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Value(string? value = null) => HtmlAttributes.Value(value);
}