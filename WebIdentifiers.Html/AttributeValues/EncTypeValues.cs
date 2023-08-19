namespace WebIdentifiers.Html.AttributeValues;

/// <summary>
/// Provides access to predefined values of the <c>enctype</c> attribute.
/// </summary>
public class EncTypeValues
{
    /// <summary>
    /// Gets the predefined <c>application/x-www-form-urlencoded</c> attribute value.
    /// </summary>
    public string ApplicationXWwwFormUrlencoded => HtmlAttributeValues.ApplicationXWwwFormUrlencoded;

    /// <summary>
    /// Gets the predefined <c>multipart/form-data</c> attribute value, which allows <c>input</c> elements to upload file data.
    /// </summary>
    public string MultipartFormData => HtmlAttributeValues.MultipartFormData;

    /// <summary>
    /// Gets the predefined <c>text/plain</c> attribute value, which is an ambiguous format of human-readable content not reliably interpretable by computer.
    /// </summary>
    public string TextPlain => HtmlAttributeValues.TextPlain;
}