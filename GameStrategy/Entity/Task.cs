namespace GameStrategy.Entity
{
    public class Task
    {  public int Cost { get; set; }
        public string Text { get; set; }
        public int Time { get; set; }
        public Task(int cost, string text, int time)
        {
            Cost = cost;
            Text = text;
            Time = time;
        }
      
    }
}