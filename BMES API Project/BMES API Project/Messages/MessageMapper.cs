using BMES_API_Project.Messages.DTOs.Cart;
using BMES_API_Project.Messages.DTOs.Product;
using BMES_API_Project.Models;
using BMES_API_Project.Models.Cart;
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
            var brandDto = new BrandDTO();
            if(brand != null)
            {
                brandDto.Id = brand.Id;
                brandDto.Name = brand.Name;
                brandDto.Slug = brand.Slug;
                brandDto.Description = brand.Description;
                brandDto.MetaDescription = brand.MetaDescription;
                brandDto.MetaKeywords = brand.MetaKeywords;
                brandDto.BrandStatus = (int)brand.BrandStatus;
                brandDto.ModifiedDate = brand.ModifiedDate;
                brandDto.isDeleted = brand.isDeleted;
            }

            return brandDto;
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
                ModifiedDate = category.ModifiedDate,
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
                IsBestseller = productDto.IsBestseller, 
                CategoryId = productDto.CategoryId,
                BrandId = productDto.BrandId, 
                ProductStatus = (ProductStatus)productDto.ProductStatus, 
                CreatedDate = productDto.CreateDate,
                ModifiedDate = productDto.ModifiedDate,
                isDeleted = productDto.IsDeleted
            };

            return product;
        }

        public ProductDTO MapToProductDto(Product product)
        {
            var productDto = new ProductDTO();

            if (product != null)
            {
                productDto.Id = product.Id;
                productDto.Name = product.Name;
                productDto.Slug = product.Slug;
                productDto.Description = product.Description;
                productDto.MetaDescription = product.MetaDescription;
                productDto.MetaKeywords = product.MetaKeywords;
                productDto.SKU = product.MetaDescription;
                productDto.Model = product.MetaKeywords;
                productDto.Price = product.Price;
                productDto.SalePrice = product.SalePrice;
                productDto.OldPrice = product.OldPrice;
                productDto.ImageUrl = product.ImageUrl;
                productDto.QuantityInStock = product.QuantityInStock;
                productDto.IsBestseller = product.IsBestseller;
                productDto.CategoryId = product.CategoryId;
                productDto.BrandId = product.BrandId;
                productDto.ProductStatus = (int)product.ProductStatus;
                productDto.CreateDate = product.CreatedDate;
                productDto.ModifiedDate = product.ModifiedDate;
                productDto.IsDeleted = product.isDeleted;
            };

            return productDto;
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

        public CartDTO MaptoCartDto(Cart cart)
        {
            var cartDto = new CartDTO(); 
            if(cart != null)
            {
                cartDto.Id = cart.Id;
                cartDto.UniqueCartId = cart.UniqueCartId;
                cartDto.CartStatues = (int)cart.CartStatus;
                cartDto.CreateDate = cart.CreatedDate;
                cartDto.ModifiedDate = cart.ModifiedDate;
                cartDto.isDeleted = cart.isDeleted; 
            }
            return cartDto;
        }

        public Cart MapToCart(CartDTO cartDTO)
        {
            return new Cart
            {
                Id = cartDTO.Id,
                UniqueCartId = cartDTO.UniqueCartId,
                CartStatus = (CartStatus)cartDTO.CartStatues,
                CreatedDate = cartDTO.CreateDate,
                ModifiedDate = cartDTO.ModifiedDate,
                isDeleted = cartDTO.isDeleted
            };
        }

        public CartItemDTO MaptoCartItemDto(CartItem cartItem)
        {
            CartItemDTO cartItemDTO = null; 
            if(cartItem.Product != null)
            {
                var productDto = MapToProductDto(cartItem.Product);
                cartItemDTO = new CartItemDTO
                {
                    Id = cartItem.Id,
                    CartId = cartItem.CartId,
                    Product = productDto,
                    Quantity = cartItem.Quantity
                }; 
            }
            return cartItemDTO; 
        }

        public CartItem MaptoCartItem(CartItemDTO cartItemDTO)
        {
            return new CartItem
            {
                CartId = cartItemDTO.Id,
                ProductId = cartItemDTO.Product.Id,
                Quantity = cartItemDTO.Quantity
            }; 
        }

        public List<CartItemDTO> MaptoCartItemDto(IEnumerable<CartItem> cartItems)
        {
            var cartItemDtos = new List<CartItemDTO>(); 
            foreach(var cartIem in cartItems)
            {
                var cartItemDto = MaptoCartItemDto(cartIem);
                cartItemDtos.Add(cartItemDto); 
            }
            return cartItemDtos; 
        }
    }
}
