namespace GallowSoft.EosManagement.Core.Departments;

public class Member : IAggregateRoot
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Team? Team { get; set; }
    public Department? Department { get; set; }

    public Member()
    {
        Name = string.Empty;
        Description = string.Empty;
    }
}
