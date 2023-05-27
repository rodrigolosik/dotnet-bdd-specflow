using Games.Specflow.Models.Common;

namespace Games.Specflow.Models;

public sealed class Game : BaseModel
{
    public Game(string id, string title, string description, DateTime publishDate, string publisher)
    {
        Id = id;
        Title = title;
        Description = description;
        PublishDate = publishDate;
        Publisher = publisher;
    }

    public Game()
    {
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime PublishDate { get; set; }
    public string Publisher { get; set; }
}
