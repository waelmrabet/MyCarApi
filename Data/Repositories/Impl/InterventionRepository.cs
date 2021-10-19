using Core.Models;
using Data.Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Impl
{
    public class InterventionRepository: Repository<Intervention>, IInterventionRepository
    {
        public InterventionRepository(MyDataBaseContext dbCtx): base(dbCtx) { }

    }
}
