namespace WebIdentifiers.Html.AttributeValues;

/// <summary>
/// Gets the predefined <c>capture</c> attribute value.
/// </summary>
public class CaptureValues
{
    /// <summary>
    /// Gets the predefined <c>environment</c> attribute value, indicating that the device's outward-facing camera and/or microphone should be used.
    /// </summary>
    public string Environment => HtmlAttributeValues.Environment;

    /// <summary>
    /// Gets the predefined <c>user</c> attribute value, indicating that the user-facing camera and/or microphone should be used.
    /// </summary>
    public string User => HtmlAttributeValues.User;
}