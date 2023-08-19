namespace WebIdentifiers.Html.AttributeValues;

/// <summary>
/// Provides access to predefined values for the <c>wrap</c> attribute.
/// </summary>
public class WrapValues
{
    /// <summary>
    /// Gets the predefined <c>hard</c> attribute value, indicating that a newline character will be
    /// added after the number of characters indicated by the cols attribute.
    /// </summary>
    public string Hard => HtmlAttributeValues.Hard;

    /// <summary>
    /// Gets the predefined <c>soft</c> attribute value.
    /// </summary>
    public string Soft => HtmlAttributeValues.Soft;
}