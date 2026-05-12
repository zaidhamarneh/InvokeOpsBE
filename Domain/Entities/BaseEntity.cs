namespace Domain.Entities;

public class BaseEntity
{
    public required Guid Id { get; set; }
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
    public required string CreatedBy { get; set; } = string.Empty;
    public DateTime? UpdatedAt { get; set; } = null;
    public string? UpdatedBy { get; set; } = null;

}
