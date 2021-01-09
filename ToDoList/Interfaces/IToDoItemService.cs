using System.Threading.Tasks;
using ToDoList.Data.DTO;
using ToDoList.Utilities;

namespace ToDoList.Interfaces
{
    public interface IToDoItemService
    {
        Task<Result<ToDoItemDto>> CreateItem(ToDoItemDto itemDto);
        
        Task<Result<ToDoItemDto>> ChangeItem(ToDoItemDto itemDto);
        
        Task<Result<object>> DeleteItem(int id);
    }
}