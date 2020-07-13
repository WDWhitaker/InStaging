using InStaging.Domain;
using InStaging.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InStaging.Logic
{
    public class ApplicationLogic : BaseLogic
    {
        public ApplicationLogic(IUnitOfWork uow) : base(uow)
        {
        }


        public List<Application> GetActiveApplications()
        {
            var model = Uow.DataService
                .Applications
                .Where(a => a.Archived == false)
                .ToList();

            return model;
        }

        public void CreateApplication(Application app)
        {
            try
            {
                Uow.DataService.Applications.Add(app);
                Uow.DataService.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
