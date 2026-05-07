using MySql.Data.MySqlClient;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.DataBase
{
    public class DBCategory : ICategorys
    {
        public IEnumerable<Categories> AllCategories
        {
            get
            {
                List<Categories> categories = new List<Categories>();
                MySqlConnection conn = Common.Connection.MySqlOpen();
                MySqlDataReader CategoriesData = Common.Connection.MySqlQuery("SELECT * FROM Categorys ORDER BY `Name`;", conn);
                while (CategoriesData.Read())
                {
                    categories.Add(new Categories()
                    {
                        Id = CategoriesData.IsDBNull(0) ? -1 : CategoriesData.GetInt32(0),
                        Name = CategoriesData.IsDBNull(1) ? null : CategoriesData.GetString(1),
                        Description = CategoriesData.IsDBNull(1) ? null : CategoriesData.GetString(2)
                    });
                }
                return categories;
            }
        }
    }
}
