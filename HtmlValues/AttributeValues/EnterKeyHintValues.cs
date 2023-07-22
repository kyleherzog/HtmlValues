using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlValues.AttributeValues;

/// /// <summary>
/// Provides access to predefined values for the <c>enterkeyhint</c> attribute.
/// </summary>
public class EnterKeyHintValues
{
    /// <summary>
    /// Gets the predefined <c>enter</c> attribute value, typically used for inserting a new line.
    /// </summary>
    public string Enter => HtmlAttributeValues.Enter;

    /// <summary>
    /// Gets the predefined <c>done</c> attribute value, typically meaning there 
    /// is nothing more to input and the input method editor will be closed.
    /// </summary>
    public string Done => HtmlAttributeValues.Done;

    /// <summary>
    /// Gets the predefined <c>go</c> attribute value, typically meaning to take
    /// the user to the target of the text they typed.
    /// </summary>
    public string Go => HtmlAttributeValues.Go;

    /// <summary>
    /// Gets the predefined <c>next</c> attribute value, typically taking the user to the 
    /// next field that will accept text.
    /// </summary>
    public string Next => HtmlAttributeValues.Next;

    /// <summary>
    /// Gets the predefined <c>previous</c> attribute value, typically taking the user to the 
    /// previous field that will accept text.
    /// </summary>
    public string Previous => HtmlAttributeValues.Previous;

    /// <summary>
    /// Gets the predefined <c>search</c> attribute value, typically taking the user to the
    /// results of searching for the text they have typed.
    /// </summary>
    public string Search => HtmlAttributeValues.Search;

    /// <summary>
    /// Gets the predefined <c>send</c> attribute value, typically delivering the text to its target.
    /// </summary>
    public string Send => HtmlAttributeValues.Send;
}