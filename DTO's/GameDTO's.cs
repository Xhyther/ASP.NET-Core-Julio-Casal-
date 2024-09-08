namespace GameStore.DTO_s
{
    public record class GameDTO_s(
        int Id, 
        string Name, 
        string Genre, 
        decimal Price, 
        DateOnly ReleaseDate);
    
}
