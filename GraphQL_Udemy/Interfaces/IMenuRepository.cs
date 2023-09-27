using GraphQL_Udemy.Models;

namespace GraphQL_Udemy.Interfaces
{
    public interface IMenuRepository
    {
        MenuItem GetMenuItemById(int id);
        List<MenuItem> GetAllMenuItem();
        MenuItem AddMenuItem (MenuItem menuItem);
        void DeleteMenuItem(int id);
        MenuItem UpdateMenuItem (int id,MenuItem menuItem);
    }
}
