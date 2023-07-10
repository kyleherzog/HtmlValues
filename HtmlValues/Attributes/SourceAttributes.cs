namespace HtmlValues.Attributes;

/// /// <summary>
/// Provides access to the attributes of the source element.
/// </summary>
public class SourceAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the media attribute.
    /// </summary>
    public string Media => HtmlAttributes.Media;

    /// <summary>
    /// Gets the name of the sizes attribute.
    /// </summary>
    public string Sizes => HtmlAttributes.Sizes;

    /// <summary>
    /// Gets the name of the src attribute.
    /// </summary>
    public string Src => HtmlAttributes.Src;

    /// <summary>
    /// Gets the name of the srcset attribute.
    /// </summary>
    public string SrcSet => HtmlAttributes.SrcSet;

    /// <summary>
    /// Gets the name of the type attribute.
    /// </summary>
    public string Type => HtmlAttributes.Type;
}