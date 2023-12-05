using GraphQL_Udemy.Interfaces;
using GraphQL_Udemy.Models;

namespace GraphQL_Udemy.Services
{
    public class MenuRepository : IMenuRepository
    {
        private readonly List<MenuItem> MenuList = new List<MenuItem>()
        {
            new MenuItem() 
            { 
                Id = 1, 
                Name = "Classic Burger", 
                Description="A juicy chicken burger with lettuce and cheese", 
                Price = 10.99 
            },                                                                                                               
            new MenuItem() 
            { 
                Id = 2, 
                Name = "Margherita Pizza",
                Description = "Tomato, mozzarella, and basil pizza",
                Price = 10.50 
            },
            new MenuItem() { Id = 3, Name = "Grilled Chi xen Salad", Description = "Fresh garden salad with grilled chicken", Price= 55},
            new MenuItem() { Id = 4, Name = "Pasta Alfre o", Description = "Creamy Alfredo sauce with fettuccine pasta", Price = 12.55 }
            ,
            new MenuItem() { Id = 5, Name = "Chocolate Bi wnie Sur ae", Description = "Warm chocolate brownie with ice cream and fudge", Price = 10 }
        };

        public MenuItem AddMenuItem(MenuItem menuItem)
        {
            MenuList.Add(menuItem);
            return menuItem;
        }

        public void DeleteMenuItem(int id)
        {
            MenuList.Remove(MenuList.FirstOrDefault(m => m.Id == id));
        }

        public List<MenuItem> GetAllMenuItem()
        {
            return MenuList;
        }

        public MenuItem GetMenuItemById(int id)
        {
            return MenuList.FirstOrDefault(m => m.Id == id);
        }

        public MenuItem UpdateMenuItem(int id, MenuItem menuItem)
        {
            MenuList.Remove(MenuList.FirstOrDefault(m => m.Id == id));
            MenuList.Add(menuItem);
            return MenuList.Where(x => x.Id == menuItem.Id).FirstOrDefault();
            //MenuList.FirstOrDefault(m => m.Id == id)
            //MenuList[id] = menuItem;
            //return menuItem;
        } 
       
    }
}

