using Microsoft.EntityFrameworkCore;
using TodoWebService.Data;
using TodoWebService.Models.DTOs.Todo;

namespace TodoWebService.Services.Todo
{
    public class TodoService : ITodoService
    {
        private readonly TodoDbContext _context;

        public TodoService(TodoDbContext context)
        {
            _context = context;
        }

        public Task<TodoItemDto> ChangeTodoItemStatus(int id, bool isCompleted)
        {
            throw new NotImplementedException();
        }

        public Task<TodoItemDto> CreateTodo(CreateTodoItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTodo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TodoItemDto>> GetAll(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<TodoItemDto?> GetTodoItem(int id)
        {
            var todoItem = await _context.TodoItems.FirstOrDefaultAsync(e => e.Id == id);

            return todoItem is not null
                ? new TodoItemDto(
                    Id: todoItem.Id,
                    Text: todoItem.Text,
                    IsCompleted: todoItem.IsCompleted,
                    CreatedTime: todoItem.CreatedTime)
                : null;
        }
    }
}
