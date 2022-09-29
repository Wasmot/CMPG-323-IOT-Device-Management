using DeviceManagement_WebApp.Data;
using System.Collections.Generic;
using System.Linq;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
   public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Category GetCategoryName()
        {
            return _context.Category.OrderByDescending(category => category.CategoryName).FirstOrDefault();
        }
    }

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’

    
}
