using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubUI.Areas.User.Controllers
{
    [Authorize(Roles = "A,U")]
    public class SubmitURLController : BaseUserController
    {
        // GET: User/SubmitURL
        public ActionResult Index()
        {
            ViewBag.CategoryId = new SelectList(objBs.categoryBs.GetAll().ToList(), "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbl_Url urls)
        {
            try
            {
                urls.IsApproved = "P";
                urls.UserId = objBs.userBs.GetAll().Where(x => x.UserEmail == User.Identity.Name).FirstOrDefault().UserId;
                if (ModelState.IsValid)
                {
                    objBs.urlBs.Insert(urls);
                    TempData["Msg"] = "Created Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.CategoryId = new SelectList(objBs.categoryBs.GetAll().ToList(), "CategoryId", "CategoryName");
                    return View("Index");
                }

            }
            catch (Exception e1)
            {

                TempData["Msg"] = "Create Failed :" + e1.Message;
                return RedirectToAction("Index");
            }

        }
    }
}