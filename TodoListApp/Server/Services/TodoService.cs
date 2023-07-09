using Microsoft.EntityFrameworkCore;
using TodoListApp.Server.Data;
using TodoListApp.Server.Interfaces;
using TodoListApp.Shared.Models;

namespace TodoListApp.Server.Services;

public class TodoService : ITodoService
{
    private readonly DatabaseContext _dbContext;

    public TodoService(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddTodoAsync(Todo activity)
    {
        try
        {
            await _dbContext.Todos.AddAsync(activity);
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void DeleteTodo(int id)
    {
        try
        {
            var activity = _dbContext.Todos.Find(id);
            if (activity != null)
            {
                _dbContext.Todos.Remove(activity);
                _dbContext.SaveChanges();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<Todo>> ListTodosAsync()
    {
        try
        {
            return await _dbContext.Todos.ToListAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void UpdateTodo(Todo activity)
    {
        try
        {
            _dbContext.Entry(activity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        catch (Exception)
        {
            throw;
        }
    }
}
