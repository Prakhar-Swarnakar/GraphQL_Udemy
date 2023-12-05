using GraphQL;
using GraphQL.Types;
using GraphQL_Udemy.Interfaces;
using GraphQL_Udemy.Types;

namespace GraphQL_Udemy.Queries
{
    public class MenuItemQuery:ObjectGraphType
    {
        public MenuItemQuery(IMenuRepository _menuRepository)
        {
            //return list of all menus
            Field<ListGraphType<MenuItemType>>("MenuItems")
                .Resolve(context =>
            {
                return _menuRepository.GetAllMenuItem();
            });

            Field<MenuItemType>("MenuItem")
                .Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" }))
                .Resolve(context =>
                {
                    return _menuRepository.GetMenuItemById(context.GetArgument<int>("menuId"));
                });
        }
    }
}
