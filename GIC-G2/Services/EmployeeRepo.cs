using GIC_G2.DataContext;
using GIC_G2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIC_G2.Services
{
    public class EmployeeRepo: IEmployee  
    {
        private readonly DataDBContext _dataDBContext;
        
        //Dependency  injection of DataDBContext Into EmployeeRepo through constructor injection
        public EmployeeRepo(DataDBContext empdata)
        {
            _dataDBContext = empdata;
        }

       //Creating Employing Method *****************************************************
        public void AddEmployeeData(Employee employee)
        {              
            employee.TrackingNum = GetRandomNumb();
            _dataDBContext.EmployeeTable.Add(employee);
            _dataDBContext.SaveChanges();
        }
        //Method to generating Random Number **********************************************
        public long GetRandomNumb()
        {
            long trackID = 0;
            var rand = new Random();
            var bytes = new byte[1];
            rand.NextBytes(bytes);
            for (int i = 1; i <= 9; i++)
            {
                trackID = (rand.Next(1, 9) + (DateTime.Now.Ticks / 1000000));
            }

             return trackID;
        }
        //Search  Method using trackingId and Email *********************************************

        public IQueryable<Employee> Search(string email, long TransactionID)
        {

            //return _context.EmployeeTable.Where(T => T.FirstName.Contains(surname));
            var SearchResult = _dataDBContext.EmployeeTable.Where(T => T.Email.Contains(email) && T.TrackingNum == TransactionID);

            return SearchResult;
        }

        public IEnumerable<Employee> EmpDataDetails
        {
            get
            {
                return _dataDBContext.EmployeeTable;
            }
        }       

        public Employee GetAllEmpdata(long Id)
        {
            return _dataDBContext.EmployeeTable.Find(Id);
        }
    }
}
