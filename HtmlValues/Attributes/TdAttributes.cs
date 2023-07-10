namespace HtmlValues.Attributes;

/// /// <summary>
/// Provides access to the attributes of the td element.
/// </summary>
public class TdAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the colspan attribute.
    /// </summary>
    public string ColSpan => HtmlAttributes.ColSpan;

    /// <summary>
    /// Gets the name of the headers attribute.
    /// </summary>
    public string Headers => HtmlAttributes.Headers;

    /// <summary>
    /// Gets the name of the rowspan attribute.
    /// </summary>
    public string RowSpan => HtmlAttributes.RowSpan;
}