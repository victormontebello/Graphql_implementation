using GraphQLExemplo.Query;

namespace GraphQLExemplo.Schema
{
    public class MenuSchema : GraphQL.Types.Schema
    {
        public MenuSchema(MenuQuery menuQuery)
        { 
               Query = menuQuery;
        }
    }
}
