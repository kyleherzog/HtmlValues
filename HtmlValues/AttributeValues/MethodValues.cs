namespace HtmlValues.AttributeValues;

/// <summary>
/// Provides access to predefined values of the <c>method</c> attribute.
/// </summary>
public class MethodValues
{
    /// <summary>
    /// Gets the predefined <c>dialog</c> attribute value. This is for use in a <c>dialog</c>. It closes the dialog and causes a <c>submit</c>
    /// event to be fired on submission, without submitting data or clearing the form.
    /// </summary>
    public string Dialog => HtmlAttributeValues.Dialog;

    /// <summary>
    /// Gets the predefined <c>get</c> attribute value. This method sends the form data as a query string.
    /// </summary>
    public string Get => HtmlAttributeValues.Get;

    /// <summary>
    /// Gets the predefined <c>post</c> attribute value. This method sends the form data as a body of the request.
    /// </summary>
    public string Post => HtmlAttributeValues.Post;
}