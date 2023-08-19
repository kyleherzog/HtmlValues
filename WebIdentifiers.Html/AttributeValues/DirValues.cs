using System;
using System.Collections.Generic;
using System.Text;

namespace WebIdentifiers.Html.AttributeValues;

/// <summary>
/// Provides access to predefined values of the <c>dir</c> attribute.
/// </summary>
public class DirValues
{
    /// <summary>
    /// Gets the predefined <c>auto</c> attribute value, which lets the user agent decide the text direction, based on the content.
    /// </summary>
    public string Auto => HtmlAttributeValues.Auto;

    /// <summary>
    /// Gets the predefined <c>ltr</c> attribute value which indicates left-to-right text direction.
    /// </summary>
    public string Ltr => HtmlAttributeValues.Ltr;

    /// <summary>
    /// Gets the predefined <c>rtl</c> attribute value which indicates right-to-left text direction.
    /// </summary>
    public string Rtl => HtmlAttributeValues.Rtl;

}
