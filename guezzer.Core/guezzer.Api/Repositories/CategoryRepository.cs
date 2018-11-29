using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using guezzer.Data;
using guezzer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace guezzer.Api.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly GuezzerDbContext _context;

        public CategoryRepository(GuezzerDbContext context)
        {
            _context = context;
        }

        public Category Get(string type)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Type == type);

            if(category == null)
            {
                // Exception handler
                return null;
            }

            return category;
        }

        public IEnumerable GetAll()
        {
            var categories = _context.Categories.ToList();

            if (categories == null)
            {
                // Exception handler
                return null;
            }

            return categories;
        }
    }
}
