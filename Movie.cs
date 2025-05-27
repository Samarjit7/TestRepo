using System;

namespace Domain;

public class Movie
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string? Title { get; set; }
    public string? Director { get; set; }
    public required int Year { get; set; }
}
