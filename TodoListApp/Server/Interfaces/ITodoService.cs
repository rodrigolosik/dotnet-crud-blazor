using TodoListApp.Shared.Models;

namespace TodoListApp.Server.Interfaces;

public interface ITodoService
{
    Task<IEnumerable<Todo>> ListTodosAsync();
    void UpdateTodo(Todo activity);
    Task AddTodoAsync(Todo activity);
    void DeleteTodo(int id);
}
