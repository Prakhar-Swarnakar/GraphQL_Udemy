using GraphQL;
using GraphQL.Types;
using GraphQL_Udemy.Interfaces;
using GraphQL_Udemy.Models;
using GraphQL_Udemy.Types;

namespace GraphQL_Udemy.Mutations
{
    public class MenuItemMutation : ObjectGraphType
    {
        public MenuItemMutation( IMenuRepository _menuRepository)
        {
            //Return type
            Field<MenuItemType>("CeateMenuItem")
                .Arguments(new QueryArguments(new QueryArgument<MenuItemInputType> { Name = "menuItem" }))
                .Resolve(context =>
                {
                    return _menuRepository.AddMenuItem(context.GetArgument<MenuItem>("menuItem"));
                });
            Field<MenuItemType>("UpdateMenuItem")
                 .Arguments(new QueryArguments(
                     new QueryArgument<IntGraphType> { Name = "menuItemId"},
                     new QueryArgument<MenuItemInputType> { Name = "menuItem" }
                     ))
                 .Resolve(context =>
                 {
                     var id = context.GetArgument<int>("menuItemId");
                     var item = context.GetArgument<MenuItem>("menuItem");
                     return _menuRepository.UpdateMenuItem(id, item);
                 });
            Field<StringGraphType>("DeleteMenuItem")
                 .Arguments(new QueryArguments(
                     new QueryArgument<IntGraphType> { Name = "menuItemId" },
                     new QueryArgument<MenuItemInputType> { Name = "menuItem" }
                     ))
                 .Resolve(context =>
                 {
                     var id = context.GetArgument<int>("menuItemId");
                     _menuRepository.DeleteMenuItem(id);
                     return $"the Menu Item with id = {id} has been deleted" ;
                 });
        }
    }
}
