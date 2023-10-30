namespace GallowSoft.EosManagement.Core.Departments;

public class Team : IAggregateRoot
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Department Department { get; set; }

    public Team()
    {
        Name = string.Empty;
        Description = string.Empty;
        Department = new Department();
    }
}
