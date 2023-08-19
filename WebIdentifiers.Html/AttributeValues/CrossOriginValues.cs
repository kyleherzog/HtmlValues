namespace WebIdentifiers.Html.AttributeValues;

/// <summary>
/// Provides access to predefined values of <c>crossorigin</c> attribute.
/// </summary>

public class CrossOriginValues
{
    /// <summary>
    /// Gets the predefined <c>anonymous</c> attribute value, where the request uses CORS headers and credentials
    /// flag is set to <c>same-origin</c>. There is no exchange of user credentials via cookies, client-side
    /// SSL certificates or HTTP authentication, unless destination is the same origin.
    /// </summary>
    public string Anonymous => HtmlAttributeValues.Anonymous;

    /// <summary>
    /// Gets the predefined <c>use-credentials</c> attribute value, where the request uses CORS headers, credentials
    /// flag is set to <c>include</c> and user credentials are always included.
    /// </summary>
    public string UseCredentials => HtmlAttributeValues.UseCredentials;
}