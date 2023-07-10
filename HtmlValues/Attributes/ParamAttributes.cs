namespace HtmlValues.Attributes;

/// <summary>
/// Provides access to the attributes of the param element.
/// </summary>
public class ParamAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the name attribute.
    /// </summary>
    public string Name => HtmlAttributes.Name;

    /// <summary>
    /// Gets the name of the value attribute.
    /// </summary>
    public string Value => HtmlAttributes.Value;
}