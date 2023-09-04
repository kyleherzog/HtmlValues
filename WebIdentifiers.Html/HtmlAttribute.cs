using System.Web;

namespace WebIdentifiers.Html;

/// <summary>
/// Represents an HTML attribute.
/// </summary>
public struct HtmlAttribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HtmlAttribute"/> class.
    /// </summary>
    /// <param name="name">The name of the attribute.</param>
    /// <param name="value">An optional value to apply to the attribute.</param>
    public HtmlAttribute(string name, string? value = null)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Value cannot be empty.", nameof(name));
        }

        Name = name;
        Value = value;
    }

    /// <summary>
    /// Gets the name of the attribute.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the value of the attribute.
    /// </summary>
    public string? Value { get; }

    public static implicit operator string(HtmlAttribute attribute) => attribute.ToString();

    /// <inheritdoc/>
    public override string ToString()
    {
        if (!string.IsNullOrEmpty(Value))
        {
            return $"{Name}=\"{HttpUtility.HtmlAttributeEncode(Value)}\"";
        }

        return Name;
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj is string otherString)
        {
            return ToString().Equals(otherString);
        }

        if (obj is HtmlAttribute otherAttribute)
        {
            return Name == otherAttribute.Name
                && Value == otherAttribute.Value;
        }

        return false;
    }
}