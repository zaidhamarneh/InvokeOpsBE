using Domain.Entities;
using System.ComponentModel.DataAnnotations;
namespace Identity.Domain.Entities;

public class User : BaseEntity
{
    public Guid Guid { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    [EmailAddress]
    [MaxLength(254)]
    public string Email { get; set; } = string.Empty;
    [Phone]
    [MaxLength(20)]
    public string Phone { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public Guid RoleId { get; set; }

}
