using System;
using System.Collections.Generic;
using System.Text;

namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the form element.
/// </summary>
public class FormAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the accept-charset attribute.
    /// </summary>
    public string AcceptCharset => HtmlAttributes.AcceptCharset;

    /// <summary>
    /// Gets the name of the action attribute.
    /// </summary>
    public string Action => HtmlAttributes.Action;

    /// <summary>
    /// Gets the name of the autocomplete attribute.
    /// </summary>
    public string AutoComplete => HtmlAttributes.AutoComplete;

    /// <summary>
    /// Gets the name of the enctype attribute.
    /// </summary>
    public string EncType => HtmlAttributes.EncType;

    /// <summary>
    /// Gets the name of the method attribute.
    /// </summary>
    public string Method => HtmlAttributes.Method;

    /// <summary>
    /// Gets the name of the name attribute.
    /// </summary>
    public string Name => HtmlAttributes.Name;

    /// <summary>
    /// Gets the name of the novalidate attribute.
    /// </summary>
    public string NoValidate => HtmlAttributes.NoValidate;

    /// <summary>
    /// Gets the name of the rel attribute.
    /// </summary>
    public string Rel => HtmlAttributes.Rel;

    /// <summary>
    /// Gets the name of the target attribute.
    /// </summary>
    public string Target => HtmlAttributes.Target;
}