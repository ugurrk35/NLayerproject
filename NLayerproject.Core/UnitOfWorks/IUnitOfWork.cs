using NLayerproject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerproject.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }   //bunlar burada vermeyebiliriz dependency injection ile beraber kullanabilir
        ICategoryRepository Categories { get; }
       
        Task CommitAsync();  //implement ettiğimiz save change metodu çağıracak

        void Commit();
    }
}
