using System;
using System.Threading;
using System.Threading.Tasks;
using Octopus.Server.MessageContracts;

namespace Octopus.Server.Extensibility.Mediator
{
    public interface IEventuallyHandleEvent<in TEvent> where TEvent : IEvent
    {
        Task Handle(TEvent e, CancellationToken cancellationToken);
    }
}