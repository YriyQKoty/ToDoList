using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Data.DTO;
using ToDoList.Extensions;
using ToDoList.Interfaces;
using ToDoList.Utilities;

namespace ToDoList.Services
{
    public class ToDoListService : IToDoListService
    {
        private ApplicationDbContext _applicationDbContext;

        public ToDoListService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public async Task <Result<ToDoDto>> GetList(int id)
        {
            var list = await _applicationDbContext.Lists.Include(i => i.Items)
                .SingleOrDefaultAsync(o => o.Id == id);
            
            if (list == null)
            {
                return new Result<ToDoDto>(false, "List was not found!");
            }

            var result = list.MapToDto();

            return new Result<ToDoDto>(true, "", result);
        }

        public async Task<Result<IEnumerable<ToDoDto>>> GetAllLists()
        {
            var lists = await _applicationDbContext.Lists
                .Include(i => i.Items)
                .ToListAsync();
            if (lists == null)
            {
                return new Result<IEnumerable<ToDoDto>>(false, "Lists were not found!"); 
            }
            
            var results = lists.Select(list => list.MapToDto());
            
            return new Result<IEnumerable<ToDoDto>>(true, "", results);
        }

        public async Task<Result<ToDoDto>> CreateList(ToDoDto list)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Result<ToDoDto>> ChangeList(ToDoDto dto)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Result<object>> DeleteList(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}