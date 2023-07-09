namespace TodoListApp.Shared.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Description: {Description}, IsDone: {IsDone}, CreatedAt: {CreatedAt}";
        }
    }
}
