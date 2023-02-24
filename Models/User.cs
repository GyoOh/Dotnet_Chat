namespace Chat.Models;

public class User
{
    public User(int id, string userName, DateTime created, string email)
    {
        Id = id;
        UserName = userName;
        Created = created;
        Email = email;
        Channels = new List<Channel>();
        Messages = new List<Message>();
    }
    public int Id { get; set; }
    public string UserName { get; set; }
    public DateTime Created { get; set; }
    public string Email { get; set; }
   public List<Channel>? Channels { get; set; }
    public List<Message>? Messages { get; set; }
}