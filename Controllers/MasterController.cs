using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RX108_Data;
using Microsoft.AspNetCore.Authorization;

namespace VIPL_CRM.Controllers
{
    [Authorize(Roles ="admin")]
    public class MasterController : Controller
    {
        
        [HttpPost]
        public IActionResult Country(country country)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    int result = country.country_insertUpdate();
                    if (result != -1)
                    {
                        TempData["Msg"] = "Country Saved With ID = " + result;
                        TempData["Class"] = "alert alert-success";
                    }
                    else
                    {
                        ViewBag.Msg = "Country name already exist";
                        ViewBag.Class = "alert alert-danger";
                        return View(country);
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("CountryList");
        }
        public async Task<IActionResult> CountryList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
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
            }else if(currentFilter != null)
            {
                SearchString = currentFilter;
            }
            else
            {
                SearchString = "";
            }
            
            
            var data = country.GetAll( SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<country>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);

            
        }
        public IActionResult Delete(int SrNo)
        {
            try
            {
                country.CountryDelete(SrNo);
                TempData["MSG"] = "Country deleted successfully.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("CountryList");
        }
        
        public IActionResult Country(int? SrNo)
        {
            try
            {

                if (SrNo != null)
                {
                    var model = new country();
                    model = country.GetByID(SrNo);
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
        [HttpPost]
        public IActionResult State(state state)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    int result = state.state_insertUpdate();
                    if (result != -1)
                    {
                        TempData["Msg"] = "Record Saved With ID = " + result;
                        TempData["Class"] = "alert alert-success";
                    }
                    else
                    {
                        ViewBag.Msg = "State name already exist";
                        ViewBag.Class = "alert alert-danger";
                        return View(state);
                    }

                }

            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("StateList");

        }

        public async Task<IActionResult> StateList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
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


            var data = state.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<state>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);


        }
        public IActionResult State(int? SrNo)
        {
            try
            {

                if (SrNo != null)
                {
                    var model = new state();
                    model = state.GetByID(SrNo);
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
        public IActionResult STDelete(int SrNo)
        {
            try
            {
                state.stateDelete(SrNo);
                TempData["MSG"] = "State deleted successfully.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("StateList");
        }
        [HttpPost]
        public IActionResult District(district district)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    int result = district.district_insertUpdate();
                    if (result != -1)
                    {
                        TempData["Msg"] = "Record Saved With ID = " + result;
                        TempData["Class"] = "alert alert-success";

                    }
                    else
                    {
                        ViewBag.Msg = "District already exist";
                        ViewBag.Class = "alert alert-danger";
                        return View(district);
                    }


                }

            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("DistrictList");
        }
        public IActionResult District(int? SrNo)
        {
            try
            {

                if (SrNo != null)
                {
                    var model = new district();
                    model = district.GetByID(SrNo);
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
        public IActionResult DistrictDelete(int? SrNo)
        {
            try
            {
                district.districtDelete(Convert.ToInt32(SrNo));
                TempData["MSG"] = "District deleted successfully.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("DistrictList");
        }
        public async Task<IActionResult> DistrictList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
            List<district> lst = new List<district>();

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


            var data = district.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<district>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);

        }
        public IActionResult Area(int? SrNo)
        {
            try
            {

                if (SrNo != null)
                {
                    var model = new area();
                    model = area.GetByID(SrNo);
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
        [HttpPost]
        public IActionResult Area(area area)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    int result = area.area_insertUpdate();
                    if (result != -1)
                    {
                        TempData["Msg"] = "Record Saved With ID = " + result;
                        TempData["Class"] = "alert alert-success";

                    }
                    else
                    {
                        ViewBag.Msg = "Area already exist";
                        ViewBag.Class = "alert alert-danger";
                        return View(area);
                    }


                }

            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("AreaList");
        }
        public async Task<IActionResult> AreaList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
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


            var data = area.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<area>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);
        }
        public IActionResult AreaDelete(int SrNo)
        {
            try
            {
                area.areaDelete(SrNo);
                TempData["MSG"] = "Area deleted successfully.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("AreaList");
        }
        public IActionResult Region(int? SrNo)
        {
            try
            {

                if (SrNo != null)
                {
                    var model = new region();
                    model = region.GetByID(SrNo);
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
        [HttpPost]
        public IActionResult Region(region region)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    int result = region.region_insertUpdate();
                    if (result != -1)
                    {
                        TempData["Msg"] = "Record Saved With ID = " + result;
                        TempData["Class"] = "alert alert-success";

                    }
                    else
                    {
                        ViewBag.Msg = "Region already exist";
                        ViewBag.Class = "alert alert-danger";
                        return View(region);
                    }


                }

            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("RegionList");
        }
        public IActionResult RegionList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
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


            var data = region.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<region>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);
        }
        public IActionResult RegionDelete(int SrNo)
        {
            try
            {
                region.regionDelete(SrNo);
                TempData["MSG"] = "Region deleted successfully.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("RegionList");
        }
        public IActionResult RegionChild(int? SrNo)
        {
            try
            {

                if (SrNo != null)
                {
                    var model = new regionchild();
                    model = regionchild.GetByID(SrNo);
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
        [HttpPost]
        public IActionResult RegionChild(regionchild regionchild)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    int result = regionchild.regionchild_insertUpdate();
                    if (result != -1)
                    {
                        TempData["Msg"] = "Record Saved With ID = " + result;
                        TempData["Class"] = "alert alert-success";

                    }
                    else
                    {
                        ViewBag.Msg = "RegionChild already exist";
                        ViewBag.Class = "alert alert-danger";
                        return View(regionchild);
                    }


                }
                
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
            }
            return RedirectToAction("RegionChildList");
        }
        public async Task<IActionResult> RegionChildList(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
        {
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


            var data = regionchild.GetAll(SearchString, (int)sortField, (int)pageNo, Helper.Recordpage, ref total);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<regionchild>(data, total, (int)pageNo, Helper.Recordpage);
            return View(pageList);
        }
        public IActionResult RegionChildDelete(int SrNo)
        {
            try
            {
                regionchild.regionchildDelete(SrNo);
                TempData["MSG"] = "RegionChild Record deleted successfully.";
                TempData["Class"] = "alert alert-success";
            }
            catch (Exception ex)
            {
                TempData["MSG"] = ex.Message;
                TempData["Class"] = "alert alert-danger";
            }
            return RedirectToAction("RegionChildList");
        }
    }
}