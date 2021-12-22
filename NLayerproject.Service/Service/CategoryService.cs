using NLayerproject.Core.Models;
using NLayerproject.Core.Repositories;
using NLayerproject.Core.Services;
using NLayerproject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerproject.Service.Service
{
    public class CategoryService : Service<Category>,ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {

        }
        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
         return await _unitOfWork.Categories.GetWithProductByIdAsync(categoryId);
        }
    }
}
