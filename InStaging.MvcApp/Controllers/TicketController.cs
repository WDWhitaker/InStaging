using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InStaging.Domain.Interfaces;
using InStaging.MvcApp.Models.Ticket;
using Microsoft.AspNetCore.Mvc;

namespace InStaging.MvcApp.Controllers
{
    public class TicketController : BaseController
    {
        public TicketController(IUnitOfWork uow) : base(uow)
        {
        }

        public IActionResult Index()
        {
            //var ticketLogic = new TicketLogic(Uow).
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new AddViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(AddViewModel model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            var model = new EditViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditViewModel model)
        {
            return View(model);
        }
    }
}
