
namespace EmployeeManagement.Domain.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType()) 
            return false;

        var other = (BaseEntity)obj;
        return Id == other.Id;
    }
    public override int GetHashCode() => Id.GetHashCode();
}
