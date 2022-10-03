using BMES_API_Project.Messages.DTOs.Product;
using BMES_API_Project.Models;
using BMES_API_Project.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_API_Project.Messages
{
    public class MessageMapper
    {
        public Brand MapToBrand(BrandDTO brandDto)
        {
            var brand = new Brand
            {
                Id = brandDto.Id,
                Name = brandDto.Name,
                Slug = brandDto.Slug,
                Description = brandDto.Description,
                MetaDescription = brandDto.MetaDescription,
                MetaKeywords = brandDto.MetaKeywords,
                BrandStatus = (BrandStatus)brandDto.BrandStatus,
                ModifiedDate = brandDto.ModifiedDate,
                isDeleted = brandDto.isDeleted
            };

            return brand;
        }

        public BrandDTO MapToBrandDto(Brand brand)
        {
            return new BrandDTO
            {
                Id = brand.Id, 
                Name = brand.Name, 
                Slug = brand.Slug, 
                Description = brand.Description,
                MetaDescription = brand.MetaDescription, 
                MetaKeywords = brand.MetaKeywords, 
                BrandStatus = (int)brand.BrandStatus, 
                ModifiedDate = brand.ModifiedDate, 
                isDeleted = brand.isDeleted
            };
        }
        public Category MapToCategory(CategoryDTO categoryDto)
        {
            var category = new Category
            {
                Id = categoryDto.Id,
                Name = categoryDto.Name,
                Slug = categoryDto.Slug, 
                Description = categoryDto.Description,
                MetaDescription = categoryDto.MetaDescription,
                MetaKeywords = categoryDto.MetaKeywords, 
                CategoryStatus = (CategoryStatus)categoryDto.CategoryStatus, 
                ModifiedDate = categoryDto.ModifiedDate, 
                isDeleted = categoryDto.isDeleted
            };

            return category;
        }
    }
}
