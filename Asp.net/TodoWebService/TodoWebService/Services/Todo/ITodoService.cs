using TodoWebService.Models.DTOs.Pagination;
using TodoWebService.Models.DTOs.Todo;

namespace TodoWebService.Services.Todo
{
    public interface ITodoService
    {
        Task<TodoItemDto?> GetTodoItem(int id);
        Task<TodoItemDto> CreateTodo(CreateTodoItemRequest request);
        Task<TodoItemDto> ChangeTodoItemStatus(int id, bool isCompleted);
        Task<bool> DeleteTodo(int id);
        Task<PaginatedListDto<TodoItemDto>> GetAll(int page, int pageSize, bool? isCompleted); 
    }
}
