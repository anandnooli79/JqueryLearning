using JQuery.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryWeb.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentDataSource _db;

        public DepartmentController(IDepartmentDataSource db)
        {
            _db = db;
        }
        // GET: Department
        public ActionResult Details(int id)
        {
            var model = _db.Departments.Single<Department>(c => c.Id == id);
            return View(model);
        }
    }
}