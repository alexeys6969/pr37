using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface ICategorys
    {
        public IEnumerable<Categories> AllCategories { get; }
    }
}
