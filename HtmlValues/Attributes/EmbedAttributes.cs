namespace HtmlValues.Attributes;

/// /// <summary>
/// Provides access to the attributes of the embed element.
/// </summary>
public class EmbedAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the height attribute.
    /// </summary>
    public string Height => HtmlAttributes.Height;

    /// <summary>
    /// Gets the name of the src attribute.
    /// </summary>
    public string Src => HtmlAttributes.Src;

    /// <summary>
    /// Gets the name of the type attribute.
    /// </summary>
    public string Type => HtmlAttributes.Type;

    /// <summary>
    /// Gets the name of the width attribute.
    /// </summary>
    public string Width => HtmlAttributes.Width;
}