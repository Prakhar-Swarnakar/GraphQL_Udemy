using GraphQL.Types;
using GraphQL_Udemy.Models;

namespace GraphQL_Udemy.Types
{
    public class MenuItemType:ObjectGraphType<MenuItem>
    {
        public MenuItemType()
        {
            //mapping between the model class and graphQL type system
            //exposing the menuItem model as field in graphQL
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Description);
            Field(m=>m.Price);
        }
    }
}
