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
        public List<BrandDTO> MapToBrandDtos(IEnumerable<Brand> brands)
        {
            var brandDtos = new List<BrandDTO>(); 
            foreach(var brand in brands)
            {
                var brandDto = MapToBrandDto(brand);
                brandDtos.Add(brandDto); 
            }
            return brandDtos;
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

        public CategoryDTO MapToCategoryDto(Category category)
        {
            return new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Slug = category.Slug,
                Description = category.Description,
                MetaDescription = category.MetaDescription,
                MetaKeywords = category.MetaKeywords,
                CategoryStatus = (int)category.CategoryStatus,
                isDeleted = category.isDeleted
            };
        }
        public List<CategoryDTO> MapToCategoryDtos(IEnumerable<Category> categories)
        {
            var categoryDtos = new List<CategoryDTO>(); 
            foreach(var category in categories)
            {
                var categoryDto = MapToCategoryDto(category);
                categoryDtos.Add(categoryDto);
            }
            return categoryDtos;
        }

        public Product MapToProduct(ProductDTO productDto)
        {
            var product = new Product
            { 
                Id = productDto.Id, 
                Name = productDto.Name,
                Slug = productDto.Slug,
                Description = productDto.Description,
                MetaDescription = productDto.MetaDescription,
                MetaKeywords = productDto.MetaKeywords, 
                SKU = productDto.SKU, 
                Model = productDto.Model, 
                Price = productDto.Price,
                SalePrice = productDto.SalePrice, 
                OldPrice = productDto.OldPrice,
                ImageUrl = productDto.ImageUrl,
                QuantityInStock = productDto.QuantityInStock, 
                IsBestSeller = productDto.IsBestSeller, 
                CategoryId = productDto.CategoryId,
                BrandId = productDto.BrandId, 
                ProductStatus = (ProductStatus)productDto.ProductStatus, 
                CreatedDate = productDto.CreatedDate,
                ModifiedDate = productDto.ModifiedDate,
                isDeleted = productDto.isDeleted
            };

            return product;
        }

        public ProductDTO MapToProductDto(Product product)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Slug = product.Slug,
                Description = product.Description,
                MetaDescription = product.MetaDescription,
                MetaKeywords = product.MetaKeywords,
                SKU = product.SKU,
                Model = product.Model,
                Price = product.Price,
                SalePrice = product.SalePrice,
                OldPrice = product.OldPrice,
                ImageUrl = product.ImageUrl,
                QuantityInStock = product.QuantityInStock,
                IsBestSeller = product.IsBestSeller,
                CategoryId = product.CategoryId,
                BrandId = product.BrandId,
                ProductStatus = (int)product.ProductStatus,
                CreatedDate = product.CreatedDate,
                ModifiedDate = product.ModifiedDate,
                isDeleted = product.isDeleted
            };
        }

        public List<ProductDTO> MapToProductDtos(IEnumerable<Product> products)
        {
            var productDtos = new List<ProductDTO>(); 
            foreach(var product in products)
            {
                var productDto = MapToProductDto(product);
                productDtos.Add(productDto); 
            }
            return productDtos;
        }
    }
}
