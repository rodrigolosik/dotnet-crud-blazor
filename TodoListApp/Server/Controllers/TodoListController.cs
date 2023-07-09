using Microsoft.AspNetCore.Mvc;
using TodoListApp.Server.Interfaces;
using TodoListApp.Shared.Models;

namespace TodoListApp.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoListController : ControllerBase
{
    private readonly ITodoService _activityService;

    public TodoListController(ITodoService activityService)
    {
        _activityService = activityService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _activityService.ListTodosAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Post(Todo todo)
    {
        await _activityService.AddTodoAsync(todo);
        return Ok(todo);
    }

    [HttpPut]
    public IActionResult Put(Todo todo)
    {
        _activityService.UpdateTodo(todo);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _activityService.DeleteTodo(id);
        return Ok();
    }
}
