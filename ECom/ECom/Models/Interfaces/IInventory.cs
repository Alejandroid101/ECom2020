using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECom.Models.Interfaces
{
    /// <summary>
    /// IInventory interface will have our crud operations to eventually have an admin be able to use crud operations on our product 
    /// </summary>
    public interface IInventory 
    {
        //Create product 
        Task CreateProductAsync(Product product);

        //Get individual product
        Task<Product> GetProductByIDAsync(int id);

        //Get all products
        Task<List<Product>> GetProductsAsync();

        //Update specific product
        Task UpdateProductAsync(Product product);

        //Delete specific product
        Task DeleteProductAsync(int id);
    }
}
