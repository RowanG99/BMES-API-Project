using BMES_API_Project.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_API_Project.Models.Product
{
    public class Brand:BaseObject
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public BrandStatus BrandStatus { get; set; }
    }
}
