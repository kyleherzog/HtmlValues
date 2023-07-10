namespace HtmlValues.Attributes;

/// <summary>
/// Provides access to the attributes of the canvas element.
/// </summary>
public class CanvasAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the height attribute.
    /// </summary>
    public string Height => HtmlAttributes.Height;

    /// <summary>
    /// Gets the name of the width attribute.
    /// </summary>
    public string Width => HtmlAttributes.Width;
}