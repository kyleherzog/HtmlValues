namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the iframe element.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "The casing is appropriate given the tag name this targets")]
public class IFrameAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>allow</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Allow(string? value = null) => HtmlAttributes.Allow(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>allowfullscreen</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute AllowFullScreen(string? value = null) => HtmlAttributes.AllowFullScreen(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>allowpaymentrequest</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute AllowPaymentRequest(string? value = null) => HtmlAttributes.AllowPaymentRequest(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>csp</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Csp(string? value = null) => HtmlAttributes.Csp(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>height</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Height(string? value = null) => HtmlAttributes.Height(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>loading</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Loading(string? value = null) => HtmlAttributes.Loading(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>name</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Name(string? value = null) => HtmlAttributes.Name(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>referrerpolicy</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute ReferrerPolicy(string? value = null) => HtmlAttributes.ReferrerPolicy(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>sandbox</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Sandbox(string? value = null) => HtmlAttributes.Sandbox(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>src</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Src(string? value = null) => HtmlAttributes.Src(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>srcdoc</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute SrcDoc(string? value = null) => HtmlAttributes.SrcDoc(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>width</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Width(string? value = null) => HtmlAttributes.Width(value);
}