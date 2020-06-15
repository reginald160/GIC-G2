using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GIC_G2.Models;
using GIC_G2.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using static System.Net.Mime.MediaTypeNames;

namespace GIC_G2.Controllers
{        
    public class EmployeeController : Controller
    {
        private readonly IEmployee _employee;
        private readonly IWebHostEnvironment _environment;
        Employee _empl = new Employee();

           

        public EmployeeController(IEmployee emp, IWebHostEnvironment env)
        {
            _employee = emp;
            _environment = env;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Create(Employee _empdata)
        {
            _employee.AddEmployeeData(_empdata);
            ViewBag.Message = "Your contact";

            ViewBag.Message = "Your contact";

            // Instantiation Message class
            var message = new MimeMessage();
            //Sender
            message.From.Add(new MailboxAddress("GIC", "ozougwu2016@gmail.com"));
            //Reciever Address
            message.Date = DateTime.Now;
            message.To.Add(new MailboxAddress("JOB REGISTRATION", _empdata.Email));
            message.Subject = " Registring Suceessful";
           
            using (var client = new SmtpClient())
            /*{ client.ServerCertificateValidationCallback =(s,)}*/
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("ozougwu2016@gmail.com", "reginald160");
                client.Send(message);
                client.Disconnect(true);
            }
            return View("Details",_empdata);
        }





















        //[HttpPost]

        ////        return RedirectToAction(nameof(Create));
        //public IActionResult Create(Employee _empdata )
        //{

        //    _employee.AddEmployeeData(_empdata);

        //    return View("Details",_empdata);
        //}
        public IActionResult Details(long Id)
        {
            Employee employee = _employee.GetAllEmpdata(Id);

            return View(employee);
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string email, long TransactionID)
        {
            IQueryable<Employee> result = _employee.Search(email, TransactionID);
            return View("SearchResult", result);            
        }


        public IActionResult SearchResult()
        {
            ViewBag.Message = "Application Status: Pending";
            return View();
        }




    }
}
