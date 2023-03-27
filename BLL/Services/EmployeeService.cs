using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {
     public static object Get()
        {
            return EmployeeRepos.Get();
        }
        public static List<Employee> Get10()
        {
            var data = from e in EmployeeRepos.Get()
                       where e.Id<11
                       select e;    
            return data.ToList();
        }
        public static Employee Get(int id)
        {
            return EmployeeRepos.Get(id);
        }
        public static bool Create(Employee employee) 
        {
            return EmployeeRepos.Create(employee);
        }
        public static bool Update(Employee employee)
        {
            return EmployeeRepos.Update(employee);
        }
        public static bool Delete(int id) 
        {
            return EmployeeRepos.Delete(id);
        }    
    }
}
