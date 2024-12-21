using EmployeeManagement.Domain.Common;
using EmployeeManagement.Domain.ValueObjects;

namespace EmployeeManagement.Domain.Entities;

public abstract class Employee : AuditableEntity
{
    public required string Name { get; set; }
    public required Email Email { get; set; }
    public required Role Role { get; set; }
}
