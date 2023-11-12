namespace DataLayer;
public record CardModel
{
    public string? _Id { get; set; }
    public int Id { get; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Image { get; set; } = "";
    public DateTime? Date { get; set; }
    public int TimeInMinutes { get; set; }
}
