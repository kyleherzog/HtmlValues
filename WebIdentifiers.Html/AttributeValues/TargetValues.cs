namespace WebIdentifiers.Html.AttributeValues;

/// /// <summary>
/// Provides access to predefined values for the <c>target</c> attribute.
/// </summary>
public class TargetValues
{
#pragma warning disable SA1309 // Field names should not begin with underscore Justification: We want the member names to match the HTML attribute values.
    /// <summary>
    /// Gets the predefined <c>_blank</c> attribute value.
    /// </summary>
    public string _Blank => HtmlAttributeValues._Blank;

    /// <summary>
    /// Gets the predefined <c>_parent</c> attribute value.
    /// </summary>
    public string _Parent => HtmlAttributeValues._Parent;

    /// <summary>
    /// Gets the predefined <c>_self</c> attribute value.
    /// </summary>
    public string _Self => HtmlAttributeValues._Self;

    /// <summary>
    /// Gets the predefined <c>_top</c> attribute value.
    /// </summary>
    public string _Top => HtmlAttributeValues._Top;
#pragma warning restore SA1309 // Field names should not begin with underscore
}