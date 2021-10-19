using BLL.ServicePattern;
using Core.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Impl
{
    public class VehiculeService: ServicePattern<Vehicule>, IVehiculeService
    {
        public VehiculeService(IVehiculeRepository vehiculeRepo): base(vehiculeRepo)
        {

        }
    }
}
