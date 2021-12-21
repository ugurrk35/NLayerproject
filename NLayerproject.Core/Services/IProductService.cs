﻿using NLayerproject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerproject.Core.Services
{
    public interface IProductService:IService<Product>
    {

        //veritabanı ile ilgili olmayan metodlar
        // bool ControlInnerBarcode(Product product);
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
