namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the output element.
/// </summary>
public class OutputAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the for attribute.
    /// </summary>
    public string For => HtmlAttributes.For;

    /// <summary>
    /// Gets the name of the form attribute.
    /// </summary>
    public string Form => HtmlAttributes.Form;

    /// <summary>
    /// Gets the name of the name attribute.
    /// </summary>
    public string Name => HtmlAttributes.Name;
}