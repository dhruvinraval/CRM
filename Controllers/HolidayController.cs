using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RX108_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace VIPL_CRM.Controllers
{
    [Authorize(Roles="admin")]
    public class HolidayController : Controller
    {
        public IActionResult Index(int? srno)
        {
            if (srno != null)
            {
                Holidays holidays = new Holidays();
                DataTable dataTable = new DataTable();
                var model = new Holidays();
                model = Holidays.GetByID(srno);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Index(Holidays holidays)
            {
            try
            {
                int x = holidays.InsertUpdate();
                if (x != -1)
                {
                    TempData["Msg"] = "Record Saved With ID = " + x;
                    TempData["Class"] = "alert alert-success";
                }
                else
                {
                    ViewBag.Msg = "Record Alread Exist";
                    ViewBag.Class = "alert alert-danger";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
                return View();
            }

            return RedirectToAction("List");
        }

        public async Task<IActionResult> List(string sortField, string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo)
        {
            int total = 0;
            if (sortField == null)
            {
                sortField = "12";
            }
            if (pageNo == null)
            {
                pageNo = 1;
            }
            if (SearchString != null)
            {
                //pageNo = 1;

            }
            else if (currentFilter != null)
            {
                SearchString = currentFilter;
            }
            else
            {
                SearchString = "";
            }

            Holidays holidays = new Holidays();
            List<Holidays> holidaysList = new List<Holidays>();
            holidaysList = Holidays.GetAll(Convert.ToInt32(pageNo), Helper.Recordpage, Convert.ToInt32(sortField), ref total, SearchString);
            ViewBag.CurrentSort = Convert.ToInt32(sortField);            
            ViewData["CurrentSort"] = sortField;    
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pagelist = new PagingList<Holidays>(holidaysList, total, Convert.ToInt32(pageNo), Helper.Recordpage);
            return View(pagelist);
        }

        public IActionResult Delete(int srno)
        {
            try
            {
                Holidays holidays = new Holidays();
                int res = Holidays.Delete(srno);

                if (res > 0)
                {
                    ViewBag.Msg = "Delete ID = " + srno + " SuccessFul";
                    ViewBag.Class = "alert alert-success";
                }
                else
                {
                    ViewBag.Msg = "Record Not Deleted";
                    ViewBag.Class = "alert alert-danger";
                }

            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("List");
        }
    }
}