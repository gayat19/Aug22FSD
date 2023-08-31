using CompanyApplication.Contexts;
using CompanyApplication.Interfaces;
using CompanyApplication.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CompanyApplication.Repositories
{
    public class DepartmentRepository : IRepository<int, Department>
    {
        private readonly CompanyContext _context;

        public DepartmentRepository(CompanyContext context)
        {
            _context = context;
        }
        public Department Add(Department entity)
        {
            _context.departments.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Department Delete(int key)
        {
            var department = Get(key);
            _context.departments.Remove(department);
            _context.SaveChanges();
            return department;
        }

        public Department Get(int key)
        {
            var department = _context.departments.FirstOrDefault(d=>d.DepartmentNumber == key);
            return department;
        }

        public ICollection<Department> GetAll()
        {
           return _context.departments.ToList();
        }

        public Department Update(Department entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
