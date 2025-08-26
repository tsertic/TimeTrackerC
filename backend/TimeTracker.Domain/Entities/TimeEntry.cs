namespace TimeTracker.Domain.Entities;

public sealed class TimeEntry
{
    public Guid Id
    {
        get; set;
    }

    public string UserId { get; set; } = default!;
    public Guid ProjectId
    {
        get; set;
    }

    public DateTime StartUtc
    {
        get; set;
    }
    public DateTime? EndUtc
    {
        get; set;
    }

    public int DurationMinutes
    {
        get; set;
    }

    public string? Note
    {
        get; set;
    }

    public byte[] RowVersion { get; set; } = Array.Empty<byte>();

    public Project? Project
    {
        get; set;
    }
}
