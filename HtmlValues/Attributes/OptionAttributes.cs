using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlValues.Attributes;

/// /// <summary>
/// Provides access to the attributes of the option element.
/// </summary>
public class OptionAttributes : GlobalAttributes
{
    /// <summary>
    /// Gets the name of the disabled attribute.
    /// </summary>
    public string Disabled => HtmlAttributes.Disabled;

    /// <summary>
    /// Gets the name of the label attribute.
    /// </summary>
    public string Label => HtmlAttributes.Label;

    /// <summary>
    /// Gets the name of the selected attribute.
    /// </summary>
    public string Selected => HtmlAttributes.Selected;

    /// <summary>
    /// Gets the name of the value attribute.
    /// </summary>
    public string Value => HtmlAttributes.Value;
}