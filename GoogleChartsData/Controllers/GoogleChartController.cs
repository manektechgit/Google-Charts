using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoogleChartsData.Models;
using Newtonsoft.Json;

namespace GoogleChartsData.Controllers
{
    public class GoogleChartController : Controller
    {
        // GET: GoogleChart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GoogleCharts()
        {
            return View();
        }
        public ActionResult VisualizeEmployeeResult()
        {
            return Json(Result(), JsonRequestBehavior.AllowGet);
        }
        public List<EmployeeResult> Result()
        {
            List<EmployeeResult> employeeResult = new List<EmployeeResult>();

            employeeResult.Add(new EmployeeResult()
            {
                empName = "John",
                rankObtained = 88
            });
            employeeResult.Add(new EmployeeResult()
            {
                empName = "David",
                rankObtained = 60
            });
            employeeResult.Add(new EmployeeResult()
            {
                empName = "Tony",
                rankObtained = 77
            });
            employeeResult.Add(new EmployeeResult()
            {
                empName = "Michael",
                rankObtained = 80
            });
            employeeResult.Add(new EmployeeResult()
            {
                empName = "Philip",
                rankObtained = 95
            });
            employeeResult.Add(new EmployeeResult()
            {
                empName = "Phoebe",
                rankObtained = 90
            });
            return employeeResult;
        }
    }
}