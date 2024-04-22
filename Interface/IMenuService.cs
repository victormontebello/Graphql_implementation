using GraphQLExemplo.Models;

namespace GraphQLExemplo.Interface
{
    public interface IMenuService
    {
        List<Menu> GetAll();
        Menu GetById(int id);
        void AddMenu(Menu menu);
        void RemoveMenu(int id);
        void UpdateMenu(Menu menu);
    }
}
