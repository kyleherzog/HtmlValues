namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the meta element.
/// </summary>
public class MetaAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the charset attribute.
    /// </summary>
    public string CharSet => HtmlAttributes.CharSet;

    /// <summary>
    /// Gets the name of the content attribute.
    /// </summary>
    public string Content => HtmlAttributes.Content;

    /// <summary>
    /// Gets the name of the http-equiv attribute.
    /// </summary>
    public string HttpEquiv => HtmlAttributes.HttpEquiv;

    /// <summary>
    /// Gets the name of the name attribute.
    /// </summary>
    public string Name => HtmlAttributes.Name;
}