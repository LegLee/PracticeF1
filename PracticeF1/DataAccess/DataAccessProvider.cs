using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeF1.Models;

namespace PracticeF1.DataAccess
{
    public class DataAccessProvider: IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public void AddStuffRecord(Stuff stuff)
        {
            
            _context.stuff.Add(stuff);
            _context.SaveChanges();
        }

        public void UpdateStuffRecord(Stuff stuff)
        {
            _context.stuff.Update(stuff);
            _context.SaveChanges();
        }

        public void DeleteStuffRecord(int id)
        {
            var entity = _context.stuff.FirstOrDefault(t => t.id == id);
            _context.stuff.Remove(entity);
            _context.SaveChanges();
        }

        public Stuff GetStuffSingleRecord(int id)
        {
            return _context.stuff.FirstOrDefault(t => t.id == id);
        }

        public List<Stuff> GetStuffRecords()
        {
            return _context.stuff.ToList();
        }

        // /////////////////////////////////////////

        public void AddDepartmentsRecord(Departments departments)
        {

            _context.departments.Add(departments);
            _context.SaveChanges();
        }

        public void UpdateDepartmentsRecord(Departments epartments)
        {
            _context.departments.Update(epartments);
            _context.SaveChanges();
        }

        public void DeleteDepartmentsRecord(int id)
        {
            var entity = _context.departments.FirstOrDefault(t => t.id == id);
            _context.departments.Remove(entity);
            _context.SaveChanges();
        }

        public Departments GetDepartmentsSingleRecord(int id)
        {
            return _context.departments.FirstOrDefault(t => t.id == id);
        }

        public List<Departments> GetDepartmentsRecords()
        {
            return _context.departments.ToList();
        }

    }
}
