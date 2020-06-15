using GIC_G2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIC_G2.Services
{
  public  interface IEmployee
    {
        IEnumerable<Employee> EmpDataDetails { get; }
        public void AddEmployeeData (Employee employee);
        public long GetRandomNumb();
        public IQueryable<Employee> Search(string email, long TransactionID);
        Employee GetAllEmpdata (long Id);
    }
}

