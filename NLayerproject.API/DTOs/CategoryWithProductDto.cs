using System.Collections.Generic;

namespace NLayerproject.API.DTOs
{
    public class CategoryWithProductDto:CategoryDto
    {
        public ICollection<ProductDto> Products { get; set; }

    }
}
