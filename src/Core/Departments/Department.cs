namespace GallowSoft.EosManagement.Core.Departments;

public class Department : IAggregateRoot
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Team> Teams { get; set; } = [];
    public List<Member> Members { get; set; } = [];

    public Department()
    {
        Name = string.Empty;
        Description = string.Empty;
    }
}