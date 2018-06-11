using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSampleApp.Models
{
    [Table("[Employeetable]")]
    public class Employee
    {
        [Display(Name ="ID :")]
        public string EmployeeID { get; set; }
        [Display(Name ="Name :")]
        public string EmployeeName { get; set; }
        [Display(Name ="Age :")]
        public string EmployeeAge { get; set; }
        [Display(Name ="Gender :")]
        public string EmployeeGender { get; set; }
        [Display(Name ="City :")]
        public string EmployeeCity { get; set; }
    }
}