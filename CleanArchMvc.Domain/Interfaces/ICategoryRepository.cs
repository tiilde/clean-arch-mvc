using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Interfaces {
    public interface ICategoryRepository {
        
        // Task define uma operaão assíncrona
        // retorna uma lista de categorias
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> GetById(int? id);

        Task<Category> Create( Category category );
        Task<Category> Update( Category category );
        Task<Category> Remove( Category category );
    }
}