namespace HtmlValues.Attributes;

/// <summary>
/// Provides access to the attributes of the optgroup element.
/// </summary>
public class OptGroupAttributes : GlobalAttributes
{
    ///  <summary>
    /// Gets the name of the disabled attribute.
    /// </summary>
    public string Disabled => HtmlAttributes.Disabled;

    /// <summary>
    /// Gets the name of the label attribute.
    /// </summary>
    public string Label => HtmlAttributes.Label;
}