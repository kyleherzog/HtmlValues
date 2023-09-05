namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the blockquote element.
/// </summary>
public class BlockQuoteAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the cite attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Cite(string? value = null) => HtmlAttributes.Cite(value);
}