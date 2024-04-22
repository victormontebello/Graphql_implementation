using GraphQL;
using GraphQL.Types;
using GraphQLExemplo.Interface;
using GraphQLExemplo.Type;

namespace GraphQLExemplo.Query
{
    public class MenuQuery : ObjectGraphType
    {
        private readonly IMenuService _menuService;
        public MenuQuery(IMenuService menuService) 
        {
            _menuService = menuService;

            Field<ListGraphType<MenuType>>("Menus").Resolve(context =>
            {
                return menuService.GetAll();
            });

            Field<MenuType>("SingleMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "Id" }))
             .Resolve(context =>
             {
                 return _menuService.GetById(context.GetArgument<int>("Id"));
             });  ;
        }
    }
}
