using GraphQL.Types;
using GraphQL_Udemy.Models;

namespace GraphQL_Udemy.Types
{
    public class MenuItemInputType: InputObjectGraphType
    {
        public MenuItemInputType() 
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
            Field<FloatGraphType>("price");

        }
    }
}
