using GraphQLExemplo.Interface;
using GraphQLExemplo.Models;

namespace GraphQLExemplo.Services
{
    public class MenuService : IMenuService
    {
        public static List<Menu> menus = new List<Menu>()
        {
            new Menu(){Id = 1, Name="Cebola", Description="Alimento", Price=100.50},
            new Menu(){Id = 2, Name="pc", Description="Alimento", Price=100.50},
            new Menu(){Id = 3, Name="lista", Description="Alimento", Price=100.50},

        };
        public void AddMenu(Menu menu)
        {
            menus.Add(menu);
        }

        public List<Menu> GetAll()
        {
            return menus;
        }

        public Menu GetById(int id)
        {
            return menus.Find(x => x.Id.Equals(id)) ?? new Menu();
        }

        public void RemoveMenu(int id)
        {
            var menu = GetById(id);
            menus.Remove(menu);
        }

        public void UpdateMenu(Menu menu)
        {
            menus[menu.Id] = menu;
        }
    }
}
