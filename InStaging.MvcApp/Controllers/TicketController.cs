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
    public class TicketController : BaseController
    {
        public TicketController(IUnitOfWork uow) : base(uow)
        {
        }

        public IActionResult Index()
        {
            var model = new TicketIndexVM();

            var ticketLogic = new TicketLogic(Uow);
            var activeTickets = ticketLogic.GetActiveTickets();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new TicketAddVM();
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(TicketAddVM model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            var model = new TicketEditVM();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(TicketEditVM model)
        {
            return View(model);
        }
    }
}
