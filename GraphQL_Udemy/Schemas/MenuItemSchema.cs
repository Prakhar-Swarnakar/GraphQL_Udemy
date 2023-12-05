using GraphQL_Udemy.Mutations;
using GraphQL_Udemy.Queries;

namespace GraphQL_Udemy.Schemas
{
    public class MenuItemSchema:GraphQL.Types.Schema
    {
        public MenuItemSchema(MenuItemQuery menuItemQuery,MenuItemMutation menuItemMutation)
        {
            Query = menuItemQuery;
            Mutation = menuItemMutation;
        }
    }
}
