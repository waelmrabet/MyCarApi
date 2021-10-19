using Core.Models;
using Data.Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Impl
{
    public class VehiculeRepository: Repository<Vehicule>, IVehiculeRepository
    {
        public VehiculeRepository(MyDataBaseContext dbCtx): base(dbCtx) { }

    }
}
