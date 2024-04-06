﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.services.Repositories
{
    public interface IBrandRepository:IAsyncRepository<Brand>,IRepository<Brand>
    {

    }
}
