using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RX108_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VIPL_CRM.Controllers
{
    [Authorize(Roles = "admin")]
    public class ProductController : Controller
    {
        // GET: s/<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ProductCategoryIndex(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0, rp = 2;
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
            List<mst_productcategory> pc_list = new List<mst_productcategory>();
            pc_list = mst_productcategory.GetAll(Convert.ToInt32(pageNo), Helper.Recordpage, Convert.ToInt32(sortField), ref total, SearchString);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<mst_productcategory>(pc_list, total, Convert.ToInt32(pageNo), Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult ProductCategoryAdd(int? SrNo)
        {
            if (SrNo != null)
            {
                DataTable dataTable = new DataTable();
                var model = new mst_productcategory();
                model = mst_productcategory.GetByID(SrNo);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult ProductCategoryAdd(mst_productcategory mst_Productcategory)
        {
            try
            {
                int x = mst_Productcategory.InsertUpdate();
                if (x != -1)
                {
                    TempData["Msg"] = "Record Saved With ID = " + x;
                    TempData["Class"] = "alert alert-success";
                }
                else
                {
                    ViewBag.Msg = "Record Alread Exist";
                    ViewBag.Class = "alert alert-danger";
                    return View(mst_Productcategory);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
                return View();
            }
            return RedirectToAction("ProductCategoryIndex");
        }

        public IActionResult ProductCategoryDelete(int srno)
        {
            try
            {
                int res = mst_productcategory.Delete(srno);

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
            return RedirectToAction("ProductCategoryIndex");
        }



        public async Task<IActionResult> ProductSubCategoryIndex(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0, rp = 2;
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
            List<mst_productsubcategory> pc_list = new List<mst_productsubcategory>();
            pc_list = mst_productsubcategory.GetAll(Convert.ToInt32(pageNo), Helper.Recordpage, Convert.ToInt32(sortField), ref total, SearchString);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<mst_productsubcategory>(pc_list, total, Convert.ToInt32(pageNo), Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult ProductSubCategoryAdd(int? SrNo)
        {
            if (SrNo != null)
            {
                DataTable dataTable = new DataTable();
                var model = new mst_productsubcategory();
                model = mst_productsubcategory.GetByID(SrNo);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult ProductSubCategoryAdd(mst_productsubcategory mst_Productsubcategory)
        {
            try
            {
                int x = mst_Productsubcategory.InsertUpdate();
                if (x != -1)
                {
                    TempData["Msg"] = "Record Saved With ID = " + x;
                    TempData["Class"] = "alert alert-success";
                }
                else
                {
                    ViewBag.Msg = "Record Alread Exist";
                    ViewBag.Class = "alert alert-danger";
                    return View(mst_Productsubcategory);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
                return View();
            }
            return RedirectToAction("ProductSubCategoryIndex");
        }

        public IActionResult ProductSubCategoryDelete(int srno)
        {
            try
            {
                int res = mst_productsubcategory.Delete(srno);

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
            return RedirectToAction("ProductSubCategoryIndex");
        }


        public async Task<IActionResult> ProductIndex(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0, rp = 2;
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
            List<mst_product> pc_list = new List<mst_product>();
            pc_list = mst_product.GetAll(Convert.ToInt32(pageNo), Helper.Recordpage, Convert.ToInt32(sortField), ref total, SearchString);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<mst_product>(pc_list, total, Convert.ToInt32(pageNo), Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult ProductAdd(int? SrNo)
        {
            if (SrNo != null)
            {
                DataTable dataTable = new DataTable();
                var model = new mst_product();
                model = mst_product.GetByID(SrNo);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult ProductAdd(mst_product mst_Product)
        {
            try
            {
                int x = mst_Product.InsertUpdate();
                if (x != -1)
                {
                    TempData["Msg"] = "Record Saved With ID = " + x;
                    TempData["Class"] = "alert alert-success"; ;
                }
                else
                {
                    ViewBag.Msg = "Record Alread Exist";
                    ViewBag.Class = "alert alert-danger";
                    return View(mst_Product);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
                return View();
            }
            return RedirectToAction("ProductIndex");
        }

        public IActionResult ProductDelete(int srno)
        {
            try
            {
                int res = mst_product.Delete(srno);

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
            return RedirectToAction("ProductIndex");
        }


        public async Task<IActionResult> ProductModuleIndex(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0, rp = 2;
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
            List<mst_product_module> pc_list = new List<mst_product_module>();
            pc_list = mst_product_module.GetAll(Convert.ToInt32(pageNo), Helper.Recordpage, Convert.ToInt32(sortField), ref total, SearchString);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<mst_product_module>(pc_list, total, Convert.ToInt32(pageNo), Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult ProductModuleAdd(int? SrNo)
        {
            if (SrNo != null)
            {
                DataTable dataTable = new DataTable();
                var model = new mst_product_module();
                model = mst_product_module.GetByID(SrNo);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult ProductModuleAdd(mst_product_module mst_Product_Module)
        {
            try
            {
                int x = mst_Product_Module.InsertUpdate();
                if (x != -1)
                {
                    TempData["Msg"] = "Record Saved With ID = " + x;
                    TempData["Class"] = "alert alert-success";
                }
                else
                {
                    ViewBag.Msg = "Record Alread Exist";
                    ViewBag.Class = "alert alert-danger";
                    return View(mst_Product_Module);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
                return View();
            }
            return RedirectToAction("ProductModuleIndex");
        }

        public IActionResult ProductModuleDelete(int srno)
        {
            try
            {
                int res = mst_product_module.Delete(srno);

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
            return RedirectToAction("ProductModuleIndex");
        }


        public async Task<IActionResult> ProductVersionIndex(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0, rp = 2;
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
            List<mst_productversion> pc_list = new List<mst_productversion>();
            pc_list = mst_productversion.GetAll(Convert.ToInt32(pageNo), Helper.Recordpage, Convert.ToInt32(sortField), ref total, SearchString);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<mst_productversion>(pc_list, total, Convert.ToInt32(pageNo), Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult ProductVersionAdd(int? SrNo)
        {
            if (SrNo != null)
            {
                DataTable dataTable = new DataTable();
                var model = new mst_productversion();
                model = mst_productversion.GetByID(SrNo);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult ProductVersionAdd(mst_productversion mst_Productversion)
        {
            try
            {
                int x = mst_Productversion.InsertUpdate();
                if (x != -1)
                {
                    TempData["Msg"] = "Record Saved With ID = " + x;
                    TempData["Class"] = "alert alert-success";
                }
                else
                {
                    ViewBag.Msg = "Record Alread Exist";
                    ViewBag.Class = "alert alert-danger";
                    return View(mst_Productversion);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
                return View();
            }
            return RedirectToAction("ProductVersionIndex");
        }

        public IActionResult ProductVersionDelete(int srno)
        {
            try
            {
                int res = mst_productversion.Delete(srno);

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
            return RedirectToAction("ProductVersionIndex");
        }

        public async Task<IActionResult> PVChangesIndex(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0, rp = 2;
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
            List<mst_pvchanges> pc_list = new List<mst_pvchanges>();
            pc_list = mst_pvchanges.GetAll(Convert.ToInt32(pageNo), Helper.Recordpage, Convert.ToInt32(sortField), ref total, SearchString);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<mst_pvchanges>(pc_list, total, Convert.ToInt32(pageNo), Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult PVChangesAdd(int? SrNo)
        {
            if (SrNo != null)
            {
                DataTable dataTable = new DataTable();
                var model = new mst_pvchanges();
                model = mst_pvchanges.GetByID(SrNo);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult PVChangesAdd(mst_pvchanges mst_Pvchanges)
        {
            try
            {
                int x = mst_Pvchanges.InsertUpdate();
                if (x != -1)
                {
                    TempData["Msg"] = "Record Saved With ID = " + x;
                    TempData["Class"] = "alert alert-success";
                }
                else
                {
                    ViewBag.Msg = "Record Alread Exist";
                    ViewBag.Class = "alert alert-danger";
                    return View(mst_Pvchanges);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
                return View();
            }
            return RedirectToAction("PVChangesIndex");
        }

        public IActionResult PVChangesDelete(int srno)
        {
            try
            {
                int res = mst_pvchanges.Delete(srno);

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
            return RedirectToAction("PVChangesIndex");
        }

        public async Task<IActionResult> ProductPriceIndex(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0, rp = 2;
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
            List<mst_productprice> pc_list = new List<mst_productprice>();
            pc_list = mst_productprice.GetAll(Convert.ToInt32(pageNo), Helper.Recordpage, Convert.ToInt32(sortField), ref total, SearchString);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<mst_productprice>(pc_list, total, Convert.ToInt32(pageNo), Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult ProductPriceAdd(int? SrNo)
        {
            if (SrNo != null)
            {
                DataTable dataTable = new DataTable();
                var model = new mst_productprice();
                model = mst_productprice.GetByID(SrNo);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult ProductPriceAdd(mst_productprice mst_Productprice)
        {
            try
            {
                int x = mst_Productprice.InsertUpdate();
                if (x != -1)
                {
                    TempData["Msg"] = "Record Saved With ID = " + x;
                    TempData["Class"] = "alert alert-success";
                }
                else
                {
                    ViewBag.Msg = "Record Alread Exist";
                    ViewBag.Class = "alert alert-danger";
                    return View(mst_Productprice);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
                return View();
            }
            return RedirectToAction("ProductPriceIndex");
        }

        public IActionResult ProductPriceDelete(int srno)
        {
            try
            {
                int res = mst_productprice.Delete(srno);

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
            return RedirectToAction("ProductPriceIndex");
        }

        public async Task<IActionResult> PPModulesIndex(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            int total = 0, rp = 2;
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
            List<mst_ppmodules> pc_list = new List<mst_ppmodules>();
            pc_list = mst_ppmodules.GetAll(Convert.ToInt32(pageNo), Helper.Recordpage, Convert.ToInt32(sortField), ref total, SearchString);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<mst_ppmodules>(pc_list, total, Convert.ToInt32(pageNo), Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult PPModulesAdd(int? SrNo)
        {
            if (SrNo != null)
            {
                DataTable dataTable = new DataTable();
                var model = new mst_ppmodules();
                model = mst_ppmodules.GetByID(SrNo);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult PPModulesAdd(mst_ppmodules mst_Ppmodules)
        {
            try
            {
                int x = mst_Ppmodules.InsertUpdate();
                if (x != -1)
                {
                    TempData["Msg"] = "Record Saved With ID = " + x;
                    TempData["Class"] = "alert alert-success";
                }
                else
                {
                    ViewBag.Msg = "Record Alread Exist";
                    ViewBag.Class = "alert alert-danger";
                    return View(mst_Ppmodules);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
                return View();
            }
            return RedirectToAction("PPModulesIndex");
        }

        public IActionResult PPModulesDelete(int srno)
        {
            try
            {
                int res = mst_ppmodules.Delete(srno);

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
            return RedirectToAction("PPModulesIndex");
        }

    }
}