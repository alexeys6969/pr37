using Microsoft.AspNetCore.Identity;
using Shop.Data.Models;

namespace Shop.Data.ViewModell
{
    public class VMItems
    {
        public IEnumerable<Items> Items { get; set; }
        public IEnumerable<Categories> Categories { get; set; }
        public int SelectCategory = 0;
    }
}
