namespace HtmlValues.Attributes;

/// /// <summary>
/// Provides access to the attributes of the track element.
/// </summary>
public class TrackAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the default attribute.
    /// </summary>
    public string Default => HtmlAttributes.Default;

    /// <summary>
    /// Gets the name of the kind attribute.
    /// </summary>
    public string Kind => HtmlAttributes.Kind;

    /// <summary>
    /// Gets the name of the label attribute.
    /// </summary>
    public string Label => HtmlAttributes.Label;

    /// <summary>
    /// Gets the name of the src attribute.
    /// </summary>
    public string Src => HtmlAttributes.Src;

    /// <summary>
    /// Gets the name of the srclang attribute.
    /// </summary>
    public string SrcLang => HtmlAttributes.SrcLang;
}