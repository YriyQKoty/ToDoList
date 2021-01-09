using System.Threading.Tasks;
using ToDoList.Data;
using ToDoList.Data.DTO;
using ToDoList.Interfaces;
using ToDoList.Utilities;

namespace ToDoList.Services
{
    
    public class ToDoItemService : IToDoItemService
    {
        private ApplicationDbContext _applicationDbContext;

        public ToDoItemService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        
        public async Task<Result<ToDoItemDto>> CreateItem(ToDoItemDto itemDto)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Result<ToDoItemDto>> ChangeItem(ToDoItemDto itemDto)
        {
            throw new System.NotImplementedException();
        }

        public async Task <Result<object>> DeleteItem(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}