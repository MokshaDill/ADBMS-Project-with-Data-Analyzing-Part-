namespace Admin.Models
{
    public class Message
{
    public int MessageID { get; set; }
    public int AdminId { get; set; }
    public string NIC { get; set; }
    public string MessageText { get; set; }
    public DateTime Timestamp { get; set; }
    }

}
