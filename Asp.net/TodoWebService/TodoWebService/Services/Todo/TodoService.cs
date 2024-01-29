using Microsoft.EntityFrameworkCore;
using TodoWebService.Data;
using TodoWebService.Models.DTOs.Pagination;
using TodoWebService.Models.DTOs.Todo;
using TodoWebService.Models.Entities;

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

        public async Task<PaginatedListDto<TodoItemDto>> GetAll(int page, int pageSize, bool? isCompleted) 
        {
            IQueryable<TodoItem> query = _context.TodoItems.AsQueryable();

            if (isCompleted.HasValue)
                query = query.Where(e => e.IsCompleted == isCompleted);

            var items = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            var totalCount = await query.CountAsync();

            return new PaginatedListDto<TodoItemDto>(
                items.Select(e => new TodoItemDto(
                    id: e.Id,
                    text: e.Text,
                    isCompleted: e.IsCompleted,
                    createdTime: e.CreatedTime
                )),
                new PaginationMeta(page, pageSize, totalCount)
                );
        }

        public async Task<TodoItemDto?> GetTodoItem(int id)
        {
            var todoItem = await _context.TodoItems.FirstOrDefaultAsync(e => e.Id == id);

            return todoItem is not null
                ? new TodoItemDto(
                    id: todoItem.Id,
                    text: todoItem.Text,
                    isCompleted: todoItem.IsCompleted,
                    createdTime: todoItem.CreatedTime)
                : null;
        }
    }
}
