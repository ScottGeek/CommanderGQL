using System.Linq;
using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace CommanderGQL.GraphQL.Commands
{
    public class CommandType : ObjectType<Command>
    {
      protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
      {
          descriptor.Description("Represents any executable command.");

            descriptor
             .Field(c => c.Platform)
             .ResolveWith<Resolvers>(c => c.GetPlatform(default!, default!))
             .UseDbContext<AppDbContext>()
             .Description("This is the platform to which the command belongs to.");

            descriptor
             .Field(c => c.HowTo)
             .Description("This is how to do the command in basic form.");

            descriptor
             .Field(c => c.Id)
             .Description("System Generated Id Key.");

      }

        private class Resolvers
        {
            public Platform GetPlatform(Command command, [ScopedService] AppDbContext context)
            {
               return context.Platforms.FirstOrDefault(p => p.Id == command.PlatformId);
            }

        }

    }

}