﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnApi.Domain.Models;
using LearnApi.Resources;
using LearnApi.Services.Communication;

namespace LearnApi.Domain.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);


    }
}
