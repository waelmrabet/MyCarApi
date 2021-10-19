using BLL.ServicePattern;
using Core.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Impl
{
    public class InterventionService: ServicePattern<Intervention>, IInterventionService
    {
        private readonly IInterventionRepository _interventionRepository;

        public InterventionService(IInterventionRepository interventionRepo): base(interventionRepo)
        {
            this._interventionRepository = interventionRepo;
        }
    }
}
