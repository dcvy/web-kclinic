﻿using Kclinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kclinic.DataAccess.Repository.IRepository
{
    public interface IFeatureRepository : IRepository<Feature>
    {
        void Update(Feature obj);
    }
}
