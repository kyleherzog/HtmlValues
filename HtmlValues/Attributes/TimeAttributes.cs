namespace HtmlValues.Attributes;

/// <summary>
/// Provides access to the attributes of the time element.
/// </summary>
public class TimeAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the datetime attribute.
    /// </summary>
    public string DateTime => HtmlAttributes.DateTime;

    /// <summary>
    /// Gets the name of the pubdate attribute.
    /// </summary>
    public string PubDate => HtmlAttributes.PubDate;
}