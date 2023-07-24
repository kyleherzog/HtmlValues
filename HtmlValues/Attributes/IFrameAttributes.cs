namespace HtmlValues.Attributes;

/// /// <summary>
/// Provides access to the attributes of the iframe element.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "The casing is appropriate given the tag name this targets")]
public class IFrameAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the allow attribute.
    /// </summary>
    public string Allow => HtmlAttributes.Allow;

    /// <summary>
    /// Gets the name of the allowfullscreen attribute.
    /// </summary>
    public string AllowFullScreen => HtmlAttributes.AllowFullScreen;

    /// <summary>
    /// Gets the name of the allowpaymentrequest attribute.
    /// </summary>
    public string AllowPaymentRequest => HtmlAttributes.AllowPaymentRequest;

    /// <summary>
    /// Gets the name of the csp attribute.
    /// </summary>
    public string Csp => HtmlAttributes.Csp;

    /// <summary>
    /// Gets the name of the height attribute.
    /// </summary>
    public string Height => HtmlAttributes.Height;

    /// <summary>
    /// Gets the name of the loading attribute.
    /// </summary>
    public string Loading => HtmlAttributes.Loading;

    /// <summary>
    /// Gets the name of the name attribute.
    /// </summary>
    public string Name => HtmlAttributes.Name;

    /// <summary>
    /// Gets the name of the referrerpolicy attribute.
    /// </summary>
    public string ReferrerPolicy => HtmlAttributes.ReferrerPolicy;

    /// <summary>
    /// Gets the name of the sandbox attribute.
    /// </summary>
    public string Sandbox => HtmlAttributes.Sandbox;

    /// <summary>
    /// Gets the name of the src attribute.
    /// </summary>
    public string Src => HtmlAttributes.Src;

    /// <summary>
    /// Gets the name of the srcdoc attribute.
    /// </summary>
    public string SrcDoc => HtmlAttributes.SrcDoc;

    /// <summary>
    /// Gets the name of the width attribute.
    /// </summary>
    public string Width => HtmlAttributes.Width;
}