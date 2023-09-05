using System.Web;

namespace WebIdentifiers.Html;

/// <summary>
/// Represents an HTML attribute.
/// </summary>
public struct MarkupAttribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MarkupAttribute"/> struct.
    /// </summary>
    /// <param name="name">The name of the attribute.</param>
    /// <param name="value">An optional value to apply to the attribute.</param>
    public MarkupAttribute(string name, string? value = null)
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

    public static implicit operator string(MarkupAttribute attribute) => attribute.ToString();

    public static bool operator ==(MarkupAttribute? left, MarkupAttribute? right)
    {
        if (left is null && right is null)
        {
            return true;
        }

        return left?.Equals(right) ?? false;
    }

    public static bool operator !=(MarkupAttribute? left, MarkupAttribute? right)
    {
        return !(left == right);
    }

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

        if (obj is MarkupAttribute otherAttribute)
        {
            return Name == otherAttribute.Name
                && Value == otherAttribute.Value;
        }

        return false;
    }
}