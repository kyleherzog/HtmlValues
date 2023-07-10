namespace HtmlValues.Attributes;

/// <summary>
/// Provides access to the attributes of the base element.
/// </summary>
public class BaseAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the href attribute.
    /// </summary>
    public string Href => HtmlAttributes.Href;

    /// <summary>
    /// Gets the name of the target attribute.
    /// </summary>
    public string Target => HtmlAttributes.Target;
}