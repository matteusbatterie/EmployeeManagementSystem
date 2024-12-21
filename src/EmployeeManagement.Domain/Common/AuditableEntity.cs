namespace EmployeeManagement.Domain.Common;

public abstract class AuditableEntity : BaseEntity
{
    public DateTime CreatedDate { get; set; }
    public required string CreatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }    
    public string? UpdatedBy { get; set; }
}