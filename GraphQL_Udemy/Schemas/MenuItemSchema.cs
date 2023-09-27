using GraphQL_Udemy.Queries;

namespace GraphQL_Udemy.Schemas
{
    public class MenuItemSchema:GraphQL.Types.Schema
    {
        public MenuItemSchema(MenuItemQuery menuItemQuery)
        {
            Query = menuItemQuery;
        }
    }
}
