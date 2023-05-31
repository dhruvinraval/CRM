using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RX108_Data;

namespace VIPL_CRM.Controllers
{
    [Authorize(Roles = "admin")]
    public class BankingEmployeeMasterController : Controller
    {
        /*BANK**********************************************************************************************************/

        [HttpPost]
        public IActionResult BankIndex(Bank bank)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = bank.InsertUpdate();

                    if (res != -1)
                    {
                        TempData["Msg"] = "Successfully Saved With ID = " + res;
                        TempData["Class"] = "alert alert-success";
                        return RedirectToAction("BankList");
                    }
                    else
                    {
                        ViewBag.Msg = "Bank name already exists.";
                        ViewBag.Class = "alert alert-danger";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("BankList");
        }

        public async Task<IActionResult> BankList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0;
            int reco = 3;
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

            var data = Bank.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);

            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<Bank>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult BankDelete(int SrNo)
        {
            try
            {
                Bank.BankDelete(SrNo);
                TempData["Msg"] = "Successfully Deleted.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("BankList");
        }

        public IActionResult BankIndex(int? SrNo)
        {
            try
            {
                if (SrNo != null)
                {
                    var model = new Bank();
                    model = Bank.GetById(SrNo);
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

        /*DOCTAG**********************************************************************************************************/

        [HttpPost]
        public IActionResult DocTagIndex(DocTag doctag)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = doctag.InsertUpdate();

                    if (res != -1)
                    {
                        TempData["Msg"] = "Successfully Saved With ID = " + res;
                        TempData["Class"] = "alert alert-success";
                        return RedirectToAction("DocTagList");
                    }
                    else
                    {
                        ViewBag.Msg = "Document Tag Name already exists.";
                        ViewBag.Class = "alert alert-danger";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("DocTagList");
        }

        public async Task<IActionResult> DocTagList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0;
            int reco = 3;
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

            var data = DocTag.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);

            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<DocTag>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult DocTagDelete(int SrNo)
        {
            try
            {
                DocTag.DocTagDelete(SrNo);
                TempData["Msg"] = "Successfully Deleted.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("DocTagList");
        }

        public IActionResult DocTagIndex(int? SrNo)
        {
            try
            {
                if (SrNo != null)
                {
                    var model = new DocTag();
                    model = DocTag.GetById(SrNo);
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

        /*DEPARTMENT**********************************************************************************************************/

        [HttpPost]
        public IActionResult DepartmentIndex(Department_M department_m)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = department_m.InsertUpdate();

                    if (res != -1)
                    {
                        TempData["Msg"] = "Successfully Saved With ID = " + res;
                        TempData["Class"] = "alert alert-success";
                        return RedirectToAction("DepartmentList");
                    }
                    else
                    {
                        ViewBag.Msg = "Department already exists.";
                        ViewBag.Class = "alert alert-danger";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("DepartmentList");
        }

        public async Task<IActionResult> DepartmentList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0;
            int reco = 3;
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

            var data = Department_M.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);

            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<Department_M>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult DepartmentDelete(int SrNo)
        {
            try
            {
                Department_M.DepartmentDelete(SrNo);
                TempData["Msg"] = "Successfully Deleted.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("DepartmentList");
        }

        public IActionResult DepartmentIndex(int? SrNo)
        {
            try
            {
                if (SrNo != null)
                {
                    var model = new Department_M();
                    model = Department_M.GetById(SrNo);
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

        /*DESIGNATION**********************************************************************************************************/

        [HttpPost]
        public IActionResult DesignationIndex(Designation_M designation_m)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = designation_m.InsertUpdate();

                    if (res != -1)
                    {
                        TempData["Msg"] = "Successfully Saved With ID = " + res;
                        TempData["Class"] = "alert alert-success";
                        return RedirectToAction("DesignationList");
                    }
                    else
                    {
                        ViewBag.Msg = "Designation already exists.";
                        ViewBag.Class = "alert alert-danger";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("DesignationList");
        }

        public async Task<IActionResult> DesignationList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0;
            int reco = 3;
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

            var data = Designation_M.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);

            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<Designation_M>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult DesignationDelete(int SrNo)
        {
            try
            {
                Designation_M.DesignationDelete(SrNo);
                TempData["Msg"] = "Successfully Deleted.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("DesignationList");
        }

        public IActionResult DesignationIndex(int? SrNo)
        {
            try
            {
                if (SrNo != null)
                {
                    var model = new Designation_M();
                    model = Designation_M.GetById(SrNo);
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

        /*RELATIONSHIP**********************************************************************************************************/

        [HttpPost]
        public IActionResult RelationshipIndex(Relationship_M relationship_m)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = relationship_m.InsertUpdate();

                    if (res != -1)
                    {
                        TempData["Msg"] = "Successfully Saved With ID = " + res;
                        TempData["Class"] = "alert alert-success";
                        return RedirectToAction("RelationshipList");
                    }
                    else
                    {
                        ViewBag.Msg = "Relationship already exists.";
                        ViewBag.Class = "alert alert-danger";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("RelationshipList");
        }

        public async Task<IActionResult> RelationshipList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0;
            int reco = 3;
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

            var data = Relationship_M.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);

            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<Relationship_M>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult RelationshipDelete(int SrNo)
        {
            try
            {
                Relationship_M.RelationshipDelete(SrNo);
                TempData["Msg"] = "Successfully Deleted.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("RelationshipList");
        }

        public IActionResult RelationshipIndex(int? SrNo)
        {
            try
            {
                if (SrNo != null)
                {
                    var model = new Relationship_M();
                    model = Relationship_M.GetById(SrNo);
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

        /*PERKS**********************************************************************************************************/

        [HttpPost]
        public IActionResult PerksIndex(Perks perks)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = perks.InsertUpdate();

                    if (res != -1)
                    {
                        TempData["Msg"] = "Successfully Saved With ID = " + res;
                        TempData["Class"] = "alert alert-success";
                        return RedirectToAction("PerksList");
                    }
                    else
                    {
                        ViewBag.Msg = "Perk name already exists.";
                        ViewBag.Class = "alert alert-danger";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("PerksList");
        }

        public async Task<IActionResult> PerksList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0;
            int reco = 3;
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

            var data = Perks.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);

            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<Perks>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult PerksDelete(int SrNo)
        {
            try
            {
                Perks.PerksDelete(SrNo);
                TempData["Msg"] = "Successfully Deleted.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("PerksList");
        }

        public IActionResult PerksIndex(int? SrNo)
        {
            try
            {
                if (SrNo != null)
                {
                    var model = new Perks();
                    model = Perks.GetById(SrNo);
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

        /*NOTE**********************************************************************************************************/

        [HttpPost]
        public IActionResult NoteIndex(Note note)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = note.InsertUpdate();

                    if (res != -1)
                    {
                        TempData["Msg"] = "Successfully Saved With ID = " + res;
                        TempData["Class"] = "alert alert-success";
                        return RedirectToAction("NoteList");
                    }
                    else
                    {
                        ViewBag.Msg = "Note name already exists.";
                        ViewBag.Class = "alert alert-danger";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("NoteList");
        }

        public async Task<IActionResult> NoteList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0;
            int reco = 3;
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

            var data = Note.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);

            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<Note>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult NoteDelete(int SrNo)
        {
            try
            {
                Note.NoteDelete(SrNo);
                TempData["Msg"] = "Successfully Deleted.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("NoteList");
        }

        public IActionResult NoteIndex(int? SrNo)
        {
            try
            {
                if (SrNo != null)
                {
                    var model = new Note();
                    model = Note.GetById(SrNo);
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

        /*EMPLOYEE_REVIEW**********************************************************************************************************/

        [HttpPost]
        public IActionResult EmployeeReviewIndex(EmployeeReview employeereview)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = employeereview.InsertUpdate();

                    if (res != -1)
                    {
                        TempData["Msg"] = "Successfully Saved With ID = " + res;
                        TempData["Class"] = "alert alert-success";
                        return RedirectToAction("EmployeeReviewList");
                    }
                    else
                    {
                        ViewBag.Msg = "Review name already exists.";
                        ViewBag.Class = "alert alert-danger";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("EmployeeReviewList");
        }

        public async Task<IActionResult> EmployeeReviewList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0;
            int reco = 3;
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

            var data = EmployeeReview.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);

            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<EmployeeReview>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult EmployeeReviewDelete(int SrNo)
        {
            try
            {
                EmployeeReview.EmployeeReviewDelete(SrNo);
                TempData["Msg"] = "Successfully Deleted.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("EmployeeReviewList");
        }

        public IActionResult EmployeeReviewIndex(int? SrNo)
        {
            try
            {
                if (SrNo != null)
                {
                    var model = new EmployeeReview();
                    model = EmployeeReview.GetById(SrNo);
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

        /*EMPLOYEE_DEPARTMENT_REVIEW**********************************************************************************************************/

        [HttpPost]
        public IActionResult EmpDeptReviewIndex(EmpDeptReview empdeptreview)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int res = empdeptreview.InsertUpdate();

                    if (res != -1)
                    {
                        TempData["Msg"] = "Successfully Saved With ID = " + res;
                        TempData["Class"] = "alert alert-success";
                        return RedirectToAction("EmpDeptReviewList");
                    }
                    else
                    {
                        ViewBag.Msg = "Record already exists.";
                        ViewBag.Class = "alert alert-danger";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("EmpDeptReviewList");
        }

        public async Task<IActionResult> EmpDeptReviewList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0;
            int reco = 3;
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

            var data = EmpDeptReview.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);

            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<EmpDeptReview>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult EmpDeptReviewDelete(int SrNo)
        {
            try
            {
                EmpDeptReview.EmpDeptReviewDelete(SrNo);
                TempData["Msg"] = "Successfully Deleted.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("EmpDeptReviewList");
        }

        public IActionResult EmpDeptReviewIndex(int? SrNo)
        {
            try
            {
                if (SrNo != null)
                {
                    var model = new EmpDeptReview();
                    model = EmpDeptReview.GetById(SrNo);
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
    }
}