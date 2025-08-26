namespace TimeTracker.Domain.Entities;

public sealed class Project
{
    public Guid Id
    {
        get; set;
    }

    public string Name { get; set; } = default!;

    public string? Description
    {
        get; set;
    }

    public bool IsArchived
    {
        get; set;
    }

    //server side timestamp, UTC
    public DateTime CreatedAtUtc
    {
        get; set;
    }
}
