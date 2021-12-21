using NLayerproject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerproject.Core.Services
{
    public  interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);
        // category ozgu metodlar ,hesaplarlamalar,veritabanına baglantı olmadan helper ozel url vb.
    }
}
