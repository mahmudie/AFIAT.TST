using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using AFIAT.TST.Queries.Container;
using System;

namespace AFIAT.TST.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}