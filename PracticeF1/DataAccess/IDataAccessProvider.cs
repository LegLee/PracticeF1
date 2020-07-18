using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeF1.Models;

namespace PracticeF1.DataAccess
{
    public interface IDataAccessProvider
    {
        void AddStuffRecord(Stuff stuff);
        void UpdateStuffRecord(Stuff stuff);
        void DeleteStuffRecord(int id);
        Stuff GetStuffSingleRecord(int id);
        List<Stuff> GetStuffRecords();

        void AddDepartmentsRecord(Departments departments);
        void UpdateDepartmentsRecord(Departments departments);
        void DeleteDepartmentsRecord(int id);
        Departments GetDepartmentsSingleRecord(int id);
        List<Departments> GetDepartmentsRecords();
    }
}
