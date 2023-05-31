using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RX108_Data;

namespace VIPL_CRM.Controllers
{
    public class CustomerController : Controller
    {
      
        [HttpPost]
        public IActionResult Complain(complain complain)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    int result = complain.complain_insertUpdate();
                    ViewBag.Msg = "Complain Send With ID = " + result + " And Remember This ID For Further Use";
                    ViewBag.Class = "alert alert-success";                    
                }

            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return View();
        }
        public IActionResult Complain(int? SrNo)
        {
            try
            {

                if (SrNo != null)
                {
                    var model = new complain();
                    model = complain.GetByID(SrNo);
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }

            return View();
        }
        public IActionResult ComplainDelete(int? SrNo)
        {
            try
            {
                complain.complainDelete(Convert.ToInt32(SrNo));
                TempData["MSG"] = "Complain deleted successfully.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("ComplainList");
        }
        public async Task<IActionResult> ComplainList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            List<complain> lst = new List<complain>();

            int total = 0;
            int rec = 15;
            if (sortField == null)
            {
                sortField = 12;
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


            var data = complain.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<complain>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);

        }

        [HttpPost]
        public IActionResult Feedback(Feedback Feedback)
        {
            try
            {

               
                    int result = Feedback.Feedback_insertUpdate();
                    ViewBag.Msg = "Thank you for your Feedback ";
                    ViewBag.Class = "alert alert-success";
                

            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return View();
        }
        public IActionResult Feedback(int? SrNo)
        {
            //try
            //{

            //    if (SrNo != null)
            //    {
            //        var model = new Feedback();
            //        model = Feedback.GetByID(SrNo);
            //        return View(model);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.Msg = ex.Message;
            //    ViewBag.Class = "alert alert-danger";
            //}

            return View();
        }
        //public async Task<IActionResult> FeedbackList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        //{
        //    List<Feedback> lst = new List<Feedback>();

        //    int total = 0;
        //    int rec = 15;
        //    if (sortField == null)
        //    {
        //        sortField = 12;
        //    }
        //    if (pageNo == null)
        //    {
        //        pageNo = 1;
        //    }

        //    if (SearchString != null)
        //    {
        //        //pageNo = 1;
        //    }
        //    else if (currentFilter != null)
        //    {
        //        SearchString = currentFilter;
        //    }
        //    else
        //    {
        //        SearchString = "";
        //    }


        //    var data = Feedback.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);
        //    ViewData["CurrentSort"] = sortField;
        //    ViewBag.CurrentFilter = SearchString;
        //    ViewBag.CurrentSort = sortField;
        //    var pageList = new PagingList<Feedback>(data, total, (int)pageNo, Helper.Recordpage);
        //    return View(pageList);

        //}
        [HttpPost]
        public IActionResult CustomerSupport(ContactUs ContactUs)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    int result = ContactUs.contactus_insertUpdate();
                    ViewBag.Msg = "Your Information Is Received We Will Contact You As Soon As Possible";
                    ViewBag.Class = "alert alert-success";
                }

            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return View();
        }

        public IActionResult CustomerSupport(int? SrNo)
        {
            try
            {

                if (SrNo != null)
                {
                    var model = new ContactUs();
                    model = ContactUs.GetByID(SrNo);
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }

            return View();
        }
        public async Task<IActionResult> ContactUsList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            List<ContactUs> lst = new List<ContactUs>();

            int total = 0;
            int rec = 15;
            if (sortField == null)
            {
                sortField = 12;
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


            var data = ContactUs.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<ContactUs>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);

        }

    }
}