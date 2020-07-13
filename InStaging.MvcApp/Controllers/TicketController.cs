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
            var ticketLogic = new TicketLogic(Uow);
            var model = new TicketIndexVM();
            model.ActiveTickets = ticketLogic.GetActiveTickets();
            return View(model);
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
            if (ModelState.IsValid)
            {
                var tLogic = new TicketLogic(Uow);

                var ticket = new Domain.Ticket();
                ticket.DateCreated = DateTime.Now;
                ticket.Archived = false;
                ticket.Description = model.Description;
                ticket.Status = Domain.Enums.TicketStatus.Backlog;
                ticket.Title = model.Title;
                ticket.Type = model.Type;

                tLogic.CreateTicket(ticket);

                return RedirectToAction("Index");
            }


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
