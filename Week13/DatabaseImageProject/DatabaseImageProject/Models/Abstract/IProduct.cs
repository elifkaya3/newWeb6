﻿using DatabaseImageProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Models.Abstract
{
    public interface IProduct: IRepository<Product>
    {
    }
}
