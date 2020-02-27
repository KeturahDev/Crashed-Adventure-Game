namespace Crashed.Models
{
  public class Player
  {
    public int Memories { get; set; }
    public string Location { get; set; }
    public string Friend { get; set; }

    public Player(int memories, string friend)
    {
      Memories = memories;
      Location = "crash";
      Friend = friend;
    }
  }
}