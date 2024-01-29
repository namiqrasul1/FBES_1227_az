using Microsoft.AspNetCore.Mvc;
using TodoWebService.Models.DTOs.Pagination;
using TodoWebService.Models.DTOs.Todo;
using TodoWebService.Services.Todo;

namespace TodoWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<TodoItemDto>> Get(int id)
        {
            var item = await _todoService.GetTodoItem(id);

            return item is not null
                ? item
                : NotFound();
        }

        [HttpGet("all")]
        public async Task<PaginatedListDto<TodoItemDto>?> All(PaginationRequest request, bool? isCompleted)
        {

            var result = await _todoService.GetAll(request.Page, request.PageSize, isCompleted);
            return result is not null ? result : null;
        }
    }
}
