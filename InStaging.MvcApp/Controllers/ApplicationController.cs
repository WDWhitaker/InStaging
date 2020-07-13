using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InStaging.Domain.Interfaces;
using InStaging.Logic;
using InStaging.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace InStaging.MvcApp.Controllers
{
    public class ApplicationController : BaseController
    {
        public ApplicationController(IUnitOfWork uow) : base(uow)
        {
        }

        public IActionResult Index()
        {
            var appLogic = new ApplicationLogic(Uow);
            var model = new ApplicationIndexVM();
            model.Applications = appLogic.GetActiveApplications();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new ApplicationAddVM();
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(ApplicationAddVM model)
        {
            if (ModelState.IsValid)
            {
                var appLogic = new ApplicationLogic(Uow);

                var app = new Domain.Application();
                app.DateCreated = DateTime.Now;
                app.Archived = false;
                app.Name = model.Name;

                appLogic.CreateApplication(app);

                return RedirectToAction("Index");
            }


            return View(model);
        }



        public IActionResult GetContext()
        {
            return PartialView();
        }
        public IActionResult SetContext(Guid appId)
        {
            return PartialView();
        }

    }
}
