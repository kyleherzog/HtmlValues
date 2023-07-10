namespace HtmlValues.Attributes;

/// <summary>
/// Provides access to the attributes of the label element.
/// </summary>
public class LabelAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the for attribute.
    /// </summary>
    public string For => HtmlAttributes.For;

    /// <summary>
    /// Gets the name of the form attribute.
    /// </summary>
    public string Form => HtmlAttributes.Form;
}