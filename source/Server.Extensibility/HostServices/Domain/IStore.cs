﻿using Octopus.Data.Model;

namespace Octopus.Server.Extensibility.HostServices.Domain
{
    public interface IStore<out TDocument>
        where TDocument : IId
    {
        TDocument Get(string id);
    }
}