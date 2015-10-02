using JQuery.Domain;
using JQueryWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryWeb.Controllers
{
    public class EmployeeController : Controller
    {
        private IDepartmentDataSource _db;

        public EmployeeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Create(int departmentId)
        {
            var model = new CreateEmployeeViewModel();
            model.DepartmentId = departmentId;
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var department = _db.Departments.Single<Department>(c => c.Id == viewModel.DepartmentId);
                department.Employees.Add(new Employee()
                {
                    Name = viewModel.Name,
                    HireDate = viewModel.HireDate
                });

                _db.Save();
                return RedirectToAction("Details", "Department", new { id = viewModel.DepartmentId });
            }
            return View(viewModel);
        }
    }
}