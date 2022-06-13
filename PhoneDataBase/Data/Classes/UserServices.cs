using Microsoft.EntityFrameworkCore;
namespace PhoneDataBase.Data.Classes
{
    public class UserServices: IUserService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UserServices(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }
        public void Insert(User user)
        {
            _applicationDbContext.Users.Add(user);
            _applicationDbContext.SaveChanges();
        }
        public void InsertDepartment(Department depp)
        {
            _applicationDbContext.Departments.Add(depp);
            _applicationDbContext.SaveChanges();
        }

        public void Delete(User user)
        {
            user.StatusId = (int)Statuses.Deleted;
            _applicationDbContext.SaveChanges();
        }
        public void DeleteDepartment(Department depp)
        {
            depp.StatusId = (int)Statuses.Deleted;
            _applicationDbContext.SaveChanges();
        }

        public void Update(User user)
        {
            _applicationDbContext.SaveChanges();
        }
        public void UpdateDepartment(Department depp)
        {
            _applicationDbContext.SaveChanges();
        }
        public void Back(User user)
        {
            user.StatusId = (int)Statuses.Working;
            _applicationDbContext.SaveChanges();
        }
        public void BackDepartment(Department depp)
        {
            depp.StatusId = (int)Statuses.Working;
            _applicationDbContext.SaveChanges();
        }
        public async Task<List<User>> GetUsers() => await _applicationDbContext.Users.Where(t => t.StatusId != (int)Statuses.Deleted).ToListAsync();
        public async Task<List<User>> GetDeletedUsers() => await _applicationDbContext.Users.Where(t => t.StatusId == (int)Statuses.Deleted).ToListAsync();

        public async Task<List<Department>> GetDepartments()
        {
            //return await _applicationDbContext.Departments.Where(t => t.StatusId != (long)Statuses.Deleted).ToListAsync();
            return await _applicationDbContext.Departments.Where(t => t.StatusId != (long)Statuses.Deleted).ToListAsync();
        }
    }
    public interface IUserService
    {
        Task<List<User>> GetUsers();
        Task<List<User>> GetDeletedUsers();
        Task<List<Department>> GetDepartments();
        void Insert(User user);
        void InsertDepartment(Department depp);
        void Delete(User user);
        void DeleteDepartment(Department depp);
        void Update(User user);
        void UpdateDepartment(Department depp);
        void Back(User user);
        void BackDepartment(Department depp);
    }
}
