using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCaregories : ICategorys
    {
        public IEnumerable<Categories> AllCategories
        {
            get
            {
                return new List<Categories>
                {
                    new Categories()
                    {
                        Id = 0,
                        Name = "Микроволновые печи",
                        Description = "Микроволновая печь - электроприбор для нагрева еды"
                    },

                    new Categories()
                    {
                        Id = 1,
                        Name = "Мультиварка",
                        Description = "Мультиварка готовит еду"
                    }
                };
            }
        }
    }
}
