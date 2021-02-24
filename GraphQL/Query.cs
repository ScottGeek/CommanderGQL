using System.Linq;
using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Data;

namespace CommanderGQL.GraphQL
{
    public class Query
    {

        //added pooled context decorator and make it ScopeService vs. Service    
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        // [UseProjection] remove because we have resolvers in the types
       public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
       {
          return context.Platforms; 
       }

        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        //[UseProjection]
       public IQueryable<Command> GetCommands([ScopedService] AppDbContext context)
       {
           return context.Commands;
       }

    }
}