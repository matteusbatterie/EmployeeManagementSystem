using EmployeeManagement.Domain.Common;

namespace EmployeeManagement.Domain.Entities;

public class Role(string name, string description) : AuditableEntity
{
    public required string Name { get; set; } = name;
    public required string Description { get; set; } = description;

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        var otherRole = (Role)obj;
        return Name == otherRole.Name && Description == otherRole.Description;
    }

    public override int GetHashCode() => HashCode.Combine(Name, Description);
}

