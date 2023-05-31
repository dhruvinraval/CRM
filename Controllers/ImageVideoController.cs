using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RX108_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VIPL_CRM.Controllers
{
    [Authorize(Roles = "admin")]
    public class ImageVideoController : Controller
    {
        private readonly IConfiguration configuration;
        IHostingEnvironment _env;
        string _dir;
        public ImageVideoController(IConfiguration config, IHostingEnvironment env)
        {
            _env = env;
            _dir = _env.WebRootPath;
        }
        [DisableRequestSizeLimit]
        public async Task<IActionResult> Index(string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo, int? sortField)
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
            List<iv_LinkName> iv_List = new List<iv_LinkName>();
            iv_List = iv_LinkName.GetAll(Convert.ToInt32(pageNo), Helper.Recordpage, Convert.ToInt32(sortField), ref total, SearchString);
            ViewData["CurrentSort"] = sortField;
            ViewBag.CurrentFilter = SearchString;
            ViewBag.CurrentSort = sortField;
            var pageList = new PagingList<iv_LinkName>(iv_List, total, Convert.ToInt32(pageNo), Helper.Recordpage);
            return View(pageList);
        }

        public IActionResult Add(int? SrNo)
        {
            if (SrNo != null)
            {
                DataTable dataTable = new DataTable();
                var model = new iv_LinkName();
                model = iv_LinkName.GetByID(SrNo);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> Add(iv_LinkName iv_linkname, IFormFile image1)
        {
            try
            {
                int x = 0;
                string filename = "";
                if (iv_linkname.SrNo != null && image1 != null)
                {
                    var f = iv_linkname.SrNo + "" + iv_linkname.ImgVideoPath;
                    if (System.IO.File.Exists(Path.Combine(_dir, "iv_LinkName\\" + f.ToString())))
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        System.IO.File.Delete(Path.Combine(_dir, "iv_LinkName\\" + f.ToString()));
                 
                    }

                }
                if (image1 != null)
                {
                    iv_linkname.ImgVideoPath = Path.GetExtension(image1.FileName);
                }
                x = iv_linkname.InsertUpdate();

                if (image1 != null)
                {
                    var path = "";
                    string extension = Path.GetExtension(image1.FileName);
                    filename = x + extension;
                    path = Path.Combine(_dir, "iv_LinkName\\" + filename);
                    if (image1.ContentType.Substring(0, image1.ContentType.LastIndexOf('/')) != "video")
                    {
                        using (Bitmap bitmap = new Bitmap(image1.OpenReadStream()))
                        {
                            using (Graphics graphics = Graphics.FromImage(bitmap))
                            {
                                Brush brush = new SolidBrush(Color.LightBlue);
                                System.Drawing.Font font = new System.Drawing.Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel);
                                SizeF sizeF = graphics.MeasureString("@Visual Infosoft", font);
                                Point point = new Point(bitmap.Width - ((int)sizeF.Width + 10), bitmap.Height - ((int)sizeF.Height + 10));
                                graphics.DrawString("@Visual Infosoft", font, brush, point);
                                using (MemoryStream memoryStream = new MemoryStream())
                                {
                                    bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    memoryStream.Position = 0;
                                    FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
                                    await image1.CopyToAsync(file);
                                    memoryStream.Close();
                                }
                            }

                        }
                       

                    }

                    else
                    {
                        var stream = new FileStream(path, FileMode.Create);
                        await image1.CopyToAsync(stream);
                        stream.Close();
                    }

                }
                if (x != -1)
                {
                    TempData["Msg"] = "Record Saved With ID = " + x;
                    TempData["Class"] = "alert alert-success";
                }
                else
                {
                    ViewBag.Msg = "Record Alread Exist";
                    ViewBag.Class = "alert alert-danger";
                    return View(iv_linkname);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
                ViewBag.Class = "alert alert-danger";
                return View();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int srno)
        {
            try
            {
                int res = iv_LinkName.Delete(srno);

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
            return RedirectToAction("Index");
        }
    }
}