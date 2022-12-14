using System;
using System.Reflection;

namespace Octopus.Server.Extensibility.Extensions.Infrastructure.Web.Content
{
    public class StaticContentEmbeddedResourcesFolder
    {
        public StaticContentEmbeddedResourcesFolder(string virtualDirectory, Assembly assembly, string @namespace)
        {
            VirtualDirectory = virtualDirectory;
            Assembly = assembly;
            Namespace = @namespace;
        }

        public string VirtualDirectory { get; set; }
        public Assembly Assembly { get; }
        public string Namespace { get; }
    }
}