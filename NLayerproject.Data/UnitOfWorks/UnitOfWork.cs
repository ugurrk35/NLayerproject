﻿using NLayerproject.Core.Repositories;
using NLayerproject.Core.UnitOfWorks;
using NLayerproject.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerproject.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _context=appDbContext;
        }
        public IProductRepository Products => _productRepository=_productRepository ?? new ProductRepository(_context);

        public ICategoryRepository Categories => _categoryRepository=_categoryRepository ?? new CategoryRepository(_context);   

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
