using System.Text.RegularExpressions;

namespace EmployeeManagement.Domain.ValueObjects;

public partial class Email
{
    public string Value { get; private set; }

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Email address cannot be empty or whitespace.", nameof(value));

        if (!IsValidEmail(value))
            throw new ArgumentException("Invalid email address format.", nameof(value));

        Value = value;
    }


    [GeneratedRegex(@"^[\w-\.]+@([\w-]+\.)+[a-zA-Z]{2,7}$")]
    private static partial Regex EmailRegex();

    private static bool IsValidEmail(string email)
    {
        var regex = EmailRegex();
        return regex.IsMatch(email);
    }

    #region Overrides

    public override int GetHashCode() => Value.ToLower().GetHashCode();
    public override string ToString() => Value;

    #endregion 
}