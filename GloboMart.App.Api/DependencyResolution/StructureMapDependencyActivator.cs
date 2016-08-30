using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using StructureMap;

namespace GloboMart.App.Api.DependencyResolution
{
    public class StructureMapActivator : IHttpControllerActivator
    {
        private readonly IContainer _container;

        public StructureMapActivator(IContainer container)
        {
            _container = container;
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            var nested = _container.GetNestedContainer();
            var instance = nested.GetInstance(controllerType) as IHttpController;
            request.RegisterForDispose(nested);
            return instance;
        }
    }
}