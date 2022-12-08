
    public class Movies
    {
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Date { get; set; } = String.Empty;

    public ICollection<Hero> Heroes { get; set; }
}

