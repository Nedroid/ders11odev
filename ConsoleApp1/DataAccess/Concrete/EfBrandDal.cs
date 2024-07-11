﻿using ConsoleApp1.DataAccess.Abstract;
using Core.DataAccess.EntityFramework;
using RecapProjectCar.DataAccess.Concrete;
using RecapProjectCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataAccess.Concrete
{
    public class EfBrandDal:EfEntityRepositoryBase<Brand,RecapCarContext>,IBrandDal
    {
    }
}