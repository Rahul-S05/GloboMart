using StructureMap;

namespace GloboMart.App.Api.DependencyResolution
{
    public static class IoC
    {
        public static IContainer container;

        public static IContainer Initialize()
        {
            container = new Container(r => r.AddRegistry<IoCRegistry>());

            return container;
        }
    }
}