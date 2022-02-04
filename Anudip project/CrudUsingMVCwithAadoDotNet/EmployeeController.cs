using CRUDUsingMVCwithAdoDotNet.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDUsingMVCwithAdoDotNet.Controllers
{
    public class EmployeeController : Controller
    {
        public object Id { get; private set; }

        public ActionResult GetAllEmpDetails()
        {

            EmpRepository EmpRepo = new EmpRepository();
            ModelState.Clear();
            return View(EmpRepo.GetAllEmployees());
        }
        // GET: Employee/AddEmployee    
        public ActionResult AddEmployee()
        {
            return View();
        }

        // POST: Employee/AddEmployee    
        [HttpPost]
        public ActionResult AddEmployee(EmpModel Emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpRepository EmpRepo = new EmpRepository();

                    if (EmpRepo.AddEmployee(Emp))
                    {
                        ViewBag.Message = "Employee details added successfully";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/EditEmpDetails/5    
        public ActionResult EditEmpDetails(int id)
        {
            EmpRepository EmpRepo = new EmpRepository();



            return View(EmpRepo.GetAllEmployees().Find(Emp => Emp.id == Id));

        }

        // POST: Employee/EditEmpDetails/5    
        [HttpPost]

        public ActionResult EditEmpDetails(int id, EmpModel obj)
        {
            try
            {
                EmpRepository EmpRepo = new EmpRepository();

                EmpRepo.UpdateEmployee(obj);
                return RedirectToAction("GetAllEmpDetails");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/DeleteEmp/5    
        public ActionResult DeleteEmp(int id)
        {
            public ActionResult GetAllEmpDetails()
            {

                EmpRepository EmpRepo = new EmpRepository();
                ModelState.Clear();
                return View(EmpRepo.GetAllEmployees());
            }
            // GET: Employee/AddEmployee    
            public ActionResult AddEmployee()
            {
                return View();
            }

            // GET: Employee/EditEmpDetails/5    
            ActionResult EditEmpDetails(int Id)
            {
                EmpRepository EmpRepo = new EmpRepository();



                return View(EmpRepo.GetAllEmployees().Find(Emp => Emp.Empid == Id));

            }

            // GET: Employee/DeleteEmp/5    
            ActionResult DeleteEmp(int Id)
            {
                try
                {
                    EmpRepository EmpRepo = new EmpRepository();
                    if (EmpRepo.DeleteEmployee(id))
                    {
                        ViewBag.AlertMsg = "Employee details deleted successfully";

                    }
                    return RedirectToAction("GetAllEmpDetails");

                }
                catch
                {
                    return View();
                }
            }
        }
    }
}