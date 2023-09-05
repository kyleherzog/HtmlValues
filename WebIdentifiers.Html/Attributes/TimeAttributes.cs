namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the time element.
/// </summary>
public class TimeAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>datetime</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute DateTime(string? value = null) => HtmlAttributes.DateTime(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>pubdate</c> attribute name and an optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute PubDate(string? value = null) => HtmlAttributes.PubDate(value);
}