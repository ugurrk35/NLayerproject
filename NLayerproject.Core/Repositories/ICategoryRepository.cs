using NLayerproject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerproject.Core.Repositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);
    }
}
