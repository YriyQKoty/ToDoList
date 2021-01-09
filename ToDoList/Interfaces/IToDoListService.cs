using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.Data.DTO;
using ToDoList.Utilities;

namespace ToDoList.Interfaces
{
    public interface IToDoListService
    {
        Task<Result<ToDoDto>> GetList(int id);
        Task<Result<IEnumerable<ToDoDto>>> GetAllLists();
        
        Task<Result<ToDoDto>> CreateList(ToDoDto list);
        
        Task<Result<ToDoDto>> ChangeList(ToDoDto dto);
        
        Task<Result<object>> DeleteList(int id);
        
    }
}