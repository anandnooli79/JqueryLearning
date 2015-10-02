using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryWeb.Models
{
    public class CreateEmployeeViewModel
    {   
        [HiddenInput(DisplayValue = false)]
        public int DepartmentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime HireDate { get; set; }
    }
}